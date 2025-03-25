namespace Generator_haseł
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
            this.lblLenght = new System.Windows.Forms.Label();
            this.trackBarLength = new System.Windows.Forms.TrackBar();
            this.chkLowerCase = new System.Windows.Forms.CheckBox();
            this.chkUpperCase = new System.Windows.Forms.CheckBox();
            this.chkNumbers = new System.Windows.Forms.CheckBox();
            this.chkSpecialChars = new System.Windows.Forms.CheckBox();
            this.btngeneratePassword = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLength)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLenght
            // 
            this.lblLenght.AutoSize = true;
            this.lblLenght.Location = new System.Drawing.Point(28, 22);
            this.lblLenght.Name = "lblLenght";
            this.lblLenght.Size = new System.Drawing.Size(0, 13);
            this.lblLenght.TabIndex = 0;
            // 
            // trackBarLength
            // 
            this.trackBarLength.Location = new System.Drawing.Point(1, 52);
            this.trackBarLength.Maximum = 16;
            this.trackBarLength.Minimum = 6;
            this.trackBarLength.Name = "trackBarLength";
            this.trackBarLength.Size = new System.Drawing.Size(196, 45);
            this.trackBarLength.TabIndex = 2;
            this.trackBarLength.Value = 6;
            this.trackBarLength.Scroll += new System.EventHandler(this.trackBarLength_Scroll);
            // 
            // chkLowerCase
            // 
            this.chkLowerCase.AutoSize = true;
            this.chkLowerCase.Checked = true;
            this.chkLowerCase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLowerCase.Location = new System.Drawing.Point(12, 103);
            this.chkLowerCase.Name = "chkLowerCase";
            this.chkLowerCase.Size = new System.Drawing.Size(75, 17);
            this.chkLowerCase.TabIndex = 3;
            this.chkLowerCase.Text = "Małe litery";
            this.chkLowerCase.UseVisualStyleBackColor = true;
            // 
            // chkUpperCase
            // 
            this.chkUpperCase.AutoSize = true;
            this.chkUpperCase.Checked = true;
            this.chkUpperCase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUpperCase.Location = new System.Drawing.Point(12, 126);
            this.chkUpperCase.Name = "chkUpperCase";
            this.chkUpperCase.Size = new System.Drawing.Size(75, 17);
            this.chkUpperCase.TabIndex = 4;
            this.chkUpperCase.Text = "Duże litery";
            this.chkUpperCase.UseVisualStyleBackColor = true;
            // 
            // chkNumbers
            // 
            this.chkNumbers.AutoSize = true;
            this.chkNumbers.Location = new System.Drawing.Point(12, 149);
            this.chkNumbers.Name = "chkNumbers";
            this.chkNumbers.Size = new System.Drawing.Size(49, 17);
            this.chkNumbers.TabIndex = 6;
            this.chkNumbers.Text = "Cyfry";
            this.chkNumbers.UseVisualStyleBackColor = true;
            // 
            // chkSpecialChars
            // 
            this.chkSpecialChars.AutoSize = true;
            this.chkSpecialChars.Location = new System.Drawing.Point(12, 172);
            this.chkSpecialChars.Name = "chkSpecialChars";
            this.chkSpecialChars.Size = new System.Drawing.Size(101, 17);
            this.chkSpecialChars.TabIndex = 5;
            this.chkSpecialChars.Text = "Znaki specjalne";
            this.chkSpecialChars.UseVisualStyleBackColor = true;
            // 
            // btngeneratePassword
            // 
            this.btngeneratePassword.Location = new System.Drawing.Point(203, 52);
            this.btngeneratePassword.Name = "btngeneratePassword";
            this.btngeneratePassword.Size = new System.Drawing.Size(120, 37);
            this.btngeneratePassword.TabIndex = 7;
            this.btngeneratePassword.Text = "Generuj hasło";
            this.btngeneratePassword.UseVisualStyleBackColor = true;
            this.btngeneratePassword.Click += new System.EventHandler(this.btngeneratePassword_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(12, 195);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(185, 20);
            this.txtPassword.TabIndex = 8;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(203, 95);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(120, 37);
            this.btnCopy.TabIndex = 9;
            this.btnCopy.Text = "Zapisz do schowka";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(203, 138);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 37);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Zapisz do pliku";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btngeneratePassword);
            this.Controls.Add(this.chkNumbers);
            this.Controls.Add(this.chkSpecialChars);
            this.Controls.Add(this.chkUpperCase);
            this.Controls.Add(this.chkLowerCase);
            this.Controls.Add(this.trackBarLength);
            this.Controls.Add(this.lblLenght);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLenght;
        private System.Windows.Forms.TrackBar trackBarLength;
        private System.Windows.Forms.CheckBox chkLowerCase;
        private System.Windows.Forms.CheckBox chkUpperCase;
        private System.Windows.Forms.CheckBox chkNumbers;
        private System.Windows.Forms.CheckBox chkSpecialChars;
        private System.Windows.Forms.Button btngeneratePassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnSave;
    }
}

