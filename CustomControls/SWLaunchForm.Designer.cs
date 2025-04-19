
namespace CustomControls
{
    partial class SWLaunchForm
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTextBtn = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTextBtn
            // 
            this.lblTextBtn.Font = new System.Drawing.Font("Cambria", 11.8F, System.Drawing.FontStyle.Bold);
            this.lblTextBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTextBtn.Location = new System.Drawing.Point(120, 19);
            this.lblTextBtn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTextBtn.Name = "lblTextBtn";
            this.lblTextBtn.Size = new System.Drawing.Size(140, 92);
            this.lblTextBtn.TabIndex = 6;
            this.lblTextBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTextBtn.Click += new System.EventHandler(this.lblTextBtn_Click);
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(10, 19);
            this.pbImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(106, 92);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 5;
            this.pbImage.TabStop = false;
            this.pbImage.Click += new System.EventHandler(this.pbImage_Click);
            // 
            // SWLaunchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblTextBtn);
            this.Controls.Add(this.pbImage);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "SWLaunchForm";
            this.Size = new System.Drawing.Size(275, 130);
            this.Click += new System.EventHandler(this.SWLaunchForm_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTextBtn;
        private System.Windows.Forms.PictureBox pbImage;
    }
}
