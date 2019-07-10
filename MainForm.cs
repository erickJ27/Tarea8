using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OdontologySystem.Registros;
using OdontologySystem.Consultas;
namespace OdontologySystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void RegistroDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rUsuarios ver = new rUsuarios();
            ver.Show();
        }

        private void ConsultaDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cUsuarios ver = new cUsuarios();
            ver.Show();
        }
    }
}
