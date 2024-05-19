namespace FormsOrchestra
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
            listBox1 = new ListBox();
            btnAdd = new Button();
            btnDel = new Button();
            btnSrt = new Button();
            panel1 = new Panel();
            btnOrcstr = new Button();
            dateTimePicker1 = new DateTimePicker();
            lblDate = new Label();
            panel2 = new Panel();
            btnMedia = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(67, 151);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(481, 94);
            listBox1.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(208, 23);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 47);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Aggiungi Strumento";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(208, 86);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(75, 47);
            btnDel.TabIndex = 2;
            btnDel.Text = "Elimina Selezionato";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // btnSrt
            // 
            btnSrt.Location = new Point(344, 23);
            btnSrt.Name = "btnSrt";
            btnSrt.Size = new Size(75, 47);
            btnSrt.TabIndex = 3;
            btnSrt.Text = "Ordina";
            btnSrt.UseVisualStyleBackColor = true;
            btnSrt.Click += btnSrt_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 255, 192);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnMedia);
            panel1.Controls.Add(btnSrt);
            panel1.Controls.Add(btnDel);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(listBox1);
            panel1.Location = new Point(58, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(601, 263);
            panel1.TabIndex = 4;
            panel1.Visible = false;
            // 
            // btnOrcstr
            // 
            btnOrcstr.Location = new Point(118, 107);
            btnOrcstr.Name = "btnOrcstr";
            btnOrcstr.Size = new Size(82, 50);
            btnOrcstr.TabIndex = 5;
            btnOrcstr.Text = "Crea Orchestra";
            btnOrcstr.UseVisualStyleBackColor = true;
            btnOrcstr.Click += btnOrcstr_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(56, 61);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 6;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(44, 34);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(224, 15);
            lblDate.TabIndex = 7;
            lblDate.Text = "Inserire data ultimo concerto (opzionale):";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientActiveCaption;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(lblDate);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(btnOrcstr);
            panel2.Location = new Point(104, 47);
            panel2.Name = "panel2";
            panel2.Size = new Size(328, 188);
            panel2.TabIndex = 8;
            // 
            // btnMedia
            // 
            btnMedia.Location = new Point(331, 86);
            btnMedia.Name = "btnMedia";
            btnMedia.Size = new Size(105, 47);
            btnMedia.TabIndex = 4;
            btnMedia.Text = "Stampa Costo Medio";
            btnMedia.UseVisualStyleBackColor = true;
            btnMedia.Click += btnMedia_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 306);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button btnAdd;
        private Button btnDel;
        private Button btnSrt;
        private Panel panel1;
        private Button btnOrcstr;
        private DateTimePicker dateTimePicker1;
        private Label lblDate;
        private Panel panel2;
        private Button btnMedia;
    }
}
