﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

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
            setuserctr(clientes1);
            clientes1.lerdados();      
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

        //Close/Minimize
        private void BtnMinimize_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Sidebar
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



        //Menus
        private void btnCliente_Click(object sender, EventArgs e)
        {
            setuserctr(clientes1);
            clientes1.lerdados();
            btnOficina.Normalcolor = Color.FromArgb(14, 25, 32);
            btnCliente.Normalcolor = Color.Maroon;
            btnVendas.Normalcolor = Color.FromArgb(14, 25, 32);
            btnAluguer.Normalcolor = Color.FromArgb(14, 25, 32);
        }
        private void btnOficina_Click(object sender, EventArgs e)
        {
            setuserctr(oficina1);
            oficina1.lerdadosclientes();
            btnOficina.Normalcolor = Color.Maroon;
            btnCliente.Normalcolor = Color.FromArgb(14, 25, 32);
            btnVendas.Normalcolor = Color.FromArgb(14, 25, 32);
            btnAluguer.Normalcolor = Color.FromArgb(14, 25, 32);
        }
        private void BtnVendas_Click(object sender, EventArgs e)
        {
            setuserctr(venda1);
            btnOficina.Normalcolor = Color.FromArgb(14, 25, 32);
            btnCliente.Normalcolor = Color.FromArgb(14, 25, 32);
            btnVendas.Normalcolor = Color.Maroon;
            btnAluguer.Normalcolor = Color.FromArgb(14, 25, 32);
        }
        private void BtnAluguer_Click(object sender, EventArgs e)
        {
            setuserctr(venda1);
            btnOficina.Normalcolor = Color.FromArgb(14, 25, 32);
            btnCliente.Normalcolor = Color.FromArgb(14, 25, 32);
            btnVendas.Normalcolor = Color.FromArgb(14, 25, 32);
            btnAluguer.Normalcolor = Color.Maroon;
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
    }
}