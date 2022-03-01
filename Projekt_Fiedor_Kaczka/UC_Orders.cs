using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_Fiedor_Kaczka
{
    public partial class UC_Orders : UserControl
    {
        Polaczenie p = new Polaczenie();
        string query;

        public UC_Orders()
        {
            InitializeComponent();
        }

        public void loadData(string query)
        {
            DataSet ds = p.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void UC_Orders_Load(object sender, EventArgs e)
        {
            query = "select z.Id_zamowienia, p.Nazwa, p.Kategoria, p.Cena, zp.Ilosc, z.Suma from produkty as p inner join zamowienia_produkty as zp on p.Id_produktu=zp.Id_produktu inner join zamowienia as z on zp.Id_zamowienia=z.Id_zamowienia order by Id_zamowienia asc";
            loadData(query);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                query = "select z.Id_zamowienia, p.Nazwa, p.Kategoria, p.Cena, zp.Ilosc, z.Suma from produkty as p inner join zamowienia_produkty as zp on p.Id_produktu=zp.Id_produktu inner join zamowienia as z on zp.Id_zamowienia=z.Id_zamowienia order by Id_zamowienia asc";
            else
                query = "select z.Id_zamowienia, p.Nazwa, p.Kategoria, p.Cena, zp.Ilosc, z.Suma from produkty as p inner join zamowienia_produkty as zp on p.Id_produktu=zp.Id_produktu inner join zamowienia as z on zp.Id_zamowienia=z.Id_zamowienia where z.Id_zamowienia like '" + textBox1.Text + "%' order by Id_zamowienia asc";
            loadData(query);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            query = "select z.Id_zamowienia, p.Nazwa, p.Kategoria, p.Cena, zp.Ilosc, z.Suma from produkty as p inner join zamowienia_produkty as zp on p.Id_produktu=zp.Id_produktu inner join zamowienia as z on zp.Id_zamowienia=z.Id_zamowienia where z.Id_zamowienia like '" + textBox1.Text + "%' order by Id_zamowienia asc";
            loadData(query);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        int id;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try 
            {
                id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            catch (Exception ex)
            { }
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            query = "delete from zamowienia_produkty where Id_zamowienia=" + id + "";
            p.setData(query);
            query = "delete from zamowienia where Id_zamowienia=" + id + "";
            p.setData(query);
            query = "select z.Id_zamowienia, p.Nazwa, p.Kategoria, p.Cena, zp.Ilosc, z.Suma from produkty as p inner join zamowienia_produkty as zp on p.Id_produktu=zp.Id_produktu inner join zamowienia as z on zp.Id_zamowienia=z.Id_zamowienia order by Id_zamowienia";
            loadData(query);
            MessageBox.Show("Pomyślnie usunięto  produkt!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void roundButton1_MouseEnter(object sender, EventArgs e)
        {
            roundButton1.BackColor = Color.FromArgb(96, 44, 184);
            roundButton1.ForeColor = Color.White;
        }

        private void roundButton1_MouseLeave(object sender, EventArgs e)
        {
            roundButton1.BackColor = SystemColors.ButtonHighlight;
            roundButton1.ForeColor = Color.FromArgb(96, 44, 184);
        }
    }
}
