namespace Algorytmy_Okienkowe
{
    partial class Wartownik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Wartownik));
            this.labelTytul = new System.Windows.Forms.Label();
            this.labelOpis = new System.Windows.Forms.Label();
            this.labelPseudokod = new System.Windows.Forms.Label();
            this.textBoxLiczby = new System.Windows.Forms.TextBox();
            this.buttonSortuj = new System.Windows.Forms.Button();
            this.labelWynik = new System.Windows.Forms.Label();
            this.labelInstrukcja = new System.Windows.Forms.Label();
            this.labelZalety = new System.Windows.Forms.Label();
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
            this.labelTytul.Text = "SORTOWANIE PRZEZ WSTAWIANIE Z WARTOWNIKIEM";
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
            this.labelOpis.Size = new System.Drawing.Size(740, 40);
            this.labelOpis.TabIndex = 1;
            this.labelOpis.Text = "Sortowanie przez wstawianie z wartownikiem to wersja algorytmu insertion sort, gd" +
    "zie pierwszy element pełni rolę wartownika, eliminując potrzebę sprawdzania waru" +
    "nku wyjścia z pętli.";
            // 
            // labelPseudokod
            // 
            this.labelPseudokod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPseudokod.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPseudokod.ForeColor = System.Drawing.Color.LightGreen;
            this.labelPseudokod.Location = new System.Drawing.Point(30, 290);
            this.labelPseudokod.Name = "labelPseudokod";
            this.labelPseudokod.Size = new System.Drawing.Size(740, 154);
            this.labelPseudokod.TabIndex = 2;
            this.labelPseudokod.Text = resources.GetString("labelPseudokod.Text");
            // 
            // textBoxLiczby
            // 
            this.textBoxLiczby.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLiczby.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxLiczby.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLiczby.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxLiczby.ForeColor = System.Drawing.Color.White;
            this.textBoxLiczby.Location = new System.Drawing.Point(30, 180);
            this.textBoxLiczby.Name = "textBoxLiczby";
            this.textBoxLiczby.Size = new System.Drawing.Size(590, 25);
            this.textBoxLiczby.TabIndex = 3;
            // 
            // buttonSortuj
            // 
            this.buttonSortuj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSortuj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSortuj.FlatAppearance.BorderSize = 0;
            this.buttonSortuj.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.buttonSortuj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.buttonSortuj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSortuj.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSortuj.ForeColor = System.Drawing.Color.White;
            this.buttonSortuj.Location = new System.Drawing.Point(640, 175);
            this.buttonSortuj.Name = "buttonSortuj";
            this.buttonSortuj.Size = new System.Drawing.Size(130, 35);
            this.buttonSortuj.TabIndex = 4;
            this.buttonSortuj.Text = "Sortuj";
            this.buttonSortuj.UseVisualStyleBackColor = false;
            this.buttonSortuj.Click += new System.EventHandler(this.buttonSortuj_Click);
            // 
            // labelWynik
            // 
            this.labelWynik.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWynik.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWynik.ForeColor = System.Drawing.Color.White;
            this.labelWynik.Location = new System.Drawing.Point(30, 230);
            this.labelWynik.Name = "labelWynik";
            this.labelWynik.Size = new System.Drawing.Size(740, 60);
            this.labelWynik.TabIndex = 5;
            // 
            // labelInstrukcja
            // 
            this.labelInstrukcja.AutoSize = true;
            this.labelInstrukcja.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInstrukcja.ForeColor = System.Drawing.Color.White;
            this.labelInstrukcja.Location = new System.Drawing.Point(30, 160);
            this.labelInstrukcja.Name = "labelInstrukcja";
            this.labelInstrukcja.Size = new System.Drawing.Size(332, 17);
            this.labelInstrukcja.TabIndex = 6;
            this.labelInstrukcja.Text = "Wprowadź liczby do posortowania (oddzielone spacją):";
            // 
            // labelZalety
            // 
            this.labelZalety.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelZalety.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelZalety.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.labelZalety.Location = new System.Drawing.Point(30, 130);
            this.labelZalety.Name = "labelZalety";
            this.labelZalety.Size = new System.Drawing.Size(740, 20);
            this.labelZalety.TabIndex = 7;
            this.labelZalety.Text = "Zaleta: Eliminacja jednego porównania w wewnętrznej pętli, co daje niewielką popr" +
    "awę wydajności dla dużych zbiorów danych.";
            // 
            // Wartownik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(800, 464);
            this.Controls.Add(this.labelZalety);
            this.Controls.Add(this.labelInstrukcja);
            this.Controls.Add(this.labelWynik);
            this.Controls.Add(this.buttonSortuj);
            this.Controls.Add(this.textBoxLiczby);
            this.Controls.Add(this.labelPseudokod);
            this.Controls.Add(this.labelOpis);
            this.Controls.Add(this.labelTytul);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "Wartownik";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sortowanie przez wstawianie z wartownikiem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTytul;
        private System.Windows.Forms.Label labelOpis;
        private System.Windows.Forms.Label labelPseudokod;
        private System.Windows.Forms.TextBox textBoxLiczby;
        private System.Windows.Forms.Button buttonSortuj;
        private System.Windows.Forms.Label labelWynik;
        private System.Windows.Forms.Label labelInstrukcja;
        private System.Windows.Forms.Label labelZalety;
    }
}