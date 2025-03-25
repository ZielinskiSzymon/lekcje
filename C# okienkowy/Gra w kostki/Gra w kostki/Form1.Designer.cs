namespace Gra_w_kostki
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.DiceBox1 = new System.Windows.Forms.PictureBox();
            this.rzuc = new System.Windows.Forms.Button();
            this.DiceLabel1 = new System.Windows.Forms.Label();
            this.DiceLabel2 = new System.Windows.Forms.Label();
            this.DiceBox2 = new System.Windows.Forms.PictureBox();
            this.DiceTotal = new System.Windows.Forms.Label();
            this.DiceSum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DiceBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiceBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // DiceBox1
            // 
            this.DiceBox1.Location = new System.Drawing.Point(85, 95);
            this.DiceBox1.Name = "DiceBox1";
            this.DiceBox1.Size = new System.Drawing.Size(114, 54);
            this.DiceBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DiceBox1.TabIndex = 1;
            this.DiceBox1.TabStop = false;
            // 
            // rzuc
            // 
            this.rzuc.Location = new System.Drawing.Point(157, 207);
            this.rzuc.Name = "rzuc";
            this.rzuc.Size = new System.Drawing.Size(114, 54);
            this.rzuc.TabIndex = 3;
            this.rzuc.Text = "button1";
            this.rzuc.UseVisualStyleBackColor = true;
            this.rzuc.Click += new System.EventHandler(this.rzuc_Click);
            // 
            // DiceLabel1
            // 
            this.DiceLabel1.AutoSize = true;
            this.DiceLabel1.Location = new System.Drawing.Point(123, 176);
            this.DiceLabel1.Name = "DiceLabel1";
            this.DiceLabel1.Size = new System.Drawing.Size(35, 13);
            this.DiceLabel1.TabIndex = 4;
            this.DiceLabel1.Text = "label1";
            // 
            // DiceLabel2
            // 
            this.DiceLabel2.AutoSize = true;
            this.DiceLabel2.Location = new System.Drawing.Point(261, 176);
            this.DiceLabel2.Name = "DiceLabel2";
            this.DiceLabel2.Size = new System.Drawing.Size(35, 13);
            this.DiceLabel2.TabIndex = 6;
            this.DiceLabel2.Text = "label2";
            // 
            // DiceBox2
            // 
            this.DiceBox2.Location = new System.Drawing.Point(223, 95);
            this.DiceBox2.Name = "DiceBox2";
            this.DiceBox2.Size = new System.Drawing.Size(114, 54);
            this.DiceBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DiceBox2.TabIndex = 5;
            this.DiceBox2.TabStop = false;
            // 
            // DiceTotal
            // 
            this.DiceTotal.AutoSize = true;
            this.DiceTotal.Location = new System.Drawing.Point(586, 136);
            this.DiceTotal.Name = "DiceTotal";
            this.DiceTotal.Size = new System.Drawing.Size(35, 13);
            this.DiceTotal.TabIndex = 7;
            this.DiceTotal.Text = "label3";
            // 
            // DiceSum
            // 
            this.DiceSum.AutoSize = true;
            this.DiceSum.Location = new System.Drawing.Point(586, 176);
            this.DiceSum.Name = "DiceSum";
            this.DiceSum.Size = new System.Drawing.Size(35, 13);
            this.DiceSum.TabIndex = 8;
            this.DiceSum.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DiceSum);
            this.Controls.Add(this.DiceTotal);
            this.Controls.Add(this.DiceLabel2);
            this.Controls.Add(this.DiceBox2);
            this.Controls.Add(this.DiceLabel1);
            this.Controls.Add(this.rzuc);
            this.Controls.Add(this.DiceBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DiceBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiceBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox DiceBox1;
        private System.Windows.Forms.Button rzuc;
        private System.Windows.Forms.Label DiceLabel1;
        private System.Windows.Forms.Label DiceLabel2;
        private System.Windows.Forms.PictureBox DiceBox2;
        private System.Windows.Forms.Label DiceTotal;
        private System.Windows.Forms.Label DiceSum;
    }
}

