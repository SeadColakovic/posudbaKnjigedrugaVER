namespace posudbaKnjige
{
    partial class Pousdba
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
            cmbDatumvracanja = new ComboBox();
            label8 = new Label();
            cmbDatumuzimanja = new ComboBox();
            label7 = new Label();
            txVrsteknjige = new TextBox();
            label6 = new Label();
            label5 = new Label();
            button1 = new Button();
            txBrojknjige = new TextBox();
            label1 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // cmbDatumvracanja
            // 
            cmbDatumvracanja.FormattingEnabled = true;
            cmbDatumvracanja.Location = new Point(337, 196);
            cmbDatumvracanja.Name = "cmbDatumvracanja";
            cmbDatumvracanja.Size = new Size(121, 23);
            cmbDatumvracanja.TabIndex = 22;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(337, 163);
            label8.Name = "label8";
            label8.Size = new Size(90, 15);
            label8.TabIndex = 21;
            label8.Text = "Datum vracanja";
            // 
            // cmbDatumuzimanja
            // 
            cmbDatumuzimanja.FormattingEnabled = true;
            cmbDatumuzimanja.Location = new Point(337, 104);
            cmbDatumuzimanja.Name = "cmbDatumuzimanja";
            cmbDatumuzimanja.Size = new Size(121, 23);
            cmbDatumuzimanja.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(337, 67);
            label7.Name = "label7";
            label7.Size = new Size(94, 15);
            label7.TabIndex = 19;
            label7.Text = "Datum uzimanja";
            // 
            // txVrsteknjige
            // 
            txVrsteknjige.Location = new Point(119, 104);
            txVrsteknjige.Multiline = true;
            txVrsteknjige.Name = "txVrsteknjige";
            txVrsteknjige.Size = new Size(121, 23);
            txVrsteknjige.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(119, 67);
            label6.Name = "label6";
            label6.Size = new Size(68, 15);
            label6.TabIndex = 17;
            label6.Text = "Vrsta knjige";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(276, 112);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 16;
            // 
            // button1
            // 
            button1.Location = new Point(251, 272);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 15;
            button1.Text = "POSUDBA";
            button1.UseVisualStyleBackColor = true;
            // 
            // txBrojknjige
            // 
            txBrojknjige.Location = new Point(119, 196);
            txBrojknjige.Multiline = true;
            txBrojknjige.Name = "txBrojknjige";
            txBrojknjige.Size = new Size(121, 23);
            txBrojknjige.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(119, 163);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 24;
            label1.Text = "Broj knjige";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(236, 21);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 25;
            label2.Text = "POSUDBA KNJIGE";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(555, 21);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(519, 346);
            dataGridView1.TabIndex = 26;
            // 
            // Pousdba
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1123, 504);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txBrojknjige);
            Controls.Add(cmbDatumvracanja);
            Controls.Add(label8);
            Controls.Add(cmbDatumuzimanja);
            Controls.Add(label7);
            Controls.Add(txVrsteknjige);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button1);
            Name = "Pousdba";
            Text = "Pousdba";
            Load += Pousdba_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbDatumvracanja;
        private Label label8;
        private ComboBox cmbDatumuzimanja;
        private Label label7;
        private TextBox txVrsteknjige;
        private Label label6;
        private Label label5;
        private Button button1;
        private TextBox txBrojknjige;
        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
    }
}