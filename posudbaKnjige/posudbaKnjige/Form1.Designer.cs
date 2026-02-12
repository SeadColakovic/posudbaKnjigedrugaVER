namespace posudbaKnjige
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txIme = new TextBox();
            label2 = new Label();
            txPrezime = new TextBox();
            label3 = new Label();
            txEmail = new TextBox();
            label4 = new Label();
            txOIB = new TextBox();
            label5 = new Label();
            txBrojtelefona = new TextBox();
            label6 = new Label();
            txAdresa = new TextBox();
            label7 = new Label();
            btnSpremi = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(225, 9);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "KORISNIK";
            label1.Click += label1_Click;
            // 
            // txIme
            // 
            txIme.Location = new Point(92, 80);
            txIme.Multiline = true;
            txIme.Name = "txIme";
            txIme.Size = new Size(100, 23);
            txIme.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 80);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 2;
            label2.Text = "Ime";
            // 
            // txPrezime
            // 
            txPrezime.Location = new Point(92, 133);
            txPrezime.Multiline = true;
            txPrezime.Name = "txPrezime";
            txPrezime.Size = new Size(100, 23);
            txPrezime.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 133);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 4;
            label3.Text = "Prezime";
            // 
            // txEmail
            // 
            txEmail.Location = new Point(92, 192);
            txEmail.Multiline = true;
            txEmail.Name = "txEmail";
            txEmail.Size = new Size(100, 26);
            txEmail.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 192);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 7;
            label4.Text = "Email";
            // 
            // txOIB
            // 
            txOIB.Location = new Point(318, 80);
            txOIB.Multiline = true;
            txOIB.Name = "txOIB";
            txOIB.Size = new Size(100, 23);
            txOIB.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(285, 80);
            label5.Name = "label5";
            label5.Size = new Size(26, 15);
            label5.TabIndex = 9;
            label5.Text = "OIB";
            // 
            // txBrojtelefona
            // 
            txBrojtelefona.Location = new Point(318, 133);
            txBrojtelefona.Multiline = true;
            txBrojtelefona.Name = "txBrojtelefona";
            txBrojtelefona.Size = new Size(100, 23);
            txBrojtelefona.TabIndex = 10;
            txBrojtelefona.TextChanged += textBox5_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(237, 133);
            label6.Name = "label6";
            label6.Size = new Size(71, 15);
            label6.TabIndex = 11;
            label6.Text = "Brojtelefona";
            // 
            // txAdresa
            // 
            txAdresa.Location = new Point(318, 189);
            txAdresa.Multiline = true;
            txAdresa.Name = "txAdresa";
            txAdresa.Size = new Size(100, 26);
            txAdresa.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(268, 189);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 13;
            label7.Text = "Adresa";
            // 
            // btnSpremi
            // 
            btnSpremi.Location = new Point(216, 258);
            btnSpremi.Name = "btnSpremi";
            btnSpremi.Size = new Size(75, 23);
            btnSpremi.TabIndex = 14;
            btnSpremi.Text = "SPREMI";
            btnSpremi.UseVisualStyleBackColor = true;
            btnSpremi.Click += btnSpremi_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 312);
            Controls.Add(btnSpremi);
            Controls.Add(label7);
            Controls.Add(txAdresa);
            Controls.Add(label6);
            Controls.Add(txBrojtelefona);
            Controls.Add(label5);
            Controls.Add(txOIB);
            Controls.Add(label4);
            Controls.Add(txEmail);
            Controls.Add(label3);
            Controls.Add(txPrezime);
            Controls.Add(label2);
            Controls.Add(txIme);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Unos korisnika";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txIme;
        private Label label2;
        private TextBox txPrezime;
        private Label label3;
        private TextBox txEmail;
        private Label label4;
        private TextBox txOIB;
        private Label label5;
        private TextBox txBrojtelefona;
        private Label label6;
        private TextBox txAdresa;
        private Label label7;
        private Button btnSpremi;
    }
}
