
namespace SoftwareCentral
{
    partial class frmDeliveryDataPdf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeliveryDataPdf));
            this.lblCode = new System.Windows.Forms.Label();
            this.lblDeliveryDate = new System.Windows.Forms.Label();
            this.lblPlanet = new System.Windows.Forms.Label();
            this.lblSpaceShip = new System.Windows.Forms.Label();
            this.dtpDelivery = new System.Windows.Forms.DateTimePicker();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.swTxtDeliveryCode = new CustomControls.SWTextBox();
            this.swCodShip = new CustomControls.SWCodi();
            this.swCodPlanet = new CustomControls.SWCodi();
            this.swTxtPlanet = new CustomControls.SWTextBox();
            this.swTxtShip = new CustomControls.SWTextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(57, 109);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(118, 20);
            this.lblCode.TabIndex = 37;
            this.lblCode.Text = "Delivery Code";
            // 
            // lblDeliveryDate
            // 
            this.lblDeliveryDate.AutoSize = true;
            this.lblDeliveryDate.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeliveryDate.Location = new System.Drawing.Point(60, 164);
            this.lblDeliveryDate.Name = "lblDeliveryDate";
            this.lblDeliveryDate.Size = new System.Drawing.Size(115, 20);
            this.lblDeliveryDate.TabIndex = 38;
            this.lblDeliveryDate.Text = "Delivery Date";
            // 
            // lblPlanet
            // 
            this.lblPlanet.AutoSize = true;
            this.lblPlanet.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanet.Location = new System.Drawing.Point(117, 219);
            this.lblPlanet.Name = "lblPlanet";
            this.lblPlanet.Size = new System.Drawing.Size(58, 20);
            this.lblPlanet.TabIndex = 39;
            this.lblPlanet.Text = "Planet";
            // 
            // lblSpaceShip
            // 
            this.lblSpaceShip.AutoSize = true;
            this.lblSpaceShip.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpaceShip.Location = new System.Drawing.Point(87, 274);
            this.lblSpaceShip.Name = "lblSpaceShip";
            this.lblSpaceShip.Size = new System.Drawing.Size(88, 20);
            this.lblSpaceShip.TabIndex = 40;
            this.lblSpaceShip.Text = "SpaceShip";
            // 
            // dtpDelivery
            // 
            this.dtpDelivery.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDelivery.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDelivery.Location = new System.Drawing.Point(211, 157);
            this.dtpDelivery.Name = "dtpDelivery";
            this.dtpDelivery.Size = new System.Drawing.Size(148, 27);
            this.dtpDelivery.TabIndex = 41;
            this.dtpDelivery.Tag = "DeliveryDate";
            // 
            // pbClose
            // 
            this.pbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbClose.BackColor = System.Drawing.Color.Transparent;
            this.pbClose.Image = ((System.Drawing.Image)(resources.GetObject("pbClose.Image")));
            this.pbClose.Location = new System.Drawing.Point(664, -1);
            this.pbClose.Margin = new System.Windows.Forms.Padding(0);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(38, 36);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClose.TabIndex = 21;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // swTxtDeliveryCode
            // 
            this.swTxtDeliveryCode.codiSW = null;
            this.swTxtDeliveryCode.columnName = "CodeDelivery";
            this.swTxtDeliveryCode.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swTxtDeliveryCode.Enabled = false;
            this.swTxtDeliveryCode.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swTxtDeliveryCode.isForeignKey = false;
            this.swTxtDeliveryCode.Location = new System.Drawing.Point(211, 100);
            this.swTxtDeliveryCode.Name = "swTxtDeliveryCode";
            this.swTxtDeliveryCode.required = false;
            this.swTxtDeliveryCode.Size = new System.Drawing.Size(200, 29);
            this.swTxtDeliveryCode.TabIndex = 24;
            // 
            // swCodShip
            // 
            this.swCodShip.classeCS = "SoftwareCentral";
            this.swCodShip.codeName = "CodeSpaceShip";
            this.swCodShip.controlId = "swTxtShip";
            this.swCodShip.descName = "CodeSpaceShip";
            this.swCodShip.formCS = "frmSearchSpaceShip";
            this.swCodShip.Location = new System.Drawing.Point(211, 265);
            this.swCodShip.Name = "swCodShip";
            this.swCodShip.nameId = "idSpaceShip";
            this.swCodShip.Size = new System.Drawing.Size(402, 29);
            this.swCodShip.TabIndex = 23;
            this.swCodShip.tableName = "SpaceShips";
            // 
            // swCodPlanet
            // 
            this.swCodPlanet.classeCS = "SoftwareCentral";
            this.swCodPlanet.codeName = "CodePlanet";
            this.swCodPlanet.controlId = "swTxtPlanet";
            this.swCodPlanet.descName = "DescPlanet";
            this.swCodPlanet.formCS = "frmSearchPlanet";
            this.swCodPlanet.Location = new System.Drawing.Point(211, 210);
            this.swCodPlanet.Name = "swCodPlanet";
            this.swCodPlanet.nameId = "idPlanet";
            this.swCodPlanet.Size = new System.Drawing.Size(402, 29);
            this.swCodPlanet.TabIndex = 22;
            this.swCodPlanet.tableName = "Planets";
            // 
            // swTxtPlanet
            // 
            this.swTxtPlanet.codiSW = "swCodPlanet";
            this.swTxtPlanet.columnName = "idPlanet";
            this.swTxtPlanet.dadaPermesa = CustomControls.SWTextBox.TipusDada.Nombre;
            this.swTxtPlanet.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swTxtPlanet.isForeignKey = true;
            this.swTxtPlanet.Location = new System.Drawing.Point(448, 210);
            this.swTxtPlanet.Name = "swTxtPlanet";
            this.swTxtPlanet.required = true;
            this.swTxtPlanet.Size = new System.Drawing.Size(50, 29);
            this.swTxtPlanet.TabIndex = 25;
            this.swTxtPlanet.TabStop = false;
            // 
            // swTxtShip
            // 
            this.swTxtShip.codiSW = "swCodShip";
            this.swTxtShip.columnName = "idSpaceShip";
            this.swTxtShip.dadaPermesa = CustomControls.SWTextBox.TipusDada.Nombre;
            this.swTxtShip.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swTxtShip.isForeignKey = true;
            this.swTxtShip.Location = new System.Drawing.Point(498, 265);
            this.swTxtShip.Name = "swTxtShip";
            this.swTxtShip.required = true;
            this.swTxtShip.Size = new System.Drawing.Size(39, 29);
            this.swTxtShip.TabIndex = 26;
            this.swTxtShip.TabStop = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.CausesValidation = false;
            this.btnUpdate.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(516, 331);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(97, 39);
            this.btnUpdate.TabIndex = 99;
            this.btnUpdate.Text = "Save";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(226, 387);
            this.lblError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(387, 20);
            this.lblError.TabIndex = 100;
            this.lblError.Text = "One or more mandatory fields are blank or incorrect";
            this.lblError.Visible = false;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(55, 35);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(183, 33);
            this.lblMessage.TabIndex = 101;
            this.lblMessage.Text = "New delivery";
            // 
            // frmDeliveryDataPdf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dtpDelivery);
            this.Controls.Add(this.lblSpaceShip);
            this.Controls.Add(this.lblPlanet);
            this.Controls.Add(this.lblDeliveryDate);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.swTxtDeliveryCode);
            this.Controls.Add(this.swCodShip);
            this.Controls.Add(this.swCodPlanet);
            this.Controls.Add(this.pbClose);
            this.Controls.Add(this.swTxtPlanet);
            this.Controls.Add(this.swTxtShip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDeliveryDataPdf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDeliveryDataPdf";
            this.Load += new System.EventHandler(this.frmDeliveryDataPdf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.PictureBox pbClose;
        private CustomControls.SWCodi swCodPlanet;
        private CustomControls.SWCodi swCodShip;
        private CustomControls.SWTextBox swTxtDeliveryCode;
        private CustomControls.SWTextBox swTxtPlanet;
        private CustomControls.SWTextBox swTxtShip;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblDeliveryDate;
        private System.Windows.Forms.Label lblPlanet;
        private System.Windows.Forms.Label lblSpaceShip;
        private System.Windows.Forms.DateTimePicker dtpDelivery;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblMessage;
    }
}