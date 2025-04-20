
namespace SearchForms
{
    partial class frmSearchPlanet
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
            this.lblCodeSpec = new System.Windows.Forms.Label();
            this.lblDescSpecie = new System.Windows.Forms.Label();
            this.swtxtDescPlan = new CustomControls.SWTextBox();
            this.swtxtCodePlan = new CustomControls.SWTextBox();
            this.lblLong = new System.Windows.Forms.Label();
            this.swTxtLong = new CustomControls.SWTextBox();
            this.lblLat = new System.Windows.Forms.Label();
            this.swTxtLat = new CustomControls.SWTextBox();
            this.lblparsecs = new System.Windows.Forms.Label();
            this.swTxtparsecs = new CustomControls.SWTextBox();
            this.lblIPPlanet = new System.Windows.Forms.Label();
            this.swTxtIPPlanet = new CustomControls.SWTextBox();
            this.lblPortPlanet = new System.Windows.Forms.Label();
            this.swTxtPortPlanet = new CustomControls.SWTextBox();
            this.lblPortPlanet1 = new System.Windows.Forms.Label();
            this.swTxtPortPlanet1 = new CustomControls.SWTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodeSpec
            // 
            this.lblCodeSpec.AutoSize = true;
            this.lblCodeSpec.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeSpec.Location = new System.Drawing.Point(88, 94);
            this.lblCodeSpec.Name = "lblCodeSpec";
            this.lblCodeSpec.Size = new System.Drawing.Size(48, 20);
            this.lblCodeSpec.TabIndex = 25;
            this.lblCodeSpec.Text = "Code";
            // 
            // lblDescSpecie
            // 
            this.lblDescSpecie.AutoSize = true;
            this.lblDescSpecie.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescSpecie.Location = new System.Drawing.Point(281, 94);
            this.lblDescSpecie.Name = "lblDescSpecie";
            this.lblDescSpecie.Size = new System.Drawing.Size(100, 20);
            this.lblDescSpecie.TabIndex = 26;
            this.lblDescSpecie.Text = "Description";
            // 
            // swtxtDescPlan
            // 
            this.swtxtDescPlan.codiSW = null;
            this.swtxtDescPlan.columnName = "DescPlanet";
            this.swtxtDescPlan.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swtxtDescPlan.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swtxtDescPlan.isForeignKey = false;
            this.swtxtDescPlan.Location = new System.Drawing.Point(395, 90);
            this.swtxtDescPlan.Name = "swtxtDescPlan";
            this.swtxtDescPlan.required = false;
            this.swtxtDescPlan.Size = new System.Drawing.Size(219, 29);
            this.swtxtDescPlan.TabIndex = 24;
            // 
            // swtxtCodePlan
            // 
            this.swtxtCodePlan.codiSW = null;
            this.swtxtCodePlan.columnName = "CodePlanet";
            this.swtxtCodePlan.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swtxtCodePlan.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swtxtCodePlan.isForeignKey = false;
            this.swtxtCodePlan.Location = new System.Drawing.Point(145, 90);
            this.swtxtCodePlan.Name = "swtxtCodePlan";
            this.swtxtCodePlan.required = false;
            this.swtxtCodePlan.Size = new System.Drawing.Size(124, 29);
            this.swtxtCodePlan.TabIndex = 23;
            // 
            // lblLong
            // 
            this.lblLong.AutoSize = true;
            this.lblLong.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLong.Location = new System.Drawing.Point(49, 140);
            this.lblLong.Name = "lblLong";
            this.lblLong.Size = new System.Drawing.Size(87, 20);
            this.lblLong.TabIndex = 28;
            this.lblLong.Text = "Longitude";
            // 
            // swTxtLong
            // 
            this.swTxtLong.codiSW = null;
            this.swTxtLong.columnName = "long";
            this.swTxtLong.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swTxtLong.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swTxtLong.isForeignKey = false;
            this.swTxtLong.Location = new System.Drawing.Point(145, 136);
            this.swTxtLong.Name = "swTxtLong";
            this.swTxtLong.required = false;
            this.swTxtLong.Size = new System.Drawing.Size(124, 29);
            this.swTxtLong.TabIndex = 27;
            // 
            // lblLat
            // 
            this.lblLat.AutoSize = true;
            this.lblLat.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLat.Location = new System.Drawing.Point(308, 140);
            this.lblLat.Name = "lblLat";
            this.lblLat.Size = new System.Drawing.Size(73, 20);
            this.lblLat.TabIndex = 30;
            this.lblLat.Text = "Latitude";
            // 
            // swTxtLat
            // 
            this.swTxtLat.codiSW = null;
            this.swTxtLat.columnName = "lat";
            this.swTxtLat.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swTxtLat.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swTxtLat.isForeignKey = false;
            this.swTxtLat.Location = new System.Drawing.Point(395, 136);
            this.swTxtLat.Name = "swTxtLat";
            this.swTxtLat.required = false;
            this.swTxtLat.Size = new System.Drawing.Size(127, 29);
            this.swTxtLat.TabIndex = 29;
            // 
            // lblparsecs
            // 
            this.lblparsecs.AutoSize = true;
            this.lblparsecs.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblparsecs.Location = new System.Drawing.Point(67, 186);
            this.lblparsecs.Name = "lblparsecs";
            this.lblparsecs.Size = new System.Drawing.Size(69, 20);
            this.lblparsecs.TabIndex = 33;
            this.lblparsecs.Text = "Parsecs";
            // 
            // swTxtparsecs
            // 
            this.swTxtparsecs.codiSW = null;
            this.swTxtparsecs.columnName = "parsecs";
            this.swTxtparsecs.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swTxtparsecs.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swTxtparsecs.isForeignKey = false;
            this.swTxtparsecs.Location = new System.Drawing.Point(145, 182);
            this.swTxtparsecs.Name = "swTxtparsecs";
            this.swTxtparsecs.required = false;
            this.swTxtparsecs.Size = new System.Drawing.Size(124, 29);
            this.swTxtparsecs.TabIndex = 31;
            // 
            // lblIPPlanet
            // 
            this.lblIPPlanet.AutoSize = true;
            this.lblIPPlanet.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIPPlanet.Location = new System.Drawing.Point(356, 186);
            this.lblIPPlanet.Name = "lblIPPlanet";
            this.lblIPPlanet.Size = new System.Drawing.Size(25, 20);
            this.lblIPPlanet.TabIndex = 37;
            this.lblIPPlanet.Text = "IP";
            // 
            // swTxtIPPlanet
            // 
            this.swTxtIPPlanet.codiSW = null;
            this.swTxtIPPlanet.columnName = "IPPlanet";
            this.swTxtIPPlanet.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swTxtIPPlanet.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swTxtIPPlanet.isForeignKey = false;
            this.swTxtIPPlanet.Location = new System.Drawing.Point(395, 228);
            this.swTxtIPPlanet.Name = "swTxtIPPlanet";
            this.swTxtIPPlanet.required = false;
            this.swTxtIPPlanet.Size = new System.Drawing.Size(127, 29);
            this.swTxtIPPlanet.TabIndex = 36;
            // 
            // lblPortPlanet
            // 
            this.lblPortPlanet.AutoSize = true;
            this.lblPortPlanet.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPortPlanet.Location = new System.Drawing.Point(40, 232);
            this.lblPortPlanet.Name = "lblPortPlanet";
            this.lblPortPlanet.Size = new System.Drawing.Size(96, 20);
            this.lblPortPlanet.TabIndex = 39;
            this.lblPortPlanet.Text = "Planet Port";
            // 
            // swTxtPortPlanet
            // 
            this.swTxtPortPlanet.codiSW = null;
            this.swTxtPortPlanet.columnName = "PortPlanet";
            this.swTxtPortPlanet.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swTxtPortPlanet.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swTxtPortPlanet.isForeignKey = false;
            this.swTxtPortPlanet.Location = new System.Drawing.Point(145, 228);
            this.swTxtPortPlanet.Name = "swTxtPortPlanet";
            this.swTxtPortPlanet.required = false;
            this.swTxtPortPlanet.Size = new System.Drawing.Size(124, 29);
            this.swTxtPortPlanet.TabIndex = 38;
            // 
            // lblPortPlanet1
            // 
            this.lblPortPlanet1.AutoSize = true;
            this.lblPortPlanet1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPortPlanet1.Location = new System.Drawing.Point(276, 232);
            this.lblPortPlanet1.Name = "lblPortPlanet1";
            this.lblPortPlanet1.Size = new System.Drawing.Size(105, 20);
            this.lblPortPlanet1.TabIndex = 41;
            this.lblPortPlanet1.Text = "Backup Port";
            // 
            // swTxtPortPlanet1
            // 
            this.swTxtPortPlanet1.codiSW = null;
            this.swTxtPortPlanet1.columnName = "PortPlanet1";
            this.swTxtPortPlanet1.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swTxtPortPlanet1.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swTxtPortPlanet1.isForeignKey = false;
            this.swTxtPortPlanet1.Location = new System.Drawing.Point(395, 182);
            this.swTxtPortPlanet1.Name = "swTxtPortPlanet1";
            this.swTxtPortPlanet1.required = false;
            this.swTxtPortPlanet1.Size = new System.Drawing.Size(127, 29);
            this.swTxtPortPlanet1.TabIndex = 40;
            // 
            // frmPlanetsSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 633);
            this.Controls.Add(this.lblPortPlanet1);
            this.Controls.Add(this.swTxtPortPlanet1);
            this.Controls.Add(this.lblPortPlanet);
            this.Controls.Add(this.swTxtPortPlanet);
            this.Controls.Add(this.lblIPPlanet);
            this.Controls.Add(this.swTxtIPPlanet);
            this.Controls.Add(this.lblparsecs);
            this.Controls.Add(this.swTxtparsecs);
            this.Controls.Add(this.lblLat);
            this.Controls.Add(this.swTxtLat);
            this.Controls.Add(this.lblLong);
            this.Controls.Add(this.swTxtLong);
            this.Controls.Add(this.lblCodeSpec);
            this.Controls.Add(this.lblDescSpecie);
            this.Controls.Add(this.swtxtDescPlan);
            this.Controls.Add(this.swtxtCodePlan);
            this.Name = "frmPlanetsSearch";
            this.Text = "frmPlanetsSearch";
            this.Controls.SetChildIndex(this.pbClose, 0);
            this.Controls.SetChildIndex(this.swtxtCodePlan, 0);
            this.Controls.SetChildIndex(this.swtxtDescPlan, 0);
            this.Controls.SetChildIndex(this.lblDescSpecie, 0);
            this.Controls.SetChildIndex(this.lblCodeSpec, 0);
            this.Controls.SetChildIndex(this.swTxtLong, 0);
            this.Controls.SetChildIndex(this.lblLong, 0);
            this.Controls.SetChildIndex(this.swTxtLat, 0);
            this.Controls.SetChildIndex(this.lblLat, 0);
            this.Controls.SetChildIndex(this.swTxtparsecs, 0);
            this.Controls.SetChildIndex(this.lblparsecs, 0);
            this.Controls.SetChildIndex(this.swTxtIPPlanet, 0);
            this.Controls.SetChildIndex(this.lblIPPlanet, 0);
            this.Controls.SetChildIndex(this.swTxtPortPlanet, 0);
            this.Controls.SetChildIndex(this.lblPortPlanet, 0);
            this.Controls.SetChildIndex(this.swTxtPortPlanet1, 0);
            this.Controls.SetChildIndex(this.lblPortPlanet1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodeSpec;
        private System.Windows.Forms.Label lblDescSpecie;
        private CustomControls.SWTextBox swtxtDescPlan;
        private System.Windows.Forms.Label lblLong;
        private System.Windows.Forms.Label lblLat;
        private System.Windows.Forms.Label lblparsecs;
        private System.Windows.Forms.Label lblIPPlanet;
        private System.Windows.Forms.Label lblPortPlanet;
        private System.Windows.Forms.Label lblPortPlanet1;
        private CustomControls.SWTextBox swTxtLong;
        private CustomControls.SWTextBox swTxtLat;
        private CustomControls.SWTextBox swTxtparsecs;
        private CustomControls.SWTextBox swTxtIPPlanet;
        private CustomControls.SWTextBox swTxtPortPlanet;
        private CustomControls.SWTextBox swTxtPortPlanet1;
        private CustomControls.SWTextBox swtxtCodePlan;
    }
}