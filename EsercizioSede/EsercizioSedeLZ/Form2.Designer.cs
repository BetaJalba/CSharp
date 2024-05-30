namespace EsercizioSedeLZ
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
            txtName.Location = new Point(35, 33);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(114, 27);
            txtName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 9);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 1;
            label1.Text = "Targa";
            label1.Click += label1_Click;
            // 
            // lblPrz
            // 
            lblPrz.AutoSize = true;
            lblPrz.Location = new Point(35, 84);
            lblPrz.Name = "lblPrz";
            lblPrz.Size = new Size(108, 20);
            lblPrz.TabIndex = 5;
            lblPrz.Text = "Consumo km/L";
            // 
            // txtPrz
            // 
            txtPrz.Location = new Point(35, 108);
            txtPrz.Margin = new Padding(3, 4, 3, 4);
            txtPrz.Name = "txtPrz";
            txtPrz.Size = new Size(114, 27);
            txtPrz.TabIndex = 4;
            txtPrz.KeyPress += txtPrz_KeyPress;
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Location = new Point(35, 168);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(74, 20);
            lblYear.TabIndex = 7;
            lblYear.Text = "Serbatoio";
            // 
            // txtYear
            // 
            txtYear.Location = new Point(35, 192);
            txtYear.Margin = new Padding(3, 4, 3, 4);
            txtYear.MaxLength = 4;
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(114, 27);
            txtYear.TabIndex = 6;
            txtYear.KeyDown += txtYear_KeyUp;
            txtYear.KeyPress += txtYear_KeyPress;
            txtYear.KeyUp += txtYear_KeyUp;
            // 
            // bntConf
            // 
            bntConf.Location = new Point(29, 15);
            bntConf.Margin = new Padding(3, 4, 3, 4);
            bntConf.Name = "bntConf";
            bntConf.Size = new Size(86, 40);
            bntConf.TabIndex = 8;
            bntConf.Text = "Conferma";
            bntConf.UseVisualStyleBackColor = true;
            bntConf.Click += bntConf_Click;
            // 
            // btnExt
            // 
            btnExt.Location = new Point(157, 15);
            btnExt.Margin = new Padding(3, 4, 3, 4);
            btnExt.Name = "btnExt";
            btnExt.Size = new Size(86, 40);
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
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtName);
            panel1.Location = new Point(85, 16);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(189, 251);
            panel1.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(btnExt);
            panel2.Controls.Add(bntConf);
            panel2.Location = new Point(42, 280);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(274, 67);
            panel2.TabIndex = 11;
            panel2.Paint += panel2_Paint;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(362, 359);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtName;
        private Label label1;
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