using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace StarStand
{
    public partial class clientes : UserControl
    {
        starBDContainer bd;
        public clientes()
        {
            InitializeComponent();
        }

        private void btnAddClientes_Click(object sender, EventArgs e)
        {
            acessGerirClientes();
        }

        private void btnEditClientes_Click(object sender, EventArgs e)
        {
            

            int index = dgv_Clientes.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = dgv_Clientes.Rows[index];
            Utilizadores user = (Utilizadores)selectedRow.DataBoundItem;
            acessGerirClientes(user);
        }
        private void btnRemoveClientes_Click(object sender, EventArgs e)
        {
            int index = dgv_Clientes.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = dgv_Clientes.Rows[index];
            Utilizadores user = (Utilizadores)selectedRow.DataBoundItem;
            bd.Entry(user).State = EntityState.Deleted;
            bd.SaveChanges();
            lerdados();
        }



        public void acessGerirClientes(Utilizadores user)
        {
            GerirClientes frm = new GerirClientes(user);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                lerdados();
            }
        }
        public void acessGerirClientes()
        {
            GerirClientes frm = new GerirClientes(null);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                lerdados();
            }
        }
        public void lerdados()
        {
            bd = new starBDContainer();
            (from Utilizadores in bd.UtilizadoresSet select Utilizadores).Load();
            utilizadoresBindingSource.DataSource = bd.UtilizadoresSet.Local.ToBindingList();
        }

       
    }
}
