using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        VAT_Validation.NeedsNip needsNip;

        [SetUp]
        public void Setup()
        {
        }
        //test for Eight character
        [Test]
        public void EightChar1()
        {
            string code = "DK";
            string vat = "12345678";
            needsNip = new VAT_Validation.NeedsNip(code, vat);
            Assert.AreEqual(needsNip.error, true);
        }

        [Test]
        public void EightChar2()
        {
            string code = "DK";
            string vat = "1234567891";
            needsNip = new VAT_Validation.NeedsNip(code, vat);
            Assert.AreEqual(needsNip.error, false);
        }

        [Test]
        public void EightChar3()
        {
            string code = "HU";
            string vat = "1234567A";
            needsNip = new VAT_Validation.NeedsNip(code, vat);
            Assert.AreEqual(needsNip.error, false);
        }

        [Test]
        public void EightChar4()
        {
            string code = "MT";
            string vat = "AAAAAAAAA";
            needsNip = new VAT_Validation.NeedsNip(code, vat);
            Assert.AreEqual(needsNip.error, false);
        }

        //test for nine character
        [Test]
        public void NineChar1()
        {
            string code = "GB";
            string vat = "123456789";
            needsNip = new VAT_Validation.NeedsNip(code, vat);
            Assert.AreEqual(needsNip.error, true);
        }

        [Test]
        public void NineChar2()
        {
            string code = "DE";
            string vat = "1234567891";
            needsNip = new VAT_Validation.NeedsNip(code, vat);
            Assert.AreEqual(needsNip.error, false);
        }

        [Test]
        public void NineChar3()
        {
            string code = "PT";
            string vat = "1234567A";
            needsNip = new VAT_Validation.NeedsNip(code, vat);
            Assert.AreEqual(needsNip.error, false);
        }

        [Test]
        public void NineChar4()
        {
            string code = "EL";
            string vat = "1234567";
            needsNip = new VAT_Validation.NeedsNip(code, vat);
            Assert.AreEqual(needsNip.error, false);
        }

        //test for ten character
        [Test]
        public void TenChar1()
        {
            string code = "PL";
            string vat = "1234567891";
            needsNip = new VAT_Validation.NeedsNip(code, vat);
            Assert.AreEqual(needsNip.error, true);
        }
        [Test]
        public void TenChar2()
        {
            string code = "PL";
            string vat = "123456789";
            needsNip = new VAT_Validation.NeedsNip(code, vat);
            Assert.AreEqual(needsNip.error, false);
        }
        [Test]
        public void TenChar3()
        {
            string code = "RO";
            string vat = "12345678A1";
            needsNip = new VAT_Validation.NeedsNip(code, vat);
            Assert.AreEqual(needsNip.error, false);
        }
        [Test]
        public void TenChar4()
        {
            string code = "PL";
            string vat = "1234567ABC";
            needsNip = new VAT_Validation.NeedsNip(code, vat);
            Assert.AreEqual(needsNip.error, false);
        }

        //test for eleven character
        [Test]
        public void ElevenChar1()
        {
            string code = "HR";
            string vat = "12345678910";
            needsNip = new VAT_Validation.NeedsNip(code, vat);
            Assert.AreEqual(needsNip.error, true);
        }
        [Test]
        public void ElevenChar2()
        {
            string code = "LV";
            string vat = "126789";
            needsNip = new VAT_Validation.NeedsNip(code, vat);
            Assert.AreEqual(needsNip.error, false);
        }
        [Test]
        public void ElevenChar3()
        {
            string code = "IT";
            string vat = "12345678AAA";
            needsNip = new VAT_Validation.NeedsNip(code, vat);
            Assert.AreEqual(needsNip.error, false);
        }
        [Test]
        public void ElevenChar4()
        {
            string code = "IT";
            string vat = "123456789101";
            needsNip = new VAT_Validation.NeedsNip(code, vat);
            Assert.AreEqual(needsNip.error, false);
        }


        // Test for Sweden Vat number
        [Test]
        public void SweChar1()
        {
            string code = "SE";
            string vat = "123456789101";
            needsNip = new VAT_Validation.NeedsNip(code, vat);
            Assert.AreEqual(needsNip.error, true);
        }

        [Test]
        public void SweChar2()
        {
            string code = "SE";
            string vat = "12345678910";
            needsNip = new VAT_Validation.NeedsNip(code, vat);
            Assert.AreEqual(needsNip.error, false);
        }

        [Test]
        public void SweChar3()
        {
            string code = "SE";
            string vat = "1234567891AA";
            needsNip = new VAT_Validation.NeedsNip(code, vat);
            Assert.AreEqual(needsNip.error, false);
        }

        //Test for French VAT number
        [Test]
        public void FrChar1()
        {
            string code = "FR";
            string vat = "12345678901";
            needsNip = new VAT_Validation.NeedsNip(code, vat);
            Assert.AreEqual(needsNip.error, true);
        }
        [Test]
        public void FrChar2()
        {
            string code = "FR";
            string vat = "X1234567890";
            needsNip = new VAT_Validation.NeedsNip(code, vat);
            Assert.AreEqual(needsNip.error, true);
        }
        [Test]
        public void FrChar3()
        {
            string code = "FR";
            string vat = "XX123456789";
            needsNip = new VAT_Validation.NeedsNip(code, vat);
            Assert.AreEqual(needsNip.error, true);
        }

        [Test]
        public void FrChar4()
        {
            string code = "FR";
            string vat = "XXXX23456789";
            needsNip = new VAT_Validation.NeedsNip(code, vat);
            Assert.AreEqual(needsNip.error, false);
        }
        //Test for Netherlands VAT number
        [Test]
        public void NlChar1()
        {
            string code = "NL";
            string vat = "123456789B12";
            needsNip = new VAT_Validation.NeedsNip(code, vat);
            Assert.AreEqual(needsNip.error, true);
        }
        [Test]
        public void NlChar2()
        {
            string code = "NL";
            string vat = "123456789B132";
            needsNip = new VAT_Validation.NeedsNip(code, vat);
            Assert.AreEqual(needsNip.error, false);
        }
        [Test]
        public void NlChar3()
        {
            string code = "NL";
            string vat = "XX123456789";
            needsNip = new VAT_Validation.NeedsNip(code, vat);
            Assert.AreEqual(needsNip.error, false);
        }

        [Test]
        public void NlChar4()
        {
            string code = "NL";
            string vat = "XXXX23456BB789";
            needsNip = new VAT_Validation.NeedsNip(code, vat);
            Assert.AreEqual(needsNip.error, false);
        }

        //Test for Ireland VAT number
        [Test]
        public void IeChar1()
        {
            string code = "IE";
            string vat = "1234567WA";
            needsNip = new VAT_Validation.NeedsNip(code, vat);
            Assert.AreEqual(needsNip.error, true);
        }
        [Test]
        public void IeChar2()
        {
            string code = "IE";
            string vat = "1234567FA";
            needsNip = new VAT_Validation.NeedsNip(code, vat);
            Assert.AreEqual(needsNip.error, true);
        }
        [Test]
        public void IeChar3()
        {
            string code = "IE";
            string vat = "1234567WA1";
            needsNip = new VAT_Validation.NeedsNip(code, vat);
            Assert.AreEqual(needsNip.error, false);
        }

        [Test]
        public void IeChar4()
        {
            string code = "IE";
            string vat = "1234567FAAA";
            needsNip = new VAT_Validation.NeedsNip(code, vat);
            Assert.AreEqual(needsNip.error, false);
        }

        //Test for Czech Republic VAT number
        [Test]
        public void CzChar1()
        {
            string code = "CZ";
            string vat = "1234567";
            needsNip = new VAT_Validation.NeedsNip(code, vat);
            Assert.AreEqual(needsNip.error, false);
        }
        [Test]
        public void CzChar2()
        {
            string code = "CZ";
            string vat = "1234567FA";
            needsNip = new VAT_Validation.NeedsNip(code, vat);
            Assert.AreEqual(needsNip.error, false);
        }
        [Test]
        public void CzChar3()
        {
            string code = "CZ";
            string vat = "12345671";
            needsNip = new VAT_Validation.NeedsNip(code, vat);
            Assert.AreEqual(needsNip.error, true);
        }

        [Test]
        public void CzChar4()
        {
            string code = "CZ";
            string vat = "123456712";
            needsNip = new VAT_Validation.NeedsNip(code, vat);
            Assert.AreEqual(needsNip.error, true);
        }

        //Test for Austria VAT number
        [Test]
        public void AtChar1()
        {
            string code = "AT";
            string vat = "U12345678";
            needsNip = new VAT_Validation.NeedsNip(code, vat);
            Assert.AreEqual(needsNip.error, true);
        }
        [Test]
        public void AtChar2()
        {
            string code = "AT";
            string vat = "U123456789";
            needsNip = new VAT_Validation.NeedsNip(code, vat);
            Assert.AreEqual(needsNip.error, false);
        }
        [Test]
        public void AtChar3()
        {
            string code = "AT";
            string vat = "123456789";
            needsNip = new VAT_Validation.NeedsNip(code, vat);
            Assert.AreEqual(needsNip.error, false);
        }

        [Test]
        public void AtChar4()
        {
            string code = "AT";
            string vat = "UU123456789";
            needsNip = new VAT_Validation.NeedsNip(code, vat);
            Assert.AreEqual(needsNip.error, false);
        }

        //Test for Spain VAT number
        [Test]
        public void EsChar1()
        {
            string code = "ES";
            string vat = "X1234567X";
            needsNip = new VAT_Validation.NeedsNip(code, vat);
            Assert.AreEqual(needsNip.error, true);
        }
        [Test]
        public void EsChar2()
        {
            string code = "ES";
            string vat = "X12345678";
            needsNip = new VAT_Validation.NeedsNip(code, vat);
            Assert.AreEqual(needsNip.error, true);
        }
        [Test]
        public void EsChar3()
        {
            string code = "ES";
            string vat = "12345678X";
            needsNip = new VAT_Validation.NeedsNip(code, vat);
            Assert.AreEqual(needsNip.error, true);
        }

        [Test]
        public void EsChar4()
        {
            string code = "ES";
            string vat = "12345678XX";
            needsNip = new VAT_Validation.NeedsNip(code, vat);
            Assert.AreEqual(needsNip.error, false);
        }

        //Test for Norway VAT number
        [Test]
        public void NoChar1()
        {
            string code = "NO";
            string vat = "123456789MVA";
            needsNip = new VAT_Validation.NeedsNip(code, vat);
            Assert.AreEqual(needsNip.error, true);
        }
        [Test]
        public void NoChar2()
        {
            string code = "NO";
            string vat = "12345679MVAA";
            needsNip = new VAT_Validation.NeedsNip(code, vat);
            Assert.AreEqual(needsNip.error, false);
        }
        [Test]
        public void NoChar3()
        {
            string code = "NO";
            string vat = "1234567891MVA";
            needsNip = new VAT_Validation.NeedsNip(code, vat);
            Assert.AreEqual(needsNip.error, false);
        }

        //Test for Switzerland VAT number
        [Test]
        public void ChChar1()
        {
            string code = "CH";
            string vat = "123456789MWST";
            needsNip = new VAT_Validation.NeedsNip(code, vat);
            Assert.AreEqual(needsNip.error, true);
        }
        [Test]
        public void ChChar2()
        {
            string code = "CH";
            string vat = "123456789TVA";
            needsNip = new VAT_Validation.NeedsNip(code, vat);
            Assert.AreEqual(needsNip.error, true);
        }
        [Test]
        public void ChChar3()
        {
            string code = "CH";
            string vat = "1234567891MVA";
            needsNip = new VAT_Validation.NeedsNip(code, vat);
            Assert.AreEqual(needsNip.error, false);
        }

        //Test for Switzerland VAT number
        [Test]
        public void BgChar1()
        {
            string code = "BG";
            string vat = "123456789";
            needsNip = new VAT_Validation.NeedsNip(code, vat);
            Assert.AreEqual(needsNip.error, true);
        }
        [Test]
        public void BgChar2()
        {
            string code = "BG";
            string vat = "1234567891";
            needsNip = new VAT_Validation.NeedsNip(code, vat);
            Assert.AreEqual(needsNip.error, true);
        }
        [Test]
        public void BgChar3()
        {
            string code = "BG";
            string vat = "1234567891MVA";
            needsNip = new VAT_Validation.NeedsNip(code, vat);
            Assert.AreEqual(needsNip.error, false);
        }

        [Test]
        public void BgChar4()
        {
            string code = "BG";
            string vat = "123456789111";
            needsNip = new VAT_Validation.NeedsNip(code, vat);
            Assert.AreEqual(needsNip.error, false);
        }

        //Test for Lithuania VAT number
        [Test]
        public void LtChar1()
        {
            string code = "LT";
            string vat = "123456789";
            needsNip = new VAT_Validation.NeedsNip(code, vat);
            Assert.AreEqual(needsNip.error, true);
        }
        [Test]
        public void LtChar2()
        {
            string code = "LT";
            string vat = "1234567891";
            needsNip = new VAT_Validation.NeedsNip(code, vat);
            Assert.AreEqual(needsNip.error, true);
        }
        [Test]
        public void LtChar3()
        {
            string code = "LT";
            string vat = "1234567891MVA";
            needsNip = new VAT_Validation.NeedsNip(code, vat);
            Assert.AreEqual(needsNip.error, false);
        }

        [Test]
        public void LtChar4()
        {
            string code = "LT";
            string vat = "123456789111";
            needsNip = new VAT_Validation.NeedsNip(code, vat);
            Assert.AreEqual(needsNip.error, true);
        }

    }
}
