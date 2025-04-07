namespace Algorytmy_Okienkowe
{
    partial class Pierwsze
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pierwsze));
            this.labelTytul = new System.Windows.Forms.Label();
            this.labelOpis = new System.Windows.Forms.Label();
            this.labelPseudokod = new System.Windows.Forms.Label();
            this.textBoxOd = new System.Windows.Forms.TextBox();
            this.textBoxDo = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelZakres = new System.Windows.Forms.Label();
            this.labelWynik = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTytul
            // 
            this.labelTytul.BackColor = System.Drawing.Color.Transparent;
            this.labelTytul.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTytul.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTytul.ForeColor = System.Drawing.Color.White;
            this.labelTytul.Location = new System.Drawing.Point(0, 0);
            this.labelTytul.Name = "labelTytul";
            this.labelTytul.Size = new System.Drawing.Size(800, 80);
            this.labelTytul.TabIndex = 0;
            this.labelTytul.Text = "ALGORYTM NA LICZBY PIERWSZE";
            this.labelTytul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelOpis
            // 
            this.labelOpis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelOpis.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOpis.ForeColor = System.Drawing.Color.White;
            this.labelOpis.Location = new System.Drawing.Point(30, 90);
            this.labelOpis.Name = "labelOpis";
            this.labelOpis.Size = new System.Drawing.Size(740, 60);
            this.labelOpis.TabIndex = 1;
            this.labelOpis.Text = resources.GetString("labelOpis.Text");
            // 
            // labelPseudokod
            // 
            this.labelPseudokod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPseudokod.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPseudokod.ForeColor = System.Drawing.Color.LightGreen;
            this.labelPseudokod.Location = new System.Drawing.Point(30, 300);
            this.labelPseudokod.Name = "labelPseudokod";
            this.labelPseudokod.Size = new System.Drawing.Size(740, 120);
            this.labelPseudokod.TabIndex = 2;
            this.labelPseudokod.Text = "function isPrime(n):\r\n    if n <= 1:\r\n        return false\r\n    for i from 2 to √" +
    "n:\r\n        if n % i == 0:\r\n            return false\r\n    return true";
            // 
            // textBoxOd
            // 
            this.textBoxOd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxOd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxOd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxOd.ForeColor = System.Drawing.Color.White;
            this.textBoxOd.Location = new System.Drawing.Point(120, 170);
            this.textBoxOd.Name = "textBoxOd";
            this.textBoxOd.Size = new System.Drawing.Size(100, 25);
            this.textBoxOd.TabIndex = 3;
            this.textBoxOd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxDo
            // 
            this.textBoxDo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxDo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxDo.ForeColor = System.Drawing.Color.White;
            this.textBoxDo.Location = new System.Drawing.Point(260, 170);
            this.textBoxDo.Name = "textBoxDo";
            this.textBoxDo.Size = new System.Drawing.Size(100, 25);
            this.textBoxDo.TabIndex = 4;
            this.textBoxDo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonStart.FlatAppearance.BorderSize = 0;
            this.buttonStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.buttonStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonStart.ForeColor = System.Drawing.Color.White;
            this.buttonStart.Location = new System.Drawing.Point(400, 165);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(120, 35);
            this.buttonStart.TabIndex = 5;
            this.buttonStart.Text = "Znajdź";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelZakres
            // 
            this.labelZakres.AutoSize = true;
            this.labelZakres.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelZakres.ForeColor = System.Drawing.Color.White;
            this.labelZakres.Location = new System.Drawing.Point(30, 173);
            this.labelZakres.Name = "labelZakres";
            this.labelZakres.Size = new System.Drawing.Size(90, 17);
            this.labelZakres.TabIndex = 6;
            this.labelZakres.Text = "Zakres od-do:";
            // 
            // labelWynik
            // 
            this.labelWynik.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWynik.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWynik.ForeColor = System.Drawing.Color.White;
            this.labelWynik.Location = new System.Drawing.Point(30, 220);
            this.labelWynik.Name = "labelWynik";
            this.labelWynik.Size = new System.Drawing.Size(740, 70);
            this.labelWynik.TabIndex = 7;
            // 
            // Pierwsze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelWynik);
            this.Controls.Add(this.labelZakres);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textBoxDo);
            this.Controls.Add(this.textBoxOd);
            this.Controls.Add(this.labelPseudokod);
            this.Controls.Add(this.labelOpis);
            this.Controls.Add(this.labelTytul);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "Pierwsze";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Algorytm na liczby pierwsze";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTytul;
        private System.Windows.Forms.Label labelOpis;
        private System.Windows.Forms.Label labelPseudokod;
        private System.Windows.Forms.TextBox textBoxOd;
        private System.Windows.Forms.TextBox textBoxDo;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelZakres;
        private System.Windows.Forms.Label labelWynik;
    }
}