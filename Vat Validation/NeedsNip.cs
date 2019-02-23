using System;
using System.Text.RegularExpressions;


namespace VAT_Validation
{
    // Enums are in Enum.cs

    // Class validation input value of textbox
    public class NeedsNip
    {
        public bool error=true;
        private Regex req;
        private string[] eleven = new string[] { "HR", "IT", "LV" };

        public NeedsNip(string code,string nip)
        {
            if(Enum.IsDefined(typeof(Eight),code))
            {
                EightChar(nip);
            }
            if (Enum.IsDefined(typeof(Nine), code))
            {
                NineChar(nip);
            }
            else if (Enum.IsDefined(typeof(Ten), code))
            {
                TenChar(nip);
            }
            else if (Enum.IsDefined(typeof(Eleven), code))
            {
                ElevenChar(nip);
            }
            else
            {
                switch (code)
                {
                    case "SE":
                        SweChar(nip);
                        break;
                    case "FR":
                         FrChar(nip);
                        break;
                    case "NL":
                        NlChar(nip);
                        break;
                    case "IE":
                        IeChar(nip);
                        break;
                    case "CZ":
                        CzChar(nip);
                        break;
                    case "AT":
                        AtChar(nip);
                        break;
                    case "ES":
                        EsChar(nip);
                        break;
                    case "CY":
                        CyChar(nip);
                        break;
                    case "NO":
                        NoChar(nip);
                        break;
                    case "CH":
                        ChChar(nip);
                        break;
                    case "BG":
                        BgChar(nip);
                        break;
                    case "LT":
                        LtChar(nip);
                        break;
                    default:
                        break;
                }
                
            }
        }
        private void EightChar(string checkresult)
        {
            req = new Regex(@"^[0-9]{8}$");
            error= req.IsMatch(checkresult);
        }

        private void NineChar(string checkresult)
        {
            req = new Regex(@"^[0-9]{9}$");
            error = req.IsMatch(checkresult);
        }

        private void TenChar(string checkresult)
        {
            req = new Regex(@"^[0-9]{10}$");          
            error=req.IsMatch(checkresult);
        }     
        private void ElevenChar(string checkresult)
        {
            req = new Regex(@"^[0-9]{11}$");
            error = req.IsMatch(checkresult);
        }
        private void SweChar(string checkresult)
        {
            req = new Regex(@"^[0-9]{12}$");
            error = req.IsMatch(checkresult);
        }
        private void FrChar(string checkresult)
        {
            req = new Regex(@"^[0-9]{11}$|^[A-Z]{1}[0-9]{10}$|^[A-Z]{2}[0-9]{9}$|^[A-Z]{3}[0-9]{8}$");
            error = req.IsMatch(checkresult);
        }

        private void NlChar(string checkresult)
        {
            req = new Regex(@"^[0-9]{9}[B]{1}[0-9]{2}$");
            error = req.IsMatch(checkresult);
        }
        private void IeChar(string checkresult)
        {
            req = new Regex(@"^[0-9]{7}[A-Z]{2}$|^[0-9]{7}[A-Z]{1,2}$");
            error = req.IsMatch(checkresult);
        }
        private void CzChar(string checkresult)
        {
            req = new Regex(@"^[0-9]{8,}$");
            error = req.IsMatch(checkresult);
        }

        private void AtChar(string checkresult)
        {
            req = new Regex(@"^[U]{1}[0-9]{8}$");
            error = req.IsMatch(checkresult);
        }

        private void EsChar(string checkresult)
        {
            req = new Regex(@"^[A-Z]{1}[0-9]{8}$|^[A-Z]{1}[0-9]{7}[A-Z]{1}$|^[0-9]{8}[A-Z]{1}$");
            error = req.IsMatch(checkresult);
        }

        private void CyChar(string checkresult)
        {
            req = new Regex(@"^[0-9]{8}[A-Z]{1}$");
            error = req.IsMatch(checkresult);
        }

        private void NoChar(string checkresult)
        {
            req = new Regex(@"^[0-9]{9}[M]{1}[V]{1}[A]{1}$");
            error = req.IsMatch(checkresult);
        }
        private void ChChar(string checkresult)
        {
            req = new Regex(@"^[0-9]{9}[M]{1}[W]{1}[S]{1}[T]{1}$|^[0-9]{9}[T]{1}[V]{1}[A]{1}$|^[0-9]{9}[I]{1}[V]{1}[A]{1}$");
            error = req.IsMatch(checkresult);
        }

        private void BgChar(string checkresult)
        {
            req = new Regex(@"^[0-9]{9,10}$");
            error = req.IsMatch(checkresult);
        }

        private void LtChar(string checkresult)
        {
            req = new Regex(@"^[0-9]{9,12}$");
            error = req.IsMatch(checkresult);
        }
    }
}

