using System;

namespace VAT_Validation
{
    /// <summary>
    /// modified controls on forms(see all data of Vies)
    /// </summary>

    public class ViesConntection: IMethodConnect
    {
        public bool valid;
        // varchars to first and second method
        public string traderName, traderAddress;
        // varchars to second method
        public string traderCompanyType, traderStreet, traderPostcode, traderCity, requestIdentifier;
        private ViesServices.matchCode traderNameMatch, traderCompanyTypeMatch, traderStreetMatch, traderPostcodeMatch, traderCityMatch;
        private ViesServices.checkVatPortTypeClient checkVatPort;

        public string CheckVat(string code, string nip)
        {         
            try
            {
                checkVatPort = new ViesServices.checkVatPortTypeClient();
                checkVatPort.checkVat(ref code, ref nip,out valid,out traderName, out traderAddress);

                if (valid == true)
                    return "true";
                else
                    return "false";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

            
        }
        public string CheckVatApprox(string code, string nip, string reqCode, string reqNip)
        {
            try
            {
                checkVatPort = new ViesServices.checkVatPortTypeClient();
                checkVatPort.checkVatApprox(ref code, ref nip, ref traderName, ref traderCompanyType,
                                                    ref traderStreet, ref traderPostcode, ref traderCity, reqCode, reqNip, out valid,
                                                    out traderAddress, out traderNameMatch, out traderCompanyTypeMatch,
                                                    out traderStreetMatch, out traderPostcodeMatch, out traderCityMatch, out requestIdentifier);
                if (valid == true)
                    return "true";
                else
                    return "false";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }           
        }
    }
}
