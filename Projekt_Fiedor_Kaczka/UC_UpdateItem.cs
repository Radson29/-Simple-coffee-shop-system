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
    public partial class UC_UpdateItem : UserControl
    {
        Polaczenie p = new Polaczenie();
        string query;

        public UC_UpdateItem()
        {
            InitializeComponent();
        }

        private void UC_UpdateItem_Load(object sender, EventArgs e)
        {
            query = "select * from produkty";
            loadData(query);
                 
        }

        public void loadData(string query)
        {
            DataSet ds = p.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            query = "select * from produkty where Nazwa like '" + textBox1.Text + "%'";
            loadData(query);
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
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
            id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            string category = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            string name = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            int price = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());

            comboBox1.Text = category;
            textBox3.Text = name;
            textBox4.Text = price.ToString();
        }

        private void roundButton4_Click(object sender, EventArgs e)
        {
            query = "update produkty set Nazwa='"+textBox3.Text+"',Kategoria='"+comboBox1.Text+"',Cena="+textBox4.Text+" where Id_produktu="+id+"";
            p.setData(query);
            query = "select * from produkty";
            loadData(query);
            textBox3.Clear();
            comboBox1.SelectedIndex = -1;
            textBox4.Clear();
            MessageBox.Show("Pomyślnie zaktualizowano produkt!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            query = "delete from zamowienia_produkty where Id_produktu=" + id + "";
            p.setData(query);
            query = "delete from produkty where Id_produktu=" + id + "";
            p.setData(query);
            query = "select * from produkty";
            loadData(query);
            MessageBox.Show("Pomyślnie usunięto  produkt!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            query = "select * from produkty";
            loadData(query);
        }

        private void roundButton4_MouseEnter(object sender, EventArgs e)
        {
            roundButton4.BackColor = Color.FromArgb(96, 44, 184);
            roundButton4.ForeColor = Color.White;
        }

        private void roundButton4_MouseLeave(object sender, EventArgs e)
        {
            roundButton4.BackColor = SystemColors.ButtonHighlight;
            roundButton4.ForeColor = Color.FromArgb(96, 44, 184);
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
