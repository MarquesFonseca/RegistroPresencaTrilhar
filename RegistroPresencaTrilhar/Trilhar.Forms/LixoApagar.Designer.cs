namespace Trilhar.Forms
{
    partial class LixoApagar
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
            this.TxtMaskedDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxtMaskedDataNascimento
            // 
            this.TxtMaskedDataNascimento.CustomFormat = "";
            this.TxtMaskedDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.TxtMaskedDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TxtMaskedDataNascimento.Location = new System.Drawing.Point(247, 197);
            this.TxtMaskedDataNascimento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtMaskedDataNascimento.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.TxtMaskedDataNascimento.Name = "TxtMaskedDataNascimento";
            this.TxtMaskedDataNascimento.Size = new System.Drawing.Size(307, 57);
            this.TxtMaskedDataNascimento.TabIndex = 17;
            this.TxtMaskedDataNascimento.Value = new System.DateTime(2023, 2, 24, 0, 0, 0, 0);
            // 
            // TxtEmail
            // 
            this.TxtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.Location = new System.Drawing.Point(247, 102);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.ReadOnly = true;
            this.TxtEmail.Size = new System.Drawing.Size(330, 53);
            this.TxtEmail.TabIndex = 18;
            // 
            // LixoApagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtMaskedDataNascimento);
            this.Name = "LixoApagar";
            this.Text = "LixoApagar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker TxtMaskedDataNascimento;
        private System.Windows.Forms.TextBox TxtEmail;
    }
}