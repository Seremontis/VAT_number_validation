
namespace VAT_Validation
{
    interface IMethodConnect
    {
        string CheckVat(string code,string nip);
        string CheckVatApprox(string code, string nip, string reqCode, string reqNip);
    }
}
