using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using BLL;


namespace OdontologySystem
{
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            //Name
        }
        public void Logear()
        {
            try
            {
                

            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {

            }
        }
        private void IniciarSesionButton_Click(object sender, EventArgs e)
        {
            //Logear(UsuarioTextBox.Text, ClaveTextBox.Text);

        }
    }
}
