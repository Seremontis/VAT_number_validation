namespace VAT_Validation
{
    partial class WinCheck
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.gboxinput = new System.Windows.Forms.GroupBox();
            this.labLegend = new System.Windows.Forms.Label();
            this.cbox = new System.Windows.Forms.CheckBox();
            this.CheckValue = new System.Windows.Forms.Button();
            this.txtReqNIP = new VAT_Validation.TextBox1();
            this.txtReqCode = new VAT_Validation.TextBox1();
            this.txtNIP = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.labNipReq = new System.Windows.Forms.Label();
            this.labCodeReq = new System.Windows.Forms.Label();
            this.labNip = new System.Windows.Forms.Label();
            this.labCode = new System.Windows.Forms.Label();
            this.gboxOutput = new System.Windows.Forms.GroupBox();
            this.labLine = new System.Windows.Forms.Label();
            this.butConvert = new System.Windows.Forms.Button();
            this.labReqKey = new System.Windows.Forms.Label();
            this.labReqNIPOut = new System.Windows.Forms.Label();
            this.labReqCodeOut = new System.Windows.Forms.Label();
            this.txtCodeOut = new System.Windows.Forms.TextBox();
            this.txtNIPOut = new System.Windows.Forms.TextBox();
            this.txtNameCompany = new System.Windows.Forms.TextBox();
            this.txtTypeCompany = new System.Windows.Forms.TextBox();
            this.txtAddressCompany = new System.Windows.Forms.TextBox();
            this.txtReqCodeOut = new System.Windows.Forms.TextBox();
            this.txtReqNIPOut = new System.Windows.Forms.TextBox();
            this.txtidentified = new System.Windows.Forms.TextBox();
            this.txtvalid = new System.Windows.Forms.TextBox();
            this.labValidData = new System.Windows.Forms.Label();
            this.labTypeCompany = new System.Windows.Forms.Label();
            this.labAddressComapany = new System.Windows.Forms.Label();
            this.labNameCompany = new System.Windows.Forms.Label();
            this.labNipOut = new System.Windows.Forms.Label();
            this.labCodeOut = new System.Windows.Forms.Label();
            this.gboxinput.SuspendLayout();
            this.gboxOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxinput
            // 
            this.gboxinput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(105)))), ((int)(((byte)(140)))));
            this.gboxinput.Controls.Add(this.labLegend);
            this.gboxinput.Controls.Add(this.cbox);
            this.gboxinput.Controls.Add(this.CheckValue);
            this.gboxinput.Controls.Add(this.txtReqNIP);
            this.gboxinput.Controls.Add(this.txtReqCode);
            this.gboxinput.Controls.Add(this.txtNIP);
            this.gboxinput.Controls.Add(this.txtCode);
            this.gboxinput.Controls.Add(this.labNipReq);
            this.gboxinput.Controls.Add(this.labCodeReq);
            this.gboxinput.Controls.Add(this.labNip);
            this.gboxinput.Controls.Add(this.labCode);
            this.gboxinput.ForeColor = System.Drawing.Color.Black;
            this.gboxinput.Location = new System.Drawing.Point(50, 33);
            this.gboxinput.Name = "gboxinput";
            this.gboxinput.Size = new System.Drawing.Size(360, 350);
            this.gboxinput.TabIndex = 0;
            this.gboxinput.TabStop = false;
            this.gboxinput.Text = "Dane wejściowe";
            // 
            // labLegend
            // 
            this.labLegend.AutoSize = true;
            this.labLegend.Location = new System.Drawing.Point(47, 314);
            this.labLegend.Name = "labLegend";
            this.labLegend.Size = new System.Drawing.Size(0, 14);
            this.labLegend.TabIndex = 11;
            // 
            // cbox
            // 
            this.cbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(105)))), ((int)(((byte)(140)))));
            this.cbox.Location = new System.Drawing.Point(109, 140);
            this.cbox.Name = "cbox";
            this.cbox.Size = new System.Drawing.Size(118, 18);
            this.cbox.TabIndex = 10;
            this.cbox.Text = "CheckVatApprox";
            this.cbox.UseVisualStyleBackColor = false;
            this.cbox.CheckedChanged += new System.EventHandler(this.Cbox_CheckedChanged);
            // 
            // CheckValue
            // 
            this.CheckValue.Location = new System.Drawing.Point(50, 280);
            this.CheckValue.Name = "CheckValue";
            this.CheckValue.Size = new System.Drawing.Size(265, 25);
            this.CheckValue.TabIndex = 8;
            this.CheckValue.Text = "Sprawdź";
            this.CheckValue.UseVisualStyleBackColor = true;
            this.CheckValue.Click += new System.EventHandler(this.CheckValue_Click);
            // 
            // txtReqNIP
            // 
            this.txtReqNIP.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtReqNIP.Location = new System.Drawing.Point(198, 230);
            this.txtReqNIP.Name = "txtReqNIP";
            this.txtReqNIP.Size = new System.Drawing.Size(116, 20);
            this.txtReqNIP.TabIndex = 7;
            this.txtReqNIP.Leave += new System.EventHandler(this.NipFous);
            // 
            // txtReqCode
            // 
            this.txtReqCode.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtReqCode.Location = new System.Drawing.Point(198, 180);
            this.txtReqCode.Name = "txtReqCode";
            this.txtReqCode.Size = new System.Drawing.Size(116, 20);
            this.txtReqCode.TabIndex = 6;
            this.txtReqCode.Leave += new System.EventHandler(this.Codefocus);
            // 
            // txtNIP
            // 
            this.txtNIP.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNIP.Location = new System.Drawing.Point(198, 100);
            this.txtNIP.Name = "txtNIP";
            this.txtNIP.Size = new System.Drawing.Size(116, 20);
            this.txtNIP.TabIndex = 5;
            this.txtNIP.Leave += new System.EventHandler(this.NipFous);
            // 
            // txtCode
            // 
            this.txtCode.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCode.Location = new System.Drawing.Point(198, 50);
            this.txtCode.MaxLength = 2;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(116, 20);
            this.txtCode.TabIndex = 4;
            this.txtCode.Leave += new System.EventHandler(this.Codefocus);
            // 
            // labNipReq
            // 
            this.labNipReq.AutoSize = true;
            this.labNipReq.Location = new System.Drawing.Point(47, 230);
            this.labNipReq.Name = "labNipReq";
            this.labNipReq.Size = new System.Drawing.Size(111, 14);
            this.labNipReq.TabIndex = 3;
            this.labNipReq.Text = "NIP wnioskującego";
            // 
            // labCodeReq
            // 
            this.labCodeReq.Location = new System.Drawing.Point(47, 180);
            this.labCodeReq.Name = "labCodeReq";
            this.labCodeReq.Size = new System.Drawing.Size(145, 14);
            this.labCodeReq.TabIndex = 2;
            this.labCodeReq.Text = "Kod kraju wnioskodawcy";
            // 
            // labNip
            // 
            this.labNip.AutoSize = true;
            this.labNip.Location = new System.Drawing.Point(47, 100);
            this.labNip.Name = "labNip";
            this.labNip.Size = new System.Drawing.Size(24, 14);
            this.labNip.TabIndex = 1;
            this.labNip.Text = "NIP";
            // 
            // labCode
            // 
            this.labCode.AutoSize = true;
            this.labCode.Location = new System.Drawing.Point(47, 50);
            this.labCode.Name = "labCode";
            this.labCode.Size = new System.Drawing.Size(59, 14);
            this.labCode.TabIndex = 0;
            this.labCode.Text = "Kod kraju";
            // 
            // gboxOutput
            // 
            this.gboxOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(105)))), ((int)(((byte)(140)))));
            this.gboxOutput.Controls.Add(this.labLine);
            this.gboxOutput.Controls.Add(this.butConvert);
            this.gboxOutput.Controls.Add(this.labReqKey);
            this.gboxOutput.Controls.Add(this.labReqNIPOut);
            this.gboxOutput.Controls.Add(this.labReqCodeOut);
            this.gboxOutput.Controls.Add(this.txtCodeOut);
            this.gboxOutput.Controls.Add(this.txtNIPOut);
            this.gboxOutput.Controls.Add(this.txtNameCompany);
            this.gboxOutput.Controls.Add(this.txtTypeCompany);
            this.gboxOutput.Controls.Add(this.txtAddressCompany);
            this.gboxOutput.Controls.Add(this.txtReqCodeOut);
            this.gboxOutput.Controls.Add(this.txtReqNIPOut);
            this.gboxOutput.Controls.Add(this.txtidentified);
            this.gboxOutput.Controls.Add(this.txtvalid);
            this.gboxOutput.Controls.Add(this.labValidData);
            this.gboxOutput.Controls.Add(this.labTypeCompany);
            this.gboxOutput.Controls.Add(this.labAddressComapany);
            this.gboxOutput.Controls.Add(this.labNameCompany);
            this.gboxOutput.Controls.Add(this.labNipOut);
            this.gboxOutput.Controls.Add(this.labCodeOut);
            this.gboxOutput.ForeColor = System.Drawing.Color.Black;
            this.gboxOutput.Location = new System.Drawing.Point(453, 33);
            this.gboxOutput.Name = "gboxOutput";
            this.gboxOutput.Size = new System.Drawing.Size(463, 350);
            this.gboxOutput.TabIndex = 1;
            this.gboxOutput.TabStop = false;
            this.gboxOutput.Text = "Dane wyjściowe";
            // 
            // labLine
            // 
            this.labLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labLine.Location = new System.Drawing.Point(10, 172);
            this.labLine.Name = "labLine";
            this.labLine.Size = new System.Drawing.Size(445, 2);
            this.labLine.TabIndex = 22;
            // 
            // butConvert
            // 
            this.butConvert.Location = new System.Drawing.Point(150, 280);
            this.butConvert.Name = "butConvert";
            this.butConvert.Size = new System.Drawing.Size(169, 25);
            this.butConvert.TabIndex = 21;
            this.butConvert.Text = "Przekonwertuj do XML";
            this.butConvert.UseVisualStyleBackColor = true;
            this.butConvert.Click += new System.EventHandler(this.ButConvert_Click);
            // 
            // labReqKey
            // 
            this.labReqKey.Location = new System.Drawing.Point(40, 181);
            this.labReqKey.Name = "labReqKey";
            this.labReqKey.Size = new System.Drawing.Size(174, 14);
            this.labReqKey.TabIndex = 20;
            this.labReqKey.Text = "Identifikator zapytania";
            this.labReqKey.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labReqNIPOut
            // 
            this.labReqNIPOut.Location = new System.Drawing.Point(250, 229);
            this.labReqNIPOut.Name = "labReqNIPOut";
            this.labReqNIPOut.Size = new System.Drawing.Size(174, 14);
            this.labReqNIPOut.TabIndex = 18;
            this.labReqNIPOut.Text = "NIP wnioskodawcy";
            this.labReqNIPOut.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labReqCodeOut
            // 
            this.labReqCodeOut.Location = new System.Drawing.Point(40, 229);
            this.labReqCodeOut.Name = "labReqCodeOut";
            this.labReqCodeOut.Size = new System.Drawing.Size(174, 14);
            this.labReqCodeOut.TabIndex = 17;
            this.labReqCodeOut.Text = "kod kraju wnioskodawcy";
            this.labReqCodeOut.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtCodeOut
            // 
            this.txtCodeOut.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCodeOut.Location = new System.Drawing.Point(40, 40);
            this.txtCodeOut.Name = "txtCodeOut";
            this.txtCodeOut.Size = new System.Drawing.Size(174, 20);
            this.txtCodeOut.TabIndex = 4;
            // 
            // txtNIPOut
            // 
            this.txtNIPOut.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNIPOut.Location = new System.Drawing.Point(250, 40);
            this.txtNIPOut.Name = "txtNIPOut";
            this.txtNIPOut.Size = new System.Drawing.Size(174, 20);
            this.txtNIPOut.TabIndex = 5;
            // 
            // txtNameCompany
            // 
            this.txtNameCompany.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNameCompany.Location = new System.Drawing.Point(40, 90);
            this.txtNameCompany.Name = "txtNameCompany";
            this.txtNameCompany.Size = new System.Drawing.Size(174, 20);
            this.txtNameCompany.TabIndex = 6;
            // 
            // txtTypeCompany
            // 
            this.txtTypeCompany.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTypeCompany.Location = new System.Drawing.Point(250, 90);
            this.txtTypeCompany.Name = "txtTypeCompany";
            this.txtTypeCompany.Size = new System.Drawing.Size(174, 20);
            this.txtTypeCompany.TabIndex = 10;
            // 
            // txtAddressCompany
            // 
            this.txtAddressCompany.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtAddressCompany.Location = new System.Drawing.Point(40, 140);
            this.txtAddressCompany.Name = "txtAddressCompany";
            this.txtAddressCompany.Size = new System.Drawing.Size(384, 20);
            this.txtAddressCompany.TabIndex = 7;
            // 
            // txtReqCodeOut
            // 
            this.txtReqCodeOut.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtReqCodeOut.Location = new System.Drawing.Point(40, 247);
            this.txtReqCodeOut.Name = "txtReqCodeOut";
            this.txtReqCodeOut.Size = new System.Drawing.Size(174, 20);
            this.txtReqCodeOut.TabIndex = 15;
            // 
            // txtReqNIPOut
            // 
            this.txtReqNIPOut.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtReqNIPOut.Location = new System.Drawing.Point(250, 247);
            this.txtReqNIPOut.Name = "txtReqNIPOut";
            this.txtReqNIPOut.Size = new System.Drawing.Size(174, 20);
            this.txtReqNIPOut.TabIndex = 16;
            // 
            // txtidentified
            // 
            this.txtidentified.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtidentified.Location = new System.Drawing.Point(40, 197);
            this.txtidentified.Name = "txtidentified";
            this.txtidentified.Size = new System.Drawing.Size(174, 20);
            this.txtidentified.TabIndex = 19;
            // 
            // txtvalid
            // 
            this.txtvalid.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtvalid.Location = new System.Drawing.Point(250, 197);
            this.txtvalid.Name = "txtvalid";
            this.txtvalid.Size = new System.Drawing.Size(174, 20);
            this.txtvalid.TabIndex = 14;
            // 
            // labValidData
            // 
            this.labValidData.Location = new System.Drawing.Point(250, 181);
            this.labValidData.Name = "labValidData";
            this.labValidData.Size = new System.Drawing.Size(174, 14);
            this.labValidData.TabIndex = 13;
            this.labValidData.Text = "Popraność danych\r\n";
            this.labValidData.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labTypeCompany
            // 
            this.labTypeCompany.Location = new System.Drawing.Point(253, 73);
            this.labTypeCompany.Name = "labTypeCompany";
            this.labTypeCompany.Size = new System.Drawing.Size(171, 14);
            this.labTypeCompany.TabIndex = 9;
            this.labTypeCompany.Text = "Rodzaj Firmy";
            this.labTypeCompany.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labAddressComapany
            // 
            this.labAddressComapany.Location = new System.Drawing.Point(43, 123);
            this.labAddressComapany.Name = "labAddressComapany";
            this.labAddressComapany.Size = new System.Drawing.Size(381, 14);
            this.labAddressComapany.TabIndex = 3;
            this.labAddressComapany.Text = "Adres firmy";
            this.labAddressComapany.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labNameCompany
            // 
            this.labNameCompany.Location = new System.Drawing.Point(40, 73);
            this.labNameCompany.Name = "labNameCompany";
            this.labNameCompany.Size = new System.Drawing.Size(174, 14);
            this.labNameCompany.TabIndex = 2;
            this.labNameCompany.Text = "Nazwa Firmy";
            this.labNameCompany.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labNipOut
            // 
            this.labNipOut.Location = new System.Drawing.Point(250, 24);
            this.labNipOut.Name = "labNipOut";
            this.labNipOut.Size = new System.Drawing.Size(174, 14);
            this.labNipOut.TabIndex = 1;
            this.labNipOut.Text = "NIP";
            this.labNipOut.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labCodeOut
            // 
            this.labCodeOut.Location = new System.Drawing.Point(40, 24);
            this.labCodeOut.Name = "labCodeOut";
            this.labCodeOut.Size = new System.Drawing.Size(174, 14);
            this.labCodeOut.TabIndex = 0;
            this.labCodeOut.Text = "Kod kraju";
            this.labCodeOut.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // WinCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(100)))), ((int)(((byte)(186)))));
            this.ClientSize = new System.Drawing.Size(964, 436);
            this.Controls.Add(this.gboxOutput);
            this.Controls.Add(this.gboxinput);
            this.Font = new System.Drawing.Font("Broadway", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(68)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(231, 39);
            this.Name = "WinCheck";
            this.Text = "Aplikacja do weryfikacji NIP";
            this.Load += new System.EventHandler(this.WinCheck_Load);
            this.gboxinput.ResumeLayout(false);
            this.gboxinput.PerformLayout();
            this.gboxOutput.ResumeLayout(false);
            this.gboxOutput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxinput;
        private System.Windows.Forms.Label labNipReq;
        private System.Windows.Forms.Label labCodeReq;
        private System.Windows.Forms.Label labNip;
        private System.Windows.Forms.Label labCode;
        private System.Windows.Forms.Button CheckValue;
        private TextBox1 txtReqNIP;
        private TextBox1 txtReqCode;
        private System.Windows.Forms.TextBox txtNIP;
        private System.Windows.Forms.TextBox txtCode;

        private System.Windows.Forms.GroupBox gboxOutput;
        private System.Windows.Forms.TextBox txtCodeOut;
        private System.Windows.Forms.TextBox txtNIPOut;
        private System.Windows.Forms.TextBox txtNameCompany;      
        private System.Windows.Forms.TextBox txtTypeCompany;
        private System.Windows.Forms.TextBox txtAddressCompany;
        private System.Windows.Forms.TextBox txtvalid;
        private System.Windows.Forms.TextBox txtReqCodeOut;
        private System.Windows.Forms.TextBox txtReqNIPOut;     
        private System.Windows.Forms.TextBox txtidentified;

        private System.Windows.Forms.Label labAddressComapany;
        private System.Windows.Forms.Label labNameCompany;
        private System.Windows.Forms.Label labNipOut;
        private System.Windows.Forms.Label labCodeOut;     
        private System.Windows.Forms.Label labTypeCompany;
        private System.Windows.Forms.Label labValidData;
        private System.Windows.Forms.Label labReqNIPOut;
        private System.Windows.Forms.Label labReqCodeOut;
        private System.Windows.Forms.Button butConvert;
        private System.Windows.Forms.Label labLine;
        private System.Windows.Forms.Label labReqKey;
        private System.Windows.Forms.Label labLegend;
        private System.Windows.Forms.CheckBox cbox;
    }
}

