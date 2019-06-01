using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarStand
{
    public partial class USaluguer : UserControl
    {
        StarDBContainer bd;
        public USaluguer()
        {
            InitializeComponent();
        }

        public void lerdadosclientes()
        {
            bd = new StarDBContainer();
            listboxClientes.list.DataSource = bd.UtilizadoresSet.ToList();
        }

        private void listboxClientes_Load(object sender, EventArgs e)
        {
            
            
        }
    }
}
