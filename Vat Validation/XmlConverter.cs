using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Linq;

namespace VAT_Validation
{
    class XmlConverter
    {
        private string pathXml;
        public bool save;

        public XmlConverter(List<string> list)
        {
            ChooseLocation();
            save=CreateXml(list,pathXml);
        }


        private string ChooseLocation()
        {
            SaveFileDialog saveFile = new SaveFileDialog
            {
                Title = "Wybierz miejsce zapisu pliku",
                DefaultExt = "xml",
                Filter = "xml file(*.xml)|*.xml",
                RestoreDirectory = true
            };
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                pathXml = saveFile.FileName;
            }

            return pathXml;
        }

        private bool CreateXml(List<string> list,string path)
        {
            XDocument document =new XDocument(
                new XElement("Data",
                    new XElement("CompanyData",
                        new XElement("CodeCountry", list[0]),
                        new XElement("VatNumber", list[1]),
                        new XElement("ComapnyName",list[2]),
                        new XElement("ComapnyType", list[3]),
                        new XElement("Address", list[4])
                        ),
                    new XElement("CompanyRequest",
                        new XElement("RequestCodeCountry",list[5]),
                        new XElement("RequestVatNumber",list[6]),
                        new XElement("requestIdentifier",list[7])
                        ),
                    new XElement("valid",list[8]=="Dane poprawne"?true:false)
                ));
            try
            {
                document.Save(path);
                return true;
            }
            catch (Exception)
            {
                throw new Exception();
            }   
            
        }
    }
}
