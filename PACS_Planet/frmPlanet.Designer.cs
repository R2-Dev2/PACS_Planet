
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.flpFrms = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnNewDelivery = new System.Windows.Forms.Button();
            this.btnGenerateKeys = new System.Windows.Forms.Button();
            this.btnGenerateCodes = new System.Windows.Forms.Button();
            this.lblListen = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnEnviar4 = new System.Windows.Forms.Button();
            this.btnComprovar = new System.Windows.Forms.Button();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnDecodificar = new System.Windows.Forms.Button();
            this.btnEnviar3 = new System.Windows.Forms.Button();
            this.btnGenerarFitxer = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnDesencriptarPDF = new System.Windows.Forms.Button();
            this.btnDesencriptarCred = new System.Windows.Forms.Button();
            this.btnEnviar2 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(4, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1396, 141);
            this.panel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(521, 32);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(399, 73);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Nom Planets";
            // 
            // flpFrms
            // 
            this.flpFrms.Location = new System.Drawing.Point(4, 493);
            this.flpFrms.Name = "flpFrms";
            this.flpFrms.Size = new System.Drawing.Size(1396, 657);
            this.flpFrms.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnNewDelivery);
            this.panel2.Controls.Add(this.btnGenerateKeys);
            this.panel2.Controls.Add(this.lblListen);
            this.panel2.Controls.Add(this.btnGenerateCodes);
            this.panel2.Location = new System.Drawing.Point(4, 146);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1393, 218);
            this.panel2.TabIndex = 1;
            // 
            // btnNewDelivery
            // 
            this.btnNewDelivery.Location = new System.Drawing.Point(883, 36);
            this.btnNewDelivery.Name = "btnNewDelivery";
            this.btnNewDelivery.Size = new System.Drawing.Size(163, 147);
            this.btnNewDelivery.TabIndex = 5;
            this.btnNewDelivery.Text = "New Delivery";
            this.btnNewDelivery.UseVisualStyleBackColor = true;
            this.btnNewDelivery.Click += new System.EventHandler(this.btnNewDelivery_Click);
            // 
            // btnGenerateKeys
            // 
            this.btnGenerateKeys.Location = new System.Drawing.Point(617, 36);
            this.btnGenerateKeys.Name = "btnGenerateKeys";
            this.btnGenerateKeys.Size = new System.Drawing.Size(163, 147);
            this.btnGenerateKeys.TabIndex = 4;
            this.btnGenerateKeys.Text = "Generate RSA Keys";
            this.btnGenerateKeys.UseVisualStyleBackColor = true;
            this.btnGenerateKeys.Click += new System.EventHandler(this.btnGenerateKeys_Click);
            // 
            // btnGenerateCodes
            // 
            this.btnGenerateCodes.Location = new System.Drawing.Point(1120, 36);
            this.btnGenerateCodes.Name = "btnGenerateCodes";
            this.btnGenerateCodes.Size = new System.Drawing.Size(163, 147);
            this.btnGenerateCodes.TabIndex = 3;
            this.btnGenerateCodes.Text = "Planet codification";
            this.btnGenerateCodes.UseVisualStyleBackColor = true;
            this.btnGenerateCodes.Click += new System.EventHandler(this.btnGenerateCodes_Click);
            // 
            // lblListen
            // 
            this.lblListen.Location = new System.Drawing.Point(112, 86);
            this.lblListen.Name = "lblListen";
            this.lblListen.Size = new System.Drawing.Size(116, 47);
            this.lblListen.TabIndex = 0;
            this.lblListen.Text = "listen";
            this.lblListen.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(238, 399);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(84, 47);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(755, 399);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(84, 47);
            this.btn3.TabIndex = 6;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(498, 399);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(84, 47);
            this.btn2.TabIndex = 7;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(1018, 399);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(84, 47);
            this.btn4.TabIndex = 8;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 410);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "------------------------";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(577, 410);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "------------------------";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(839, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "------------------------";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabPage4.Controls.Add(this.btnEnviar4);
            this.tabPage4.Controls.Add(this.btnComprovar);
            this.tabPage4.Controls.Add(this.listBox4);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Location = new System.Drawing.Point(8, 39);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1377, 572);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            // 
            // btnEnviar4
            // 
            this.btnEnviar4.Location = new System.Drawing.Point(593, 249);
            this.btnEnviar4.Name = "btnEnviar4";
            this.btnEnviar4.Size = new System.Drawing.Size(119, 54);
            this.btnEnviar4.TabIndex = 8;
            this.btnEnviar4.Text = "Enviar";
            this.btnEnviar4.UseVisualStyleBackColor = true;
            // 
            // btnComprovar
            // 
            this.btnComprovar.Location = new System.Drawing.Point(593, 160);
            this.btnComprovar.Name = "btnComprovar";
            this.btnComprovar.Size = new System.Drawing.Size(161, 71);
            this.btnComprovar.TabIndex = 7;
            this.btnComprovar.Text = "Comprovar total calculat";
            this.btnComprovar.UseVisualStyleBackColor = true;
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 25;
            this.listBox4.Location = new System.Drawing.Point(94, 126);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(361, 354);
            this.listBox4.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(417, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(514, 51);
            this.label8.TabIndex = 4;
            this.label8.Text = "ENVIANT MISSATGE VR";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabPage3.Controls.Add(this.btnDecodificar);
            this.tabPage3.Controls.Add(this.btnEnviar3);
            this.tabPage3.Controls.Add(this.btnGenerarFitxer);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.listBox3);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Location = new System.Drawing.Point(8, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1377, 572);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            // 
            // btnDecodificar
            // 
            this.btnDecodificar.Location = new System.Drawing.Point(543, 211);
            this.btnDecodificar.Name = "btnDecodificar";
            this.btnDecodificar.Size = new System.Drawing.Size(165, 65);
            this.btnDecodificar.TabIndex = 9;
            this.btnDecodificar.Text = "Decodificar i Calcular";
            this.btnDecodificar.UseVisualStyleBackColor = true;
            // 
            // btnEnviar3
            // 
            this.btnEnviar3.Location = new System.Drawing.Point(543, 292);
            this.btnEnviar3.Name = "btnEnviar3";
            this.btnEnviar3.Size = new System.Drawing.Size(102, 50);
            this.btnEnviar3.TabIndex = 8;
            this.btnEnviar3.Text = "Enviar";
            this.btnEnviar3.UseVisualStyleBackColor = true;
            // 
            // btnGenerarFitxer
            // 
            this.btnGenerarFitxer.Location = new System.Drawing.Point(543, 126);
            this.btnGenerarFitxer.Name = "btnGenerarFitxer";
            this.btnGenerarFitxer.Size = new System.Drawing.Size(165, 79);
            this.btnGenerarFitxer.TabIndex = 7;
            this.btnGenerarFitxer.Text = "Generar Fitxer i Comprimir";
            this.btnGenerarFitxer.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1160, 498);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 25;
            this.listBox3.Location = new System.Drawing.Point(94, 126);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(361, 354);
            this.listBox3.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(417, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(514, 51);
            this.label7.TabIndex = 4;
            this.label7.Text = "ENVIANT MISSATGE VR";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabPage2.Controls.Add(this.btnDesencriptarPDF);
            this.tabPage2.Controls.Add(this.btnDesencriptarCred);
            this.tabPage2.Controls.Add(this.btnEnviar2);
            this.tabPage2.Controls.Add(this.button8);
            this.tabPage2.Controls.Add(this.listBox2);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1377, 572);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // btnDesencriptarPDF
            // 
            this.btnDesencriptarPDF.Location = new System.Drawing.Point(513, 209);
            this.btnDesencriptarPDF.Name = "btnDesencriptarPDF";
            this.btnDesencriptarPDF.Size = new System.Drawing.Size(166, 77);
            this.btnDesencriptarPDF.TabIndex = 10;
            this.btnDesencriptarPDF.Text = "Desencriptar PDF";
            this.btnDesencriptarPDF.UseVisualStyleBackColor = true;
            // 
            // btnDesencriptarCred
            // 
            this.btnDesencriptarCred.Location = new System.Drawing.Point(513, 126);
            this.btnDesencriptarCred.Name = "btnDesencriptarCred";
            this.btnDesencriptarCred.Size = new System.Drawing.Size(166, 77);
            this.btnDesencriptarCred.TabIndex = 9;
            this.btnDesencriptarCred.Text = "Desencriptar Credencials";
            this.btnDesencriptarCred.UseVisualStyleBackColor = true;
            // 
            // btnEnviar2
            // 
            this.btnEnviar2.Location = new System.Drawing.Point(513, 292);
            this.btnEnviar2.Name = "btnEnviar2";
            this.btnEnviar2.Size = new System.Drawing.Size(125, 47);
            this.btnEnviar2.TabIndex = 8;
            this.btnEnviar2.Text = "Enviar";
            this.btnEnviar2.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(1160, 498);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(122, 41);
            this.button8.TabIndex = 7;
            this.button8.Text = "Next";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 25;
            this.listBox2.Location = new System.Drawing.Point(94, 126);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(361, 354);
            this.listBox2.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(417, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(514, 51);
            this.label6.TabIndex = 5;
            this.label6.Text = "ENVIANT MISSATGE VR";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabPage1.Controls.Add(this.btnEnviar);
            this.tabPage1.Controls.Add(this.button7);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1377, 572);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(606, 129);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(111, 39);
            this.btnEnviar.TabIndex = 7;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1160, 498);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(122, 41);
            this.button7.TabIndex = 6;
            this.button7.Text = "Next";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(177, 129);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(361, 354);
            this.listBox1.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(417, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(514, 51);
            this.label5.TabIndex = 4;
            this.label5.Text = "ENVIANT MISSATGE VR";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(4, 508);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1393, 619);
            this.tabControl1.TabIndex = 0;
            // 
            // frmPlanet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1399, 1170);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flpFrms);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPlanet";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmPlanet_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.FlowLayoutPanel flpFrms;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnNewDelivery;
        private System.Windows.Forms.Button btnGenerateKeys;
        private System.Windows.Forms.Button btnGenerateCodes;
        private System.Windows.Forms.Button lblListen;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnDesencriptarPDF;
        private System.Windows.Forms.Button btnDesencriptarCred;
        private System.Windows.Forms.Button btnEnviar2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnDecodificar;
        private System.Windows.Forms.Button btnEnviar3;
        private System.Windows.Forms.Button btnGenerarFitxer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnEnviar4;
        private System.Windows.Forms.Button btnComprovar;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.Label label8;
    }
}

