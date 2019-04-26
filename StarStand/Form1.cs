using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarStand
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCloseProgram_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (slidingpanel.Height == 622 & slidingpanel.Width == 225)
            {
                slidingpanel.Height = 622;
                slidingpanel.Width = 80;
                
                
            }
            else
            {
                slidingpanel.Height = 622;
                slidingpanel.Width = 225;
            }

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            setuserctr(clientes1);
        }

        private void btnOficina_Click(object sender, EventArgs e)
        {
            setuserctr(oficina1);
        }

        //Funções
        public void setuserctr(UserControl userctr)
        {
            if(this.panel1.Controls.Count > 0)
            {
                this.panel1.Controls.RemoveAt(0);
                    }

            userctr.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(userctr);
            //this.panel1.Tag = userctr; 
        }
    }
}