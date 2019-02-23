using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace VAT_Validation
{
    public partial class WinCheck : Form
    {
        private string defCode = "", defNip= "";
        private ViesConntection vies;
        private List<string> list;

        public WinCheck()
        {     
            InitializeComponent();
        }


        private void WinCheck_Load(object sender, EventArgs e)
        {
            labLegend.Text = "*nie zaznaczenie CheckVatApprox spowoduje \n  wykonanie metody CheckVat";
            txtReqCode.Text = defCode;
            txtReqNIP.Text = defNip;

            txtReqCode.Enabled = false;
            txtReqNIP.Enabled = false;
        }

        private void CheckValue_Click(object sender, EventArgs e)
        {          
            if (cbox.Checked)
                CheckVatApprox(txtCode.Text, txtNIP.Text, txtReqCode.Text, txtReqNIP.Text);
            else
                CheckVat(txtCode.Text, txtNIP.Text);
        }

        
        private void Cbox_CheckedChanged(object sender, EventArgs e)
        {
            if (cbox.Checked)
            {
                txtReqCode.Enabled = true;
                txtReqNIP.Enabled = true;
            }
            else
            {
                txtReqCode.Enabled = false;
                txtReqNIP.Enabled = false;
            }
        }
        private void CheckVat(string code, string nip)
        {
            vies = new ViesConntection();
            string command;
            switch ((command=vies.CheckVat(code, nip)))
            {
                case "true":
                    MessageBox.Show("Dane są poprawne");
                    break;
                case "false":
                    MessageBox.Show("Dane nie istnieją");
                    break;
                default:
                    MessageBox.Show(command);
                    break;
            }
                
        }

        private void ButConvert_Click(object sender, EventArgs e)
        {
            list = new List<string>();           
            foreach (Control item in gboxOutput.Controls)
            {
                if(item is TextBox)                
                    list.Add(item.Text);                           
            }
            XmlConverter converter = new XmlConverter(list);
            if (converter.save)
                MessageBox.Show("Plika zapisano");
            else
                MessageBox.Show("Nie zapisano pliku");
            
        }

        private void Codefocus(object sender, EventArgs e)
        {
            txtCode.Text = txtCode.Text.ToUpper();
        }

        private void NipFous(object sender, EventArgs e)
        {
            
            txtNIP.Text = txtNIP.Text.Replace(" ",string.Empty).Replace("-",string.Empty).Replace(".",string.Empty).ToUpper();
            if(txtNIP.Text!="" || txtNIP.Text == null)
            {       
                NeedsNip needs = new NeedsNip(txtCode.Text, txtNIP.Text);
                if (needs.error == false)
                    {
                        MessageBox.Show("Zły format NIP", "Zły format",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
            }
        }

        private void CheckVatApprox(string code, string nip,string reqCode,string reqNip)
        {
            vies = new ViesConntection();
            string command = vies.CheckVatApprox(code, nip, reqCode, reqNip);
                switch (command)
                {
                    case "true":
                        txtCodeOut.Text = code;
                        txtNIPOut.Text = nip;
                        txtNameCompany.Text = vies.traderName;
                        txtAddressCompany.Text = vies.traderAddress;
                        txtTypeCompany.Text = vies.traderCompanyType;
                        txtvalid.Text = vies.valid == true ? "Dane poprawne" : "Dane nieprawidłowe";
                        txtidentified.Text = vies.requestIdentifier;

                        txtReqCodeOut.Text = reqCode;
                        txtReqNIPOut.Text = reqNip;
                        break;
                case "false":
                    MessageBox.Show("Dane nie istnieją");
                    break;
                default:
                    MessageBox.Show(command);
                    break;         
            }
        }
    }
}
