namespace FormsOrchestra
{
    partial class Form2
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
            txtName = new TextBox();
            label1 = new Label();
            ctrlTipo = new ComboBox();
            lblTpg = new Label();
            lblPrz = new Label();
            txtPrz = new TextBox();
            lblYear = new Label();
            txtYear = new TextBox();
            bntConf = new Button();
            btnExt = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(31, 25);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 7);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 1;
            label1.Text = "Nome";
            label1.Click += label1_Click;
            // 
            // ctrlTipo
            // 
            ctrlTipo.FormattingEnabled = true;
            ctrlTipo.Items.AddRange(new object[] { "Fiato", "Percussioni", "Corda" });
            ctrlTipo.Location = new Point(31, 91);
            ctrlTipo.Name = "ctrlTipo";
            ctrlTipo.Size = new Size(100, 23);
            ctrlTipo.TabIndex = 2;
            ctrlTipo.Text = "Seleziona";
            ctrlTipo.KeyPress += ctrlTipo_KeyPress;
            // 
            // lblTpg
            // 
            lblTpg.AutoSize = true;
            lblTpg.Location = new Point(31, 73);
            lblTpg.Name = "lblTpg";
            lblTpg.Size = new Size(56, 15);
            lblTpg.TabIndex = 3;
            lblTpg.Text = "Tipologia";
            // 
            // lblPrz
            // 
            lblPrz.AutoSize = true;
            lblPrz.Location = new Point(31, 136);
            lblPrz.Name = "lblPrz";
            lblPrz.Size = new Size(38, 15);
            lblPrz.TabIndex = 5;
            lblPrz.Text = "Costo";
            // 
            // txtPrz
            // 
            txtPrz.Location = new Point(31, 154);
            txtPrz.Name = "txtPrz";
            txtPrz.Size = new Size(100, 23);
            txtPrz.TabIndex = 4;
            txtPrz.KeyPress += txtPrz_KeyPress;
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Location = new Point(31, 199);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(105, 15);
            lblYear.TabIndex = 7;
            lblYear.Text = "Anno Manufattura";
            // 
            // txtYear
            // 
            txtYear.Location = new Point(31, 217);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(100, 23);
            txtYear.TabIndex = 6;
            txtYear.KeyPress += txtYear_KeyPress;
            // 
            // bntConf
            // 
            bntConf.Location = new Point(25, 11);
            bntConf.Name = "bntConf";
            bntConf.Size = new Size(75, 30);
            bntConf.TabIndex = 8;
            bntConf.Text = "Conferma";
            bntConf.UseVisualStyleBackColor = true;
            bntConf.Click += bntConf_Click;
            // 
            // btnExt
            // 
            btnExt.Location = new Point(137, 11);
            btnExt.Name = "btnExt";
            btnExt.Size = new Size(75, 30);
            btnExt.TabIndex = 9;
            btnExt.Text = "Annulla";
            btnExt.UseVisualStyleBackColor = true;
            btnExt.Click += btnExt_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 255, 192);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(lblYear);
            panel1.Controls.Add(txtYear);
            panel1.Controls.Add(lblPrz);
            panel1.Controls.Add(txtPrz);
            panel1.Controls.Add(lblTpg);
            panel1.Controls.Add(ctrlTipo);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtName);
            panel1.Location = new Point(74, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(166, 253);
            panel1.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(btnExt);
            panel2.Controls.Add(bntConf);
            panel2.Location = new Point(37, 285);
            panel2.Name = "panel2";
            panel2.Size = new Size(240, 51);
            panel2.TabIndex = 11;
            panel2.Paint += panel2_Paint;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(317, 355);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form2";
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtName;
        private Label label1;
        private ComboBox ctrlTipo;
        private Label lblTpg;
        private Label lblPrz;
        private TextBox txtPrz;
        private Label lblYear;
        private TextBox txtYear;
        private Button bntConf;
        private Button btnExt;
        private Panel panel1;
        private Panel panel2;
    }
}