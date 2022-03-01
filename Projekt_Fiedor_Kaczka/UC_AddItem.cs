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
    public partial class UC_AddItem : UserControl
    {

        public UC_AddItem()
        {
            InitializeComponent();
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text == "" || textBox1.Text == "" || textBox2.Text == "")
                MessageBox.Show("Uzupełnij wszystkie pola!", "Błąd!");

            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=kawiarnia;";
            string query = "insert into produkty (Nazwa,Kategoria,Cena) values ('"+textBox1.Text+"','"+comboBox1.Text+"',"+textBox2.Text+")";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                MessageBox.Show("Pomyślnie dodano produkt!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }
            comboBox1.SelectedIndex = -1;
            textBox1.Clear();
            textBox2.Clear();
        }

        public void clearAll()
        {
            comboBox1.SelectedIndex = -1;
            textBox1.Clear();
            textBox2.Clear();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
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
