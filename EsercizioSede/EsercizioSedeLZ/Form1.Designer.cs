namespace EsercizioSedeLZ
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
            pnlComandi = new Panel();
            btnCar = new Button();
            button3 = new Button();
            btnOrdn = new Button();
            btnCanc = new Button();
            btnAuto = new Button();
            btnSede = new Button();
            pnlJson = new Panel();
            btnSave = new Button();
            panel1 = new Panel();
            listBox1 = new ListBox();
            lblInfo = new Label();
            panel2 = new Panel();
            pnlComandi.SuspendLayout();
            pnlJson.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pnlComandi
            // 
            pnlComandi.BackColor = SystemColors.GradientActiveCaption;
            pnlComandi.BorderStyle = BorderStyle.Fixed3D;
            pnlComandi.Controls.Add(btnCar);
            pnlComandi.Controls.Add(button3);
            pnlComandi.Controls.Add(btnOrdn);
            pnlComandi.Controls.Add(btnCanc);
            pnlComandi.Controls.Add(btnAuto);
            pnlComandi.Controls.Add(btnSede);
            pnlComandi.Location = new Point(17, 108);
            pnlComandi.Margin = new Padding(3, 4, 3, 4);
            pnlComandi.Name = "pnlComandi";
            pnlComandi.Size = new Size(334, 319);
            pnlComandi.TabIndex = 0;
            // 
            // btnCar
            // 
            btnCar.Location = new Point(96, 82);
            btnCar.Margin = new Padding(3, 4, 3, 4);
            btnCar.Name = "btnCar";
            btnCar.Size = new Size(144, 43);
            btnCar.TabIndex = 5;
            btnCar.Text = "Gestione Auto";
            btnCar.UseVisualStyleBackColor = true;
            btnCar.Click += btnCar_Click;
            // 
            // button3
            // 
            button3.Location = new Point(173, 222);
            button3.Name = "button3";
            button3.Size = new Size(144, 59);
            button3.TabIndex = 4;
            button3.Text = "Trasferisci Auto";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btnOrdn
            // 
            btnOrdn.Location = new Point(173, 154);
            btnOrdn.Margin = new Padding(3, 4, 3, 4);
            btnOrdn.Name = "btnOrdn";
            btnOrdn.Size = new Size(144, 60);
            btnOrdn.TabIndex = 3;
            btnOrdn.Text = "Ordina Parco Automobili";
            btnOrdn.UseVisualStyleBackColor = true;
            btnOrdn.Click += btnOrdn_Click;
            // 
            // btnCanc
            // 
            btnCanc.Location = new Point(19, 222);
            btnCanc.Margin = new Padding(3, 4, 3, 4);
            btnCanc.Name = "btnCanc";
            btnCanc.Size = new Size(144, 59);
            btnCanc.TabIndex = 2;
            btnCanc.Text = "Elimina Automobile";
            btnCanc.UseVisualStyleBackColor = true;
            btnCanc.Click += btnCanc_Click;
            // 
            // btnAuto
            // 
            btnAuto.Location = new Point(19, 154);
            btnAuto.Margin = new Padding(3, 4, 3, 4);
            btnAuto.Name = "btnAuto";
            btnAuto.Size = new Size(144, 60);
            btnAuto.TabIndex = 1;
            btnAuto.Text = "Aggiungi Automobile";
            btnAuto.UseVisualStyleBackColor = true;
            btnAuto.Click += btnAuto_Click;
            // 
            // btnSede
            // 
            btnSede.Location = new Point(96, 31);
            btnSede.Margin = new Padding(3, 4, 3, 4);
            btnSede.Name = "btnSede";
            btnSede.Size = new Size(144, 43);
            btnSede.TabIndex = 0;
            btnSede.Text = "Gestione Sedi";
            btnSede.UseVisualStyleBackColor = true;
            btnSede.Click += btnSede_Click;
            // 
            // pnlJson
            // 
            pnlJson.BackColor = Color.FromArgb(255, 255, 192);
            pnlJson.BorderStyle = BorderStyle.Fixed3D;
            pnlJson.Controls.Add(btnSave);
            pnlJson.Location = new Point(376, 24);
            pnlJson.Margin = new Padding(3, 4, 3, 4);
            pnlJson.Name = "pnlJson";
            pnlJson.Size = new Size(410, 119);
            pnlJson.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(100, 20);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(215, 77);
            btnSave.TabIndex = 0;
            btnSave.Text = "Salva su JSON";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSeaGreen;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(listBox1);
            panel1.Location = new Point(376, 161);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(410, 265);
            panel1.TabIndex = 2;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(3, 19);
            listBox1.Margin = new Padding(3, 4, 3, 4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(400, 224);
            listBox1.TabIndex = 0;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Font = new Font("Cambria", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInfo.ForeColor = SystemColors.ControlLightLight;
            lblInfo.Location = new Point(86, 20);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(173, 30);
            lblInfo.TabIndex = 4;
            lblInfo.Text = "Sede ID: ####";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 128, 128);
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(lblInfo);
            panel2.Location = new Point(17, 24);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(334, 71);
            panel2.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pnlJson);
            Controls.Add(pnlComandi);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            pnlComandi.ResumeLayout(false);
            pnlJson.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlComandi;
        private Button btnSede;
        private Panel pnlJson;
        private Panel panel1;
        private Button btnAuto;
        private Label lblInfo;
        private Button btnOrdn;
        private Button btnCanc;
        private Panel panel2;
        private ListBox listBox1;
        private Button button3;
        private Button btnSave;
        private Button btnCar;
    }
}
