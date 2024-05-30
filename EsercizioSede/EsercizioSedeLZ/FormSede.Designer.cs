namespace EsercizioSedeLZ
{
    partial class FormSede
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
            btnConf = new Button();
            btnCnc = new Button();
            txtName = new TextBox();
            txtAddr = new TextBox();
            txtCit = new TextBox();
            txtReg = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnConf
            // 
            btnConf.Location = new Point(29, 26);
            btnConf.Name = "btnConf";
            btnConf.Size = new Size(94, 51);
            btnConf.TabIndex = 0;
            btnConf.Text = "Conferma";
            btnConf.UseVisualStyleBackColor = true;
            btnConf.Click += btnConf_Click;
            // 
            // btnCnc
            // 
            btnCnc.Location = new Point(166, 26);
            btnCnc.Name = "btnCnc";
            btnCnc.Size = new Size(94, 51);
            btnCnc.TabIndex = 1;
            btnCnc.Text = "Annulla";
            btnCnc.UseVisualStyleBackColor = true;
            btnCnc.Click += btnCnc_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(20, 53);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 2;
            // 
            // txtAddr
            // 
            txtAddr.Location = new Point(20, 130);
            txtAddr.Name = "txtAddr";
            txtAddr.Size = new Size(125, 27);
            txtAddr.TabIndex = 3;
            // 
            // txtCit
            // 
            txtCit.Location = new Point(20, 209);
            txtCit.Name = "txtCit";
            txtCit.Size = new Size(125, 27);
            txtCit.TabIndex = 4;
            // 
            // txtReg
            // 
            txtReg.Location = new Point(20, 290);
            txtReg.Name = "txtReg";
            txtReg.Size = new Size(125, 27);
            txtReg.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 30);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 6;
            label1.Text = "Responsabile:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 107);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 7;
            label2.Text = "Indirizzo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 186);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 8;
            label3.Text = "Citta:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 267);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 9;
            label4.Text = "Regione:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnCnc);
            panel1.Controls.Add(btnConf);
            panel1.Location = new Point(14, 381);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 105);
            panel1.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 255, 192);
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtReg);
            panel2.Controls.Add(txtCit);
            panel2.Controls.Add(txtAddr);
            panel2.Controls.Add(txtName);
            panel2.Location = new Point(76, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(172, 363);
            panel2.TabIndex = 11;
            // 
            // FormSede
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 499);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormSede";
            Text = "FormSede";
            Load += FormSede_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnConf;
        private Button btnCnc;
        private TextBox txtName;
        private TextBox txtAddr;
        private TextBox txtCit;
        private TextBox txtReg;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel1;
        private Panel panel2;
    }
}