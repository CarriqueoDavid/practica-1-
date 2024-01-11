using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using negocio;
namespace ado_net_ejemplo
{
    public partial class fmrpokemons : Form
    {
        private List<Pokemon> listaPokemon;
        private List<Elemento> listaPokemon2;
        public fmrpokemons()
        {
            InitializeComponent();
        }

        private void fmrpokemons_Load(object sender, EventArgs e)
        {
            cargar();
            cbocampo.Items.Add("Numero");
            cbocampo.Items.Add("Nombre");
            cbocampo.Items.Add("Descripcion");

        }

        private void dgvpokemon_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvpokemon.CurrentRow!=null)
            {
                Pokemon seleccionado = (Pokemon)dgvpokemon.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.UrlImagen);
            }
            
        }
        private void cargar()
        {
            PokemonNegocio negocio = new PokemonNegocio();

            try
            {
                listaPokemon = negocio.Listar();
                dgvpokemon.DataSource = listaPokemon;
                OcultarColumnas();
                cargarImagen(listaPokemon[0].UrlImagen);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            ElementoNegocio ele = new ElementoNegocio();
            listaPokemon2 = ele.listar();
            for (int i = 0; i < listaPokemon2.Count; i++)//podria hacer una funcion
            {
                listBox1.Items.Add(listaPokemon2[i].Descripcion);
            }
        }//refresca la lista de pokemon en el visor
        //meotodo para ocultar columnas
        private void OcultarColumnas()
        {
            dgvpokemon.Columns["UrlImagen"].Visible = false;//borra la columnas de las URL
            dgvpokemon.Columns["Id"].Visible = false;
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pb_pokemon.Load(imagen);

            }
            catch(Exception ex) 
            {
                pb_pokemon.Load("https://img.freepik.com/vector-premium/vector-icono-imagen-predeterminado-pagina-imagen-faltante-diseno-sitio-web-o-aplicacion-movil-no-hay-foto-disponible_87543-11093.jpg?w=2000");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaPokemon alta = new frmAltaPokemon();
            alta.ShowDialog();
            cargar();

        }

        private void bmodif_Click(object sender, EventArgs e)
        {
            //primero precargamos el pokeon seleccionado
            Pokemon seleccionado;
            seleccionado = (Pokemon)dgvpokemon.CurrentRow.DataBoundItem;
            frmAltaPokemon modificar = new frmAltaPokemon(seleccionado);
            modificar.ShowDialog();
            cargar();

        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void btneliminarlogico_Click(object sender, EventArgs e)
        {
            eliminar(true);

        }
        //metodo eliminar para utilizarlo en eliminar fisico y en el logico
        private void eliminar(bool logico = false)
        {

            PokemonNegocio negocio = new PokemonNegocio();
            Pokemon seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("estas seguro que quiere eliminar", "eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Pokemon)dgvpokemon.CurrentRow.DataBoundItem;
                    if (logico)
                    negocio.eliminarLogico(seleccionado.Id);
                    else
                    negocio.eliminar(seleccionado.Id);
                    cargar();
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private bool validarfiltro()
        {
            if(cbocampo.SelectedIndex<0)
            {
                MessageBox.Show("seleccionar campo");
                return true;
            }
            if(cbocriterio.SelectedIndex<0)
            {
                MessageBox.Show("seleccione criterio");
                return true;
            }
            if(cbocampo.SelectedItem.ToString()=="Numero")
            {
                if(string.IsNullOrEmpty(txtfiltro.Text))
                {
                    MessageBox.Show("Solo cargar filtro numerico");
                    return true;
                }
                if(!(soloNumeros(txtfiltro.Text)));
                {
                    MessageBox.Show("Solo nros para filtrar");
                    return true;
                }
            }
            return false;
        }
        private bool soloNumeros(string cadena)
        {
            foreach(char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                    return false;
            }
            return true;
        }

        private void btnfiltro_Click(object sender, EventArgs e)//boton de buscar
        {
            PokemonNegocio negocio = new PokemonNegocio();
            try
            {
                if (validarfiltro())
                {
                    return;
                }
                string campo = cbocampo.SelectedItem.ToString();
                string criterio = cbocriterio.SelectedItem.ToString();
                string filtro = txtclave.Text;
                dgvpokemon.DataSource = negocio.filtrar(campo, criterio,filtro);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           
        }

        private void txtfiltro_TextChanged(object sender, EventArgs e)
        {
            List<Pokemon> listaFiltrada;
            string filtro = txtfiltro.Text;
            if (filtro.Length>3)
            {
                listaFiltrada = listaPokemon.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Tipo.Descripcion.ToUpper().Contains(filtro.ToUpper()));//parametro expresion lamda
            }
            else
            {
                listaFiltrada = listaPokemon;
            }

            dgvpokemon.DataSource = null;
            dgvpokemon.DataSource = listaFiltrada;
            OcultarColumnas();
        }

        private void cbocampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion= cbocampo.SelectedItem.ToString();
            if(opcion=="Numero")
            {
                cbocriterio.Items.Clear();
                cbocriterio.Items.Add("mayor a");
                cbocriterio.Items.Add("menor a");
                cbocriterio.Items.Add("igual a");
            }else
            {
                cbocriterio.Items.Clear();
                cbocriterio.Items.Add("comienza con");
                cbocriterio.Items.Add("termina con");
                cbocriterio.Items.Add("contiene");
            }
        }
    }
}
