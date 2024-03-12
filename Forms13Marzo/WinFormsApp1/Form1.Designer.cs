namespace WinFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            TXT1 = new TextBox();
            LBL1 = new Label();
            BTN1 = new Button();
            LBLES = new Label();
            LBLRIS = new Label();
            LBLERR = new Label();
            LBLES2 = new Label();
            LBL2 = new Label();
            TXT2 = new TextBox();
            LBL3 = new Label();
            TXT3 = new TextBox();
            BTN2 = new Button();
            LBLERR2 = new Label();
            LBLARR = new Label();
            SuspendLayout();
            // 
            // TXT1
            // 
            TXT1.Location = new Point(43, 241);
            TXT1.Name = "TXT1";
            TXT1.Size = new Size(100, 23);
            TXT1.TabIndex = 0;
            // 
            // LBL1
            // 
            LBL1.AutoSize = true;
            LBL1.Location = new Point(39, 223);
            LBL1.Name = "LBL1";
            LBL1.Size = new Size(104, 15);
            LBL1.TabIndex = 1;
            LBL1.Text = "Inserire dividendo:";
            // 
            // BTN1
            // 
            BTN1.Location = new Point(43, 270);
            BTN1.Name = "BTN1";
            BTN1.Size = new Size(75, 23);
            BTN1.TabIndex = 2;
            BTN1.Text = "Calcola";
            BTN1.UseVisualStyleBackColor = true;
            BTN1.Click += BTN1_Click;
            // 
            // LBLES
            // 
            LBLES.AutoSize = true;
            LBLES.Location = new Point(30, 83);
            LBLES.Name = "LBLES";
            LBLES.Size = new Size(316, 105);
            LBLES.TabIndex = 3;
            LBLES.Text = resources.GetString("LBLES.Text");
            // 
            // LBLRIS
            // 
            LBLRIS.AutoSize = true;
            LBLRIS.Location = new Point(30, 321);
            LBLRIS.Name = "LBLRIS";
            LBLRIS.Size = new Size(59, 15);
            LBLRIS.TabIndex = 4;
            LBLRIS.Text = "Risultato: ";
            // 
            // LBLERR
            // 
            LBLERR.AutoSize = true;
            LBLERR.Location = new Point(30, 345);
            LBLERR.Name = "LBLERR";
            LBLERR.Size = new Size(94, 15);
            LBLERR.TabIndex = 5;
            LBLERR.Text = "Errore: nessuno. ";
            // 
            // LBLES2
            // 
            LBLES2.AutoSize = true;
            LBLES2.Location = new Point(437, 83);
            LBLES2.Name = "LBLES2";
            LBLES2.Size = new Size(305, 90);
            LBLES2.TabIndex = 6;
            LBLES2.Text = resources.GetString("LBLES2.Text");
            // 
            // LBL2
            // 
            LBL2.AutoSize = true;
            LBL2.Location = new Point(445, 223);
            LBL2.Name = "LBL2";
            LBL2.Size = new Size(93, 15);
            LBL2.TabIndex = 8;
            LBL2.Text = "Inserire numero:";
            // 
            // TXT2
            // 
            TXT2.Location = new Point(449, 241);
            TXT2.Name = "TXT2";
            TXT2.Size = new Size(100, 23);
            TXT2.TabIndex = 7;
            // 
            // LBL3
            // 
            LBL3.AutoSize = true;
            LBL3.Location = new Point(590, 223);
            LBL3.Name = "LBL3";
            LBL3.Size = new Size(101, 15);
            LBL3.TabIndex = 10;
            LBL3.Text = "Inserire posizione:";
            // 
            // TXT3
            // 
            TXT3.Location = new Point(594, 241);
            TXT3.Name = "TXT3";
            TXT3.Size = new Size(100, 23);
            TXT3.TabIndex = 9;
            // 
            // BTN2
            // 
            BTN2.Location = new Point(449, 270);
            BTN2.Name = "BTN2";
            BTN2.Size = new Size(75, 23);
            BTN2.TabIndex = 11;
            BTN2.Text = "Aggiungi";
            BTN2.UseVisualStyleBackColor = true;
            BTN2.Click += BTN2_Click;
            // 
            // LBLERR2
            // 
            LBLERR2.AutoSize = true;
            LBLERR2.Location = new Point(433, 345);
            LBLERR2.Name = "LBLERR2";
            LBLERR2.Size = new Size(94, 15);
            LBLERR2.TabIndex = 13;
            LBLERR2.Text = "Errore: nessuno. ";
            // 
            // LBLARR
            // 
            LBLARR.AutoSize = true;
            LBLARR.Location = new Point(433, 321);
            LBLARR.Name = "LBLARR";
            LBLARR.Size = new Size(41, 15);
            LBLARR.TabIndex = 12;
            LBLARR.Text = "Array: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LBLERR2);
            Controls.Add(LBLARR);
            Controls.Add(BTN2);
            Controls.Add(LBL3);
            Controls.Add(TXT3);
            Controls.Add(LBL2);
            Controls.Add(TXT2);
            Controls.Add(LBLES2);
            Controls.Add(LBLERR);
            Controls.Add(LBLRIS);
            Controls.Add(LBLES);
            Controls.Add(BTN1);
            Controls.Add(LBL1);
            Controls.Add(TXT1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TXT1;
        private Label LBL1;
        private Button BTN1;
        private Label LBLES;
        private Label LBLRIS;
        private Label LBLERR;
        private Label LBLES2;
        private Label LBL2;
        private TextBox TXT2;
        private Label LBL3;
        private TextBox TXT3;
        private Button BTN2;
        private Label LBLERR2;
        private Label LBLARR;
    }
}
