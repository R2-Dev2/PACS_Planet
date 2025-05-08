
namespace PACS_Planet
{
    partial class frmPlanet
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlanet));
            this.flpFrms = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlListBox = new System.Windows.Forms.Panel();
            this.lbxInfo = new System.Windows.Forms.ListBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblMsgStatus = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.lblTitle1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnDesencriptarPDF = new System.Windows.Forms.Button();
            this.btnDesencriptarCred = new System.Windows.Forms.Button();
            this.btnEnviar2 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnDecodificar = new System.Windows.Forms.Button();
            this.btnEnviar3 = new System.Windows.Forms.Button();
            this.btnGenerarFitxer = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnEnviar4 = new System.Windows.Forms.Button();
            this.btnComprovar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblListening = new System.Windows.Forms.Label();
            this.btnStopListening = new System.Windows.Forms.Button();
            this.btnNewDelivery = new System.Windows.Forms.Button();
            this.btnGenerateKeys = new System.Windows.Forms.Button();
            this.btnStartListening = new System.Windows.Forms.Button();
            this.btnGenerateCodes = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flpFrms.SuspendLayout();
            this.pnlListBox.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.pnlTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpFrms
            // 
            this.flpFrms.Controls.Add(this.pnlListBox);
            this.flpFrms.Controls.Add(this.tabControl);
            this.flpFrms.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpFrms.Location = new System.Drawing.Point(0, 263);
            this.flpFrms.Margin = new System.Windows.Forms.Padding(2);
            this.flpFrms.Name = "flpFrms";
            this.flpFrms.Size = new System.Drawing.Size(1079, 556);
            this.flpFrms.TabIndex = 1;
            // 
            // pnlListBox
            // 
            this.pnlListBox.Controls.Add(this.lbxInfo);
            this.pnlListBox.Location = new System.Drawing.Point(3, 3);
            this.pnlListBox.Name = "pnlListBox";
            this.pnlListBox.Size = new System.Drawing.Size(397, 626);
            this.pnlListBox.TabIndex = 8;
            // 
            // lbxInfo
            // 
            this.lbxInfo.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxInfo.FormattingEnabled = true;
            this.lbxInfo.HorizontalScrollbar = true;
            this.lbxInfo.ItemHeight = 20;
            this.lbxInfo.Location = new System.Drawing.Point(84, 34);
            this.lbxInfo.Margin = new System.Windows.Forms.Padding(2);
            this.lbxInfo.Name = "lbxInfo";
            this.lbxInfo.Size = new System.Drawing.Size(255, 364);
            this.lbxInfo.TabIndex = 5;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(405, 2);
            this.tabControl.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(3, 3);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(670, 628);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabPage1.Controls.Add(this.lblMsgStatus);
            this.tabPage1.Controls.Add(this.btnEnviar);
            this.tabPage1.Controls.Add(this.button7);
            this.tabPage1.Controls.Add(this.lblTitle1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(662, 599);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // lblMsgStatus
            // 
            this.lblMsgStatus.AutoSize = true;
            this.lblMsgStatus.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgStatus.Location = new System.Drawing.Point(59, 52);
            this.lblMsgStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMsgStatus.Name = "lblMsgStatus";
            this.lblMsgStatus.Size = new System.Drawing.Size(0, 23);
            this.lblMsgStatus.TabIndex = 8;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(63, 146);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(170, 38);
            this.btnEnviar.TabIndex = 7;
            this.btnEnviar.Text = "Send Response";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(566, 348);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(81, 26);
            this.button7.TabIndex = 6;
            this.button7.Text = "Next";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // lblTitle1
            // 
            this.lblTitle1.AutoSize = true;
            this.lblTitle1.Font = new System.Drawing.Font("Cambria", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle1.Location = new System.Drawing.Point(57, 20);
            this.lblTitle1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Size = new System.Drawing.Size(260, 32);
            this.lblTitle1.TabIndex = 4;
            this.lblTitle1.Text = "Waiting for messages";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabPage2.Controls.Add(this.btnDesencriptarPDF);
            this.tabPage2.Controls.Add(this.btnDesencriptarCred);
            this.tabPage2.Controls.Add(this.btnEnviar2);
            this.tabPage2.Controls.Add(this.button8);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(662, 599);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // btnDesencriptarPDF
            // 
            this.btnDesencriptarPDF.Location = new System.Drawing.Point(342, 134);
            this.btnDesencriptarPDF.Margin = new System.Windows.Forms.Padding(2);
            this.btnDesencriptarPDF.Name = "btnDesencriptarPDF";
            this.btnDesencriptarPDF.Size = new System.Drawing.Size(111, 49);
            this.btnDesencriptarPDF.TabIndex = 10;
            this.btnDesencriptarPDF.Text = "Desencriptar PDF";
            this.btnDesencriptarPDF.UseVisualStyleBackColor = true;
            // 
            // btnDesencriptarCred
            // 
            this.btnDesencriptarCred.Location = new System.Drawing.Point(342, 81);
            this.btnDesencriptarCred.Margin = new System.Windows.Forms.Padding(2);
            this.btnDesencriptarCred.Name = "btnDesencriptarCred";
            this.btnDesencriptarCred.Size = new System.Drawing.Size(111, 49);
            this.btnDesencriptarCred.TabIndex = 9;
            this.btnDesencriptarCred.Text = "Desencriptar Credencials";
            this.btnDesencriptarCred.UseVisualStyleBackColor = true;
            this.btnDesencriptarCred.Click += new System.EventHandler(this.btnDesencriptarCred_Click);
            // 
            // btnEnviar2
            // 
            this.btnEnviar2.Location = new System.Drawing.Point(342, 187);
            this.btnEnviar2.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnviar2.Name = "btnEnviar2";
            this.btnEnviar2.Size = new System.Drawing.Size(83, 30);
            this.btnEnviar2.TabIndex = 8;
            this.btnEnviar2.Text = "Enviar";
            this.btnEnviar2.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(566, 348);
            this.button8.Margin = new System.Windows.Forms.Padding(2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(81, 26);
            this.button8.TabIndex = 7;
            this.button8.Text = "Next";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(278, 22);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(291, 32);
            this.label6.TabIndex = 5;
            this.label6.Text = "ENVIANT MISSATGE VR";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabPage3.Controls.Add(this.btnDecodificar);
            this.tabPage3.Controls.Add(this.btnEnviar3);
            this.tabPage3.Controls.Add(this.btnGenerarFitxer);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(662, 599);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            // 
            // btnDecodificar
            // 
            this.btnDecodificar.Location = new System.Drawing.Point(362, 135);
            this.btnDecodificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnDecodificar.Name = "btnDecodificar";
            this.btnDecodificar.Size = new System.Drawing.Size(110, 42);
            this.btnDecodificar.TabIndex = 9;
            this.btnDecodificar.Text = "Decodificar i Calcular";
            this.btnDecodificar.UseVisualStyleBackColor = true;
            // 
            // btnEnviar3
            // 
            this.btnEnviar3.Location = new System.Drawing.Point(362, 187);
            this.btnEnviar3.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnviar3.Name = "btnEnviar3";
            this.btnEnviar3.Size = new System.Drawing.Size(68, 32);
            this.btnEnviar3.TabIndex = 8;
            this.btnEnviar3.Text = "Enviar";
            this.btnEnviar3.UseVisualStyleBackColor = true;
            // 
            // btnGenerarFitxer
            // 
            this.btnGenerarFitxer.Location = new System.Drawing.Point(362, 81);
            this.btnGenerarFitxer.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerarFitxer.Name = "btnGenerarFitxer";
            this.btnGenerarFitxer.Size = new System.Drawing.Size(110, 51);
            this.btnGenerarFitxer.TabIndex = 7;
            this.btnGenerarFitxer.Text = "Generar Fitxer i Comprimir";
            this.btnGenerarFitxer.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(566, 348);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 26);
            this.button1.TabIndex = 6;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(278, 22);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(291, 32);
            this.label7.TabIndex = 4;
            this.label7.Text = "ENVIANT MISSATGE VR";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabPage4.Controls.Add(this.btnEnviar4);
            this.tabPage4.Controls.Add(this.btnComprovar);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage4.Size = new System.Drawing.Size(662, 599);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            // 
            // btnEnviar4
            // 
            this.btnEnviar4.Location = new System.Drawing.Point(141, 161);
            this.btnEnviar4.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnviar4.Name = "btnEnviar4";
            this.btnEnviar4.Size = new System.Drawing.Size(79, 35);
            this.btnEnviar4.TabIndex = 8;
            this.btnEnviar4.Text = "Enviar";
            this.btnEnviar4.UseVisualStyleBackColor = true;
            // 
            // btnComprovar
            // 
            this.btnComprovar.Location = new System.Drawing.Point(141, 104);
            this.btnComprovar.Margin = new System.Windows.Forms.Padding(2);
            this.btnComprovar.Name = "btnComprovar";
            this.btnComprovar.Size = new System.Drawing.Size(107, 45);
            this.btnComprovar.TabIndex = 7;
            this.btnComprovar.Text = "Comprovar total calculat";
            this.btnComprovar.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 24);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(291, 32);
            this.label8.TabIndex = 4;
            this.label8.Text = "ENVIANT MISSATGE VR";
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlTop.Controls.Add(this.lblListening);
            this.pnlTop.Controls.Add(this.btnStopListening);
            this.pnlTop.Controls.Add(this.btnNewDelivery);
            this.pnlTop.Controls.Add(this.btnGenerateKeys);
            this.pnlTop.Controls.Add(this.btnStartListening);
            this.pnlTop.Controls.Add(this.btnGenerateCodes);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 58);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1079, 142);
            this.pnlTop.TabIndex = 1;
            // 
            // lblListening
            // 
            this.lblListening.AutoSize = true;
            this.lblListening.Font = new System.Drawing.Font("Cambria", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListening.Location = new System.Drawing.Point(41, 34);
            this.lblListening.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblListening.Name = "lblListening";
            this.lblListening.Size = new System.Drawing.Size(241, 32);
            this.lblListening.TabIndex = 7;
            this.lblListening.Text = "Listen for messages";
            // 
            // btnStopListening
            // 
            this.btnStopListening.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopListening.Location = new System.Drawing.Point(158, 98);
            this.btnStopListening.Margin = new System.Windows.Forms.Padding(2);
            this.btnStopListening.Name = "btnStopListening";
            this.btnStopListening.Size = new System.Drawing.Size(77, 30);
            this.btnStopListening.TabIndex = 6;
            this.btnStopListening.Text = "Stop";
            this.btnStopListening.UseVisualStyleBackColor = true;
            this.btnStopListening.Click += new System.EventHandler(this.btnStopListening_Click);
            // 
            // btnNewDelivery
            // 
            this.btnNewDelivery.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewDelivery.Location = new System.Drawing.Point(559, 34);
            this.btnNewDelivery.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewDelivery.Name = "btnNewDelivery";
            this.btnNewDelivery.Size = new System.Drawing.Size(139, 94);
            this.btnNewDelivery.TabIndex = 5;
            this.btnNewDelivery.Text = "New Delivery";
            this.btnNewDelivery.UseVisualStyleBackColor = true;
            this.btnNewDelivery.Click += new System.EventHandler(this.btnNewDelivery_Click);
            // 
            // btnGenerateKeys
            // 
            this.btnGenerateKeys.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateKeys.Location = new System.Drawing.Point(385, 34);
            this.btnGenerateKeys.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerateKeys.Name = "btnGenerateKeys";
            this.btnGenerateKeys.Size = new System.Drawing.Size(135, 94);
            this.btnGenerateKeys.TabIndex = 4;
            this.btnGenerateKeys.Text = "Generate RSA Keys";
            this.btnGenerateKeys.UseVisualStyleBackColor = true;
            this.btnGenerateKeys.Click += new System.EventHandler(this.btnGenerateKeys_Click);
            // 
            // btnStartListening
            // 
            this.btnStartListening.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartListening.Location = new System.Drawing.Point(62, 98);
            this.btnStartListening.Margin = new System.Windows.Forms.Padding(2);
            this.btnStartListening.Name = "btnStartListening";
            this.btnStartListening.Size = new System.Drawing.Size(77, 30);
            this.btnStartListening.TabIndex = 0;
            this.btnStartListening.Text = "Start";
            this.btnStartListening.UseVisualStyleBackColor = true;
            this.btnStartListening.Click += new System.EventHandler(this.btnStartListening_Click);
            // 
            // btnGenerateCodes
            // 
            this.btnGenerateCodes.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateCodes.Location = new System.Drawing.Point(747, 34);
            this.btnGenerateCodes.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerateCodes.Name = "btnGenerateCodes";
            this.btnGenerateCodes.Size = new System.Drawing.Size(134, 94);
            this.btnGenerateCodes.TabIndex = 3;
            this.btnGenerateCodes.Text = "Planet codification";
            this.btnGenerateCodes.UseVisualStyleBackColor = true;
            this.btnGenerateCodes.Click += new System.EventHandler(this.btnGenerateCodes_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(432, 10);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(194, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Nom Planets";
            // 
            // pbClose
            // 
            this.pbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbClose.BackColor = System.Drawing.Color.Transparent;
            this.pbClose.Image = global::PACS_Planet.Properties.Resources.close;
            this.pbClose.Location = new System.Drawing.Point(1039, 0);
            this.pbClose.Margin = new System.Windows.Forms.Padding(0);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(40, 40);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClose.TabIndex = 23;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.LightGray;
            this.pnlTitle.Controls.Add(this.pbClose);
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(1079, 58);
            this.pnlTitle.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(453, 222);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "------------------------";
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(400, 215);
            this.btn2.Margin = new System.Windows.Forms.Padding(2);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(55, 30);
            this.btn2.TabIndex = 7;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(227, 215);
            this.btn1.Margin = new System.Windows.Forms.Padding(2);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(55, 30);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(747, 215);
            this.btn4.Margin = new System.Windows.Forms.Padding(2);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(55, 30);
            this.btn4.TabIndex = 8;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(571, 215);
            this.btn3.Margin = new System.Windows.Forms.Padding(2);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(55, 30);
            this.btn3.TabIndex = 6;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(627, 222);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "------------------------";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 222);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "------------------------";
            // 
            // frmPlanet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1079, 819);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.flpFrms);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPlanet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPlanet_Load);
            this.flpFrms.ResumeLayout(false);
            this.pnlListBox.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flpFrms;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnNewDelivery;
        private System.Windows.Forms.Button btnGenerateKeys;
        private System.Windows.Forms.Button btnGenerateCodes;
        private System.Windows.Forms.Button btnStartListening;
        private System.Windows.Forms.ListBox lbxInfo;
        private System.Windows.Forms.Label lblTitle;
        protected System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblListening;
        private System.Windows.Forms.Button btnStopListening;
        private System.Windows.Forms.Panel pnlListBox;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblMsgStatus;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTitle1;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnDesencriptarPDF;
        private System.Windows.Forms.Button btnDesencriptarCred;
        private System.Windows.Forms.Button btnEnviar2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnDecodificar;
        private System.Windows.Forms.Button btnEnviar3;
        private System.Windows.Forms.Button btnGenerarFitxer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnEnviar4;
        private System.Windows.Forms.Button btnComprovar;
        private System.Windows.Forms.Label label8;
    }
}

