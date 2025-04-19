
namespace CustomControls
{
    partial class SWCodi
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
            this.txtCodi = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtCodi
            // 
            this.txtCodi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodi.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtCodi.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodi.Location = new System.Drawing.Point(0, 0);
            this.txtCodi.MaxLength = 4;
            this.txtCodi.Name = "txtCodi";
            this.txtCodi.Size = new System.Drawing.Size(66, 29);
            this.txtCodi.TabIndex = 0;
            this.txtCodi.DoubleClick += new System.EventHandler(this.txtCodi_DoubleClick);
            this.txtCodi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodi_KeyDown);
            this.txtCodi.Leave += new System.EventHandler(this.txtCodi_Leave);
            // 
            // txtDesc
            // 
            this.txtDesc.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtDesc.Enabled = false;
            this.txtDesc.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(85, 0);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(317, 29);
            this.txtDesc.TabIndex = 1;
            // 
            // SWCodi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtCodi);
            this.Name = "SWCodi";
            this.Size = new System.Drawing.Size(402, 29);
            this.Load += new System.EventHandler(this.SWCodi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodi;
        private System.Windows.Forms.TextBox txtDesc;
    }
}

