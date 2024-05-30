namespace EsercizioSedeLZ
{
    partial class FormAuto
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
            lblInfo = new Label();
            label1 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button2 = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(45, 26);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(179, 20);
            lblInfo.TabIndex = 0;
            lblInfo.Text = "Informazioni Automobile:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 57);
            label1.Name = "label1";
            label1.Size = new Size(286, 80);
            label1.TabIndex = 1;
            label1.Text = "Il serbatoio ha 104 litri di benzina\r\nLa targa è SE555SO\r\nLa macchina consuma 420 chilometri/litro\r\nIl chilometraggio è 199002 km\r\n";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 224, 192);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblInfo);
            panel1.Location = new Point(306, 103);
            panel1.Name = "panel1";
            panel1.Size = new Size(391, 164);
            panel1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(38, 67);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "Guida";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(29, 25);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 4;
            textBox1.KeyPress += txtDrive_KeyPress;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(30, 29);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 6;
            textBox2.KeyPress += txtDrive_KeyPress;
            // 
            // button2
            // 
            button2.Location = new Point(39, 71);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 5;
            button2.Text = "Rifornisci";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(43, 34);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 125);
            panel2.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 128, 128);
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(button2);
            panel3.Location = new Point(42, 192);
            panel3.Name = "panel3";
            panel3.Size = new Size(201, 126);
            panel3.TabIndex = 8;
            // 
            // FormAuto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(721, 340);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormAuto";
            Text = "FormAuto";
            Load += FormAuto_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblInfo;
        private Label label1;
        private Panel panel1;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button2;
        private Panel panel2;
        private Panel panel3;
    }
}