using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Projekt_Fiedor_Kaczka
{
    public partial class UC_PlaceOrder : UserControl
    {
        Polaczenie p = new Polaczenie();
        string query;
        public UC_PlaceOrder()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string category = comboBox1.Text;
            query = "select Nazwa from produkty where Kategoria='" + category + "'";
            showItemList(query);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string category = comboBox1.Text;
            query = "select Nazwa from produkty where Kategoria='" + category + "' and Nazwa like '"+textBox1.Text+"%'";
            showItemList(query);
        }

        private void showItemList(string query)
        {
            listBox1.Items.Clear();
            DataSet ds = p.getData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pqnt.ResetText();
            ptotal.Clear();

            string text = listBox1.GetItemText(listBox1.SelectedItem);
            pname.Text = text;
            query = "select Cena from produkty where Nazwa = '"+text+"'";
            DataSet ds = p.getData(query);
            try
            {
                pprice.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            catch { }
                
        }

        protected int n, total = 0;
        int amount;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                amount = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
            }
            catch { }
        }
        private void roundButton2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                try
                {
                    dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
                }
                catch { }
                total -= amount;
                ototal.Text = total + " zł";
            }
            else
                MessageBox.Show("Koszyk jest pusty!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        private void roundButton3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                query = "insert into zamowienia (Suma) values ('" + total + "')";
                p.setData(query);
                query = "select Id_zamowienia from zamowienia where Suma=" + total;
                DataSet ds = p.getData(query);
                int zamowienie = (int)ds.Tables[0].Rows[0][0];
                for (int n = 0; n < dataGridView1.RowCount; n++)
                {
                    string query = "insert into zamowienia_produkty (Id_zamowienia,Id_produktu,Ilosc) values ('" + zamowienie + "','" + dataGridView1.Rows[n].Cells[0].Value + "','" + dataGridView1.Rows[n].Cells[3].Value + "')";
                    p.setData(query);
                }
                ptotal.Clear();
                pname.Clear();
                pprice.Clear();
                pqnt.ResetText();
                dataGridView1.Rows.Clear();
                MessageBox.Show("Pomyślnie przetworzono dane", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Koszyk jest pusty!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void pqnt_ValueChanged(object sender, EventArgs e)
        {
            
            try
            {
                Int64 quan = Int64.Parse(pqnt.Value.ToString());
                Int64 price = Int64.Parse(pprice.Text);
                ptotal.Text = (quan * price).ToString();
            }
            catch { }
            
        }

        private void roundButton4_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            ototal.Text = "0 zł";
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

        private void roundButton2_MouseEnter(object sender, EventArgs e)
        {
            roundButton2.BackColor = Color.FromArgb(96, 44, 184);
            roundButton2.ForeColor = Color.White;
        }

        private void roundButton2_MouseLeave(object sender, EventArgs e)
        {
            roundButton2.BackColor = SystemColors.ButtonHighlight;
            roundButton2.ForeColor = Color.FromArgb(96, 44, 184);
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

        private void roundButton3_MouseEnter(object sender, EventArgs e)
        {
            roundButton3.BackColor = Color.FromArgb(96, 44, 184);
            roundButton3.ForeColor = Color.White;
        }

        private void roundButton3_MouseLeave(object sender, EventArgs e)
        {
            roundButton3.BackColor = SystemColors.ButtonHighlight;
            roundButton3.ForeColor = Color.FromArgb(96, 44, 184);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            if (ptotal.Text != "0" && ptotal.Text != "")
            {
                n = dataGridView1.Rows.Add();
                query = "select Id_produktu from produkty where Nazwa='" + pname.Text +"'";
                DataSet ds = p.getData(query);
                dataGridView1.Rows[n].Cells[0].Value = ds.Tables[0].Rows[0][0].ToString(); ;
                dataGridView1.Rows[n].Cells[1].Value = pname.Text;
                dataGridView1.Rows[n].Cells[2].Value = pprice.Text;
                dataGridView1.Rows[n].Cells[3].Value = pqnt.Text;
                dataGridView1.Rows[n].Cells[4].Value = ptotal.Text;
                total += int.Parse(ptotal.Text);
                ototal.Text = total + " zł";
            }
            else if (pname.Text == "")
                MessageBox.Show("Wybierz produkt!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                MessageBox.Show("Minimalna ilość to 1!","Informacja",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
