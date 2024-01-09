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
           
        }

        private void dgvpokemon_SelectionChanged(object sender, EventArgs e)
        {
            Pokemon seleccionado = (Pokemon)dgvpokemon.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.UrlImagen);
        }
        private void cargar()
        {
            PokemonNegocio negocio = new PokemonNegocio();

            try
            {
                listaPokemon = negocio.Listar();
                dgvpokemon.DataSource = listaPokemon;
                dgvpokemon.Columns["UrlImagen"].Visible = false;//borra la columnas de las URL
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
    }
}
