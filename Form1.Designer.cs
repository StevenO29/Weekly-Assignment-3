namespace Take_Home_Assignment_Week_3
{
    partial class FormPengaturanWarna
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
            this.LblInput = new System.Windows.Forms.Label();
            this.TxtBoxInput = new System.Windows.Forms.TextBox();
            this.BtnProses = new System.Windows.Forms.Button();
            this.LblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblInput
            // 
            this.LblInput.AutoSize = true;
            this.LblInput.Location = new System.Drawing.Point(12, 9);
            this.LblInput.Name = "LblInput";
            this.LblInput.Size = new System.Drawing.Size(105, 25);
            this.LblInput.TabIndex = 0;
            this.LblInput.Text = "Input Data :";
            // 
            // TxtBoxInput
            // 
            this.TxtBoxInput.Location = new System.Drawing.Point(12, 37);
            this.TxtBoxInput.Multiline = true;
            this.TxtBoxInput.Name = "TxtBoxInput";
            this.TxtBoxInput.Size = new System.Drawing.Size(496, 35);
            this.TxtBoxInput.TabIndex = 1;
            this.TxtBoxInput.TabStop = false;
            // 
            // BtnProses
            // 
            this.BtnProses.Location = new System.Drawing.Point(12, 105);
            this.BtnProses.Name = "BtnProses";
            this.BtnProses.Size = new System.Drawing.Size(115, 40);
            this.BtnProses.TabIndex = 2;
            this.BtnProses.Text = "Proses";
            this.BtnProses.UseVisualStyleBackColor = true;
            this.BtnProses.Click += new System.EventHandler(this.BtnProses_Click);
            // 
            // LblOutput
            // 
            this.LblOutput.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblOutput.Location = new System.Drawing.Point(12, 175);
            this.LblOutput.Name = "LblOutput";
            this.LblOutput.Size = new System.Drawing.Size(486, 100);
            this.LblOutput.TabIndex = 3;
            this.LblOutput.Text = "[EMPTY]";
            // 
            // FormPengaturanWarna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(528, 291);
            this.Controls.Add(this.LblOutput);
            this.Controls.Add(this.BtnProses);
            this.Controls.Add(this.TxtBoxInput);
            this.Controls.Add(this.LblInput);
            this.Name = "FormPengaturanWarna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Pengaturan Warna";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormPengaturanWarna_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblInput;
        private System.Windows.Forms.TextBox TxtBoxInput;
        private System.Windows.Forms.Button BtnProses;
        private System.Windows.Forms.Label LblOutput;
    }
}
