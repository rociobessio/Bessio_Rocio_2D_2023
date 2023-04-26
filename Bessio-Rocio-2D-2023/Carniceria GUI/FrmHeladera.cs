using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carniceria_GUI
{
    public partial class FrmHeladera : Form
    {
        public FrmHeladera(Vendedor vendedor)
        {
            InitializeComponent();
            this.label1.Text = $"Hola {vendedor.Usuario.ToString()}";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
