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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            roundButton1.MouseEnter += OnMouseEnterButton1;
            roundButton1.MouseLeave += OnMouseLeaveButton1;
            roundButton2.MouseEnter += OnMouseEnterButton2;
            roundButton2.MouseLeave += OnMouseLeaveButton2;
            roundButton3.MouseEnter += OnMouseEnterButton3;
            roundButton3.MouseLeave += OnMouseLeaveButton3;
            roundButton4.MouseEnter += OnMouseEnterButton4;
            roundButton4.MouseLeave += OnMouseLeaveButton4;
        }

        private void OnMouseEnterButton1(object sender, EventArgs e)
        {
            roundButton1.BackColor = SystemColors.ButtonHighlight; 
            roundButton1.ForeColor = Color.FromArgb(96, 44, 184);
        }
        private void OnMouseLeaveButton1(object sender, EventArgs e)
        {
            roundButton1.BackColor = Color.FromArgb(96, 44, 184);
            roundButton1.ForeColor = Color.White;
        }
        private void OnMouseEnterButton2(object sender, EventArgs e)
        {
            roundButton2.BackColor = SystemColors.ButtonHighlight;
            roundButton2.ForeColor = Color.FromArgb(96, 44, 184);
        }
        private void OnMouseLeaveButton2(object sender, EventArgs e)
        {
            roundButton2.BackColor = Color.FromArgb(96, 44, 184);
            roundButton2.ForeColor = Color.White;
        }
        private void OnMouseEnterButton3(object sender, EventArgs e)
        {
            roundButton3.BackColor = SystemColors.ButtonHighlight;
            roundButton3.ForeColor = Color.FromArgb(96, 44, 184);
        }
        private void OnMouseLeaveButton3(object sender, EventArgs e)
        {
            roundButton3.BackColor = Color.FromArgb(96, 44, 184);
            roundButton3.ForeColor = Color.White;
        }
        private void OnMouseEnterButton4(object sender, EventArgs e)
        {
            roundButton4.BackColor = SystemColors.ButtonHighlight;
            roundButton4.ForeColor = Color.FromArgb(96, 44, 184);
        }
        private void OnMouseLeaveButton4(object sender, EventArgs e)
        {
            roundButton4.BackColor = Color.FromArgb(96, 44, 184);
            roundButton4.ForeColor = Color.White;
        }
        private void roundButton2_Click(object sender, EventArgs e)
        {
            uC_AddItem1.Visible = true;
            uC_AddItem1.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            const string message = "Czy na pewno chcesz zamknąć aplikacje?";
            const string caption = "Okno zamykania";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            const string message = "Czy na pewno chcesz się wylogować?";
            const string caption = "Okno wylogowania";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Form1 fm = new Form1();
                this.Hide();
                fm.Show();
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            uC_AddItem1.Visible=false;
            uC_PlaceOrder1.Visible = false;
            uC_UpdateItem1.Visible = false;
            uC_Orders1.Visible = false;
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            uC_PlaceOrder1.Visible = true;
            uC_PlaceOrder1.BringToFront();  
        }

        private void roundButton3_Click(object sender, EventArgs e)
        {
            uC_UpdateItem1.Visible = true;
            uC_UpdateItem1.BringToFront();
        }

        private void roundButton4_Click(object sender, EventArgs e)
        {
            uC_Orders1.Visible = true;
            uC_Orders1.BringToFront();
        }
    }
}
