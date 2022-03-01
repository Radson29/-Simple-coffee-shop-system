namespace Projekt_Fiedor_Kaczka
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.roundButton4 = new Projekt_Fiedor_Kaczka.RoundButton();
            this.roundButton3 = new Projekt_Fiedor_Kaczka.RoundButton();
            this.roundButton2 = new Projekt_Fiedor_Kaczka.RoundButton();
            this.roundButton1 = new Projekt_Fiedor_Kaczka.RoundButton();
            this.rPanel1 = new Projekt_Fiedor_Kaczka.RPanel();
            this.uC_Orders1 = new Projekt_Fiedor_Kaczka.UC_Orders();
            this.uC_UpdateItem1 = new Projekt_Fiedor_Kaczka.UC_UpdateItem();
            this.uC_PlaceOrder1 = new Projekt_Fiedor_Kaczka.UC_PlaceOrder();
            this.uC_AddItem1 = new Projekt_Fiedor_Kaczka.UC_AddItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.rPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.roundButton4);
            this.panel1.Controls.Add(this.roundButton3);
            this.panel1.Controls.Add(this.roundButton2);
            this.panel1.Controls.Add(this.roundButton1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 590);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(79, 513);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(66, 65);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 31);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // roundButton4
            // 
            this.roundButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(44)))), ((int)(((byte)(184)))));
            this.roundButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundButton4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.roundButton4.ForeColor = System.Drawing.Color.White;
            this.roundButton4.Location = new System.Drawing.Point(48, 200);
            this.roundButton4.Name = "roundButton4";
            this.roundButton4.Size = new System.Drawing.Size(202, 51);
            this.roundButton4.TabIndex = 3;
            this.roundButton4.Text = "Zamówienia";
            this.roundButton4.UseVisualStyleBackColor = false;
            this.roundButton4.Click += new System.EventHandler(this.roundButton4_Click);
            // 
            // roundButton3
            // 
            this.roundButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(44)))), ((int)(((byte)(184)))));
            this.roundButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundButton3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.roundButton3.ForeColor = System.Drawing.Color.White;
            this.roundButton3.Location = new System.Drawing.Point(48, 365);
            this.roundButton3.Name = "roundButton3";
            this.roundButton3.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.roundButton3.Size = new System.Drawing.Size(202, 51);
            this.roundButton3.TabIndex = 2;
            this.roundButton3.Text = "Zaktualizuj produkt";
            this.roundButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundButton3.UseVisualStyleBackColor = false;
            this.roundButton3.Click += new System.EventHandler(this.roundButton3_Click);
            // 
            // roundButton2
            // 
            this.roundButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(44)))), ((int)(((byte)(184)))));
            this.roundButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.roundButton2.ForeColor = System.Drawing.Color.White;
            this.roundButton2.Location = new System.Drawing.Point(48, 284);
            this.roundButton2.Name = "roundButton2";
            this.roundButton2.Size = new System.Drawing.Size(202, 51);
            this.roundButton2.TabIndex = 1;
            this.roundButton2.Text = "Dodaj produkt";
            this.roundButton2.UseVisualStyleBackColor = false;
            this.roundButton2.Click += new System.EventHandler(this.roundButton2_Click);
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(44)))), ((int)(((byte)(184)))));
            this.roundButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.roundButton1.ForeColor = System.Drawing.Color.White;
            this.roundButton1.Location = new System.Drawing.Point(48, 117);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(202, 51);
            this.roundButton1.TabIndex = 0;
            this.roundButton1.Text = "Złóż zamówienie";
            this.roundButton1.UseVisualStyleBackColor = false;
            this.roundButton1.Click += new System.EventHandler(this.roundButton1_Click);
            // 
            // rPanel1
            // 
            this.rPanel1.Controls.Add(this.label2);
            this.rPanel1.Controls.Add(this.uC_Orders1);
            this.rPanel1.Controls.Add(this.uC_UpdateItem1);
            this.rPanel1.Controls.Add(this.uC_PlaceOrder1);
            this.rPanel1.Controls.Add(this.uC_AddItem1);
            this.rPanel1.Controls.Add(this.label1);
            this.rPanel1.Controls.Add(this.pictureBox2);
            this.rPanel1.Location = new System.Drawing.Point(236, 0);
            this.rPanel1.Name = "rPanel1";
            this.rPanel1.Size = new System.Drawing.Size(885, 654);
            this.rPanel1.TabIndex = 1;
            this.rPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.rPanel1_Paint);
            // 
            // uC_Orders1
            // 
            this.uC_Orders1.BackColor = System.Drawing.Color.White;
            this.uC_Orders1.Location = new System.Drawing.Point(17, 16);
            this.uC_Orders1.Name = "uC_Orders1";
            this.uC_Orders1.Size = new System.Drawing.Size(836, 587);
            this.uC_Orders1.TabIndex = 5;
            // 
            // uC_UpdateItem1
            // 
            this.uC_UpdateItem1.BackColor = System.Drawing.Color.White;
            this.uC_UpdateItem1.Location = new System.Drawing.Point(17, 16);
            this.uC_UpdateItem1.Name = "uC_UpdateItem1";
            this.uC_UpdateItem1.Size = new System.Drawing.Size(836, 587);
            this.uC_UpdateItem1.TabIndex = 4;
            // 
            // uC_PlaceOrder1
            // 
            this.uC_PlaceOrder1.BackColor = System.Drawing.Color.White;
            this.uC_PlaceOrder1.Location = new System.Drawing.Point(17, 16);
            this.uC_PlaceOrder1.Name = "uC_PlaceOrder1";
            this.uC_PlaceOrder1.Size = new System.Drawing.Size(836, 587);
            this.uC_PlaceOrder1.TabIndex = 3;
            // 
            // uC_AddItem1
            // 
            this.uC_AddItem1.BackColor = System.Drawing.Color.White;
            this.uC_AddItem1.Location = new System.Drawing.Point(17, 16);
            this.uC_AddItem1.Name = "uC_AddItem1";
            this.uC_AddItem1.Size = new System.Drawing.Size(836, 588);
            this.uC_AddItem1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 28.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(152, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(534, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "System zarządzania kawiarnią";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(299, 168);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(241, 335);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(299, 525);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 42);
            this.label2.TabIndex = 6;
            this.label2.Text = "Wykonali:\r\nMichał Fiedor || Radosław Kaczka";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(44)))), ((int)(((byte)(186)))));
            this.ClientSize = new System.Drawing.Size(1101, 614);
            this.Controls.Add(this.rPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.rPanel1.ResumeLayout(false);
            this.rPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private RoundButton roundButton4;
        private RoundButton roundButton3;
        private RoundButton roundButton2;
        private RoundButton roundButton1;
        private PictureBox pictureBox1;
        private RPanel rPanel1;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private UC_AddItem uC_AddItem1;
        private UC_PlaceOrder uC_PlaceOrder1;
        private UC_Orders uC_Orders1;
        private UC_UpdateItem uC_UpdateItem1;
        private Label label2;
    }
}