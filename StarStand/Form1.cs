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
        bool togMoveForm;
        int MvalX;
        int MvalY;
        public Form1()
        {
            InitializeComponent();
        }
        // Moving form
        private void PanelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            togMoveForm = true;
            MvalX = e.X;
            MvalY = e.Y;
        }
        private void PanelHeader_MouseUp(object sender, MouseEventArgs e)
        {
            togMoveForm = false;
        }
        private void PanelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if(togMoveForm==true)
            {
                SetDesktopLocation(MousePosition.X - MvalX, MousePosition.Y - MvalY);
            }
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
            if(this.panelBody.Controls.Count > 0)
            {
                this.panelBody.Controls.RemoveAt(0);
                    }

            userctr.Dock = DockStyle.Fill;
            this.panelBody.Controls.Add(userctr);
            //this.panel1.Tag = userctr; 
        }

        public void placeholder(TextBox textbox,string textToPlaceHolder)
        {
            if (textbox.Text == "")
            {
                textbox.Text = textToPlaceHolder;
            }
            if(textbox.Text == textToPlaceHolder)
            {
                textbox.Text = "";
            }
        }

    }
}