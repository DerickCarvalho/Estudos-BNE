namespace interfaceGrafica
{
    partial class AdmPage
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.labelName = new System.Windows.Forms.Label();
            this.admName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(12, 413);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(133, 28);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "USUÁRIO:";
            // 
            // admName
            // 
            this.admName.AutoSize = true;
            this.admName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admName.Location = new System.Drawing.Point(151, 424);
            this.admName.Name = "admName";
            this.admName.Size = new System.Drawing.Size(72, 15);
            this.admName.TabIndex = 1;
            this.admName.Text = "USUÁRIO:";
            // 
            // AdmPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.admName);
            this.Controls.Add(this.labelName);
            this.Name = "AdmPage";
            this.Text = "AdmPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label admName;
    }
}