namespace TurProgramlama
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lblYardım = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblYardım
            // 
            this.lblYardım.AutoSize = true;
            this.lblYardım.Location = new System.Drawing.Point(12, 24);
            this.lblYardım.Name = "lblYardım";
            this.lblYardım.Size = new System.Drawing.Size(485, 117);
            this.lblYardım.TabIndex = 0;
            this.lblYardım.Text = resources.GetString("lblYardım.Text");
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 166);
            this.Controls.Add(this.lblYardım);
            this.Name = "Form2";
            this.Text = "Yardım";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblYardım;
    }
}