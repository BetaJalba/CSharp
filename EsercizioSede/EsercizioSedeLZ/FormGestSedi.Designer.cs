namespace EsercizioSedeLZ
{
    partial class FormGestSedi
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
            listBox1 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            button3 = new Button();
            panel2 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(-2, 71);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(611, 244);
            listBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(24, 27);
            button1.Name = "button1";
            button1.Size = new Size(98, 63);
            button1.TabIndex = 1;
            button1.Text = "Aggiungi Sede";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(24, 111);
            button2.Name = "button2";
            button2.Size = new Size(98, 63);
            button2.TabIndex = 2;
            button2.Text = "Elimina Sede";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(29, 66);
            panel1.Name = "panel1";
            panel1.Size = new Size(154, 276);
            panel1.TabIndex = 3;
            // 
            // button3
            // 
            button3.Location = new Point(24, 193);
            button3.Name = "button3";
            button3.Size = new Size(98, 63);
            button3.TabIndex = 3;
            button3.Text = "Cambia Sede";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 255, 192);
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(listBox1);
            panel2.Location = new Point(215, 47);
            panel2.Name = "panel2";
            panel2.Size = new Size(611, 317);
            panel2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(237, 17);
            label1.Name = "label1";
            label1.Size = new Size(142, 41);
            label1.TabIndex = 1;
            label1.Text = "Lista Sedi";
            // 
            // FormGestSedi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 388);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormGestSedi";
            Text = "FormGestSedi";
            Load += FormGestSedi_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button button1;
        private Button button2;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Button button3;
    }
}