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
using negocio;//para poder usar el objeto

namespace ado_net_ejemplo
{
    public partial class frmAltaPokemon : Form
    {
        private Pokemon pokemon = null;
        public frmAltaPokemon()
        {
            InitializeComponent();
        }
        public frmAltaPokemon(Pokemon pokemon)
        {
            InitializeComponent();
            this.pokemon=pokemon;
            Text = "Modificar Pokemon";
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            PokemonNegocio negocio = new PokemonNegocio();

            try
            {
                if (pokemon == null)
                    pokemon = new Pokemon();
                pokemon.Numero = int.Parse(txtNumero.Text);//esta casteado a entero por eso en int.Parse
                pokemon.Nombre = txtNombre.Text;
                pokemon.Descripcion = txtDescripcion.Text;
                pokemon.UrlImagen = txtUrlImagen.Text;
                pokemon.Tipo = (Elemento)cboTipo.SelectedItem;//desde el combobox obtiene un elemento, entonces por eso lo casteo
                pokemon.Debilidad = (Elemento)cboDebilidad.SelectedItem;
            
                
                if(pokemon.Id!=0)
                {
                    negocio.modificar(pokemon);
                    MessageBox.Show("Modificado exitosamente");

                }
                else
                {
                    negocio.agregar(pokemon);
                    MessageBox.Show("agregado exitosamente");

                }
                

                
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAltaPokemon_Load(object sender, EventArgs e)
        {
            ElementoNegocio elementoNegocio = new ElementoNegocio();
            try
            {
                cboTipo.DataSource = elementoNegocio.listar();//me completa los combobox
                cboTipo.ValueMember = "Id";
                cboTipo.DisplayMember = "Descripcion";
                cboDebilidad.DataSource = elementoNegocio.listar();//tengo que repetir por cada combobox que tenga (desplegable)
                cboDebilidad.ValueMember="Id";
                cboDebilidad.DisplayMember = "Descripcion";
                if(pokemon!=null)
                {
                    txtNumero.Text = pokemon.Numero.ToString();
                    txtNombre.Text = pokemon.Nombre;
                    txtDescripcion.Text = pokemon.Descripcion;
                    txtUrlImagen.Text = pokemon.UrlImagen;
                    cargarImagen(pokemon.UrlImagen);
                    cboTipo.SelectedValue = pokemon.Tipo.Id;
                    cboDebilidad.SelectedValue = pokemon.Debilidad.Id;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtUrlImagen.Text);
        }
        private void cargarImagen(string imagen)
        {

            try
            {
                pbxPokemon.Load(imagen);

            }
            catch (Exception ex)
            {
                pbxPokemon.Load("https://img.freepik.com/vector-premium/vector-icono-imagen-predeterminado-pagina-imagen-faltante-diseno-sitio-web-o-aplicacion-movil-no-hay-foto-disponible_87543-11093.jpg?w=2000");
            }
        }
    }
}
