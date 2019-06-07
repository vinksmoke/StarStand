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
    public partial class GerirCarrosAlugados : Form
    {
        StarDBContainer bd = new StarDBContainer();

        const string MARCA = "Marca";
        const string MODELO = "Modelo";
        const string VALBASE = "Valor Base";

        bool togMoveForm;
        int MvalX;
        int MvalY;

        public GerirCarrosAlugados()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            //Campos Obrigatórios
            if (textboxMarca.Text.Equals(""))
            {
                MessageBox.Show("Marca: Campo Obrigatório!");
                return;
            }

            if (textboxMarca.Text.Equals("Marca"))
            {
                MessageBox.Show("Marca: Campo Obrigatório!");
                return;
            }

            if (textboxModelo.Text.Equals(""))
            {
                MessageBox.Show("Modelo: Campo Obrigatório!");
                return;
            }

            if (textboxModelo.Text.Equals("Modelo"))
            {
                MessageBox.Show("Modelo: Campo Obrigatório!");
                return;
            }

            if (textboxValorBase.Text.Equals(""))
            {
                MessageBox.Show("Valor Base: Campo Obrigatório!");
                return;
            }

            if (textboxValorBase.Text.Equals("Valor Base"))
            {
                MessageBox.Show("Valor Base: Campo Obrigatório!");
                return;
            }

            //Validações
            if (comboboxCombustivel.Text.Equals("Combustível"))
            {
                MessageBox.Show("Comustível: Selecione um tipo de combustível!");
                return;
            }

            if (textboxValorBase.Text.Count(c => char.IsLetter(c)) > 0)
            {
                MessageBox.Show("Valor Base: Este campo não permite letras!");
                return;
            }

            if (textboxValorBase.Text.Count(c => !char.IsSymbol(c)) == 0)
            {
                MessageBox.Show("Valor Base: Este campo não permite letras!");
                return;
            }

            if (btnInserir.Text == "Inserir")
            {
                CarroAluguer aluguer = new CarroAluguer();
                aluguer.Marca = textboxMarca.Text.Trim();
                aluguer.Modelo = textboxModelo.Text.Trim();
                aluguer.ValorBase = decimal.Parse(textboxValorBase.Text.Trim());
                aluguer.Matricula = "StarStand";
                aluguer.Combustivel = comboboxCombustivel.SelectedText;
                aluguer.Estado = "Disponível";
                bd.CarrosSet.Add(aluguer);                
            }
            else
            {
               CarroAluguer aluguer = (CarroAluguer)bd.CarrosSet.OfType<CarroAluguer>();
                aluguer.Marca = textboxMarca.Text.Trim();
                aluguer.Modelo = textboxModelo.Text.Trim();
                aluguer.ValorBase = decimal.Parse(textboxValorBase.Text.Trim());
                bd.Entry(aluguer).State = EntityState.Modified;
            }

            bd.SaveChanges();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        //Mover Form
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
            if (togMoveForm == true)
            {
                SetDesktopLocation(MousePosition.X - MvalX, MousePosition.Y - MvalY);
            }
        }

        //Funções
        //Remover e Adicionar Placeholders
        private void setplaceholder(Bunifu.Framework.UI.BunifuMaterialTextbox texbox, string texto)
        {
            if (texbox.Text == "")
            {
                texbox.Text = texto;
                texbox.TextAlign = HorizontalAlignment.Center;

            }
        }
        private void removeplaceholder(Bunifu.Framework.UI.BunifuMaterialTextbox texbox, string texto)
        {
            if (texbox.Text == texto)
            {
                texbox.Text = "";
                texbox.TextAlign = HorizontalAlignment.Left;

            }
        }

        //Layout
        //Textbox "Marca"
        private void textboxMarca_Enter(object sender, EventArgs e)
        {
            removeplaceholder(textboxMarca, MARCA);
        }

        private void textboxMarca_Leave(object sender, EventArgs e)
        {
            setplaceholder(textboxMarca, MARCA);
        }

        //Textbox "Modelo"
        private void textboxModelo_Enter(object sender, EventArgs e)
        {
            removeplaceholder(textboxModelo, MODELO);
        }

        private void textboxModelo_Leave(object sender, EventArgs e)
        {
            setplaceholder(textboxModelo, MODELO);
        }

        //Textbox "Valor Base"
        private void textboxValorBase_Enter(object sender, EventArgs e)
        {
            removeplaceholder(textboxValorBase, VALBASE);
        }

        private void textboxValorBase_Leave(object sender, EventArgs e)
        {
            setplaceholder(textboxValorBase, VALBASE);
        }
    }
}