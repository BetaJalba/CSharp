namespace EsercizioSedeLZ
{
    partial class FormTrasfer
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
            panel1 = new Panel();
            listBox1 = new ListBox();
            label1 = new Label();
            btnConf = new Button();
            btnCanc = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSeaGreen;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(listBox1);
            panel1.Location = new Point(12, 32);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(663, 265);
            panel1.TabIndex = 3;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(3, 19);
            listBox1.Margin = new Padding(3, 4, 3, 4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(653, 224);
            listBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(273, 8);
            label1.Name = "label1";
            label1.Size = new Size(149, 20);
            label1.TabIndex = 4;
            label1.Text = "Scegliere quale sede:";
            // 
            // btnConf
            // 
            btnConf.Location = new Point(29, 19);
            btnConf.Name = "btnConf";
            btnConf.Size = new Size(116, 67);
            btnConf.TabIndex = 5;
            btnConf.Text = "Conferma";
            btnConf.UseVisualStyleBackColor = true;
            btnConf.Click += btnConf_Click;
            // 
            // btnCanc
            // 
            btnCanc.Location = new Point(191, 19);
            btnCanc.Name = "btnCanc";
            btnCanc.Size = new Size(116, 67);
            btnCanc.TabIndex = 6;
            btnCanc.Text = "Annulla";
            btnCanc.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 255, 192);
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(btnCanc);
            panel2.Controls.Add(btnConf);
            panel2.Location = new Point(179, 311);
            panel2.Name = "panel2";
            panel2.Size = new Size(335, 101);
            panel2.TabIndex = 7;
            // 
            // FormTrasfer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(687, 424);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "FormTrasfer";
            Text = "FormTrasfer";
            Load += FormTrasfer_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private ListBox listBox1;
        private Label label1;
        private Button btnConf;
        private Button btnCanc;
        private Panel panel2;
    }
}