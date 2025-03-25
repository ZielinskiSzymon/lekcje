namespace Suwaczki
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Red = new System.Windows.Forms.TrackBar();
            this.Blue = new System.Windows.Forms.TrackBar();
            this.Green = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.Red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Green)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(11, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(518, 167);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "RGB (0, 0, 0)";
            // 
            // Red
            // 
            this.Red.Location = new System.Drawing.Point(49, 263);
            this.Red.Maximum = 255;
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(427, 45);
            this.Red.TabIndex = 2;
            // 
            // Blue
            // 
            this.Blue.Location = new System.Drawing.Point(49, 365);
            this.Blue.Maximum = 255;
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(427, 45);
            this.Blue.TabIndex = 3;
            // 
            // Green
            // 
            this.Green.Location = new System.Drawing.Point(49, 314);
            this.Green.Maximum = 255;
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(427, 45);
            this.Green.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 444);
            this.Controls.Add(this.Blue);
            this.Controls.Add(this.Green);
            this.Controls.Add(this.Red);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Green)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar Red;
        private System.Windows.Forms.TrackBar Blue;
        private System.Windows.Forms.TrackBar Green;
    }
}

