using System.Text.RegularExpressions;

namespace VideoClubManagement.Helpers
{
    /// <summary>
    /// Code made by professor Juan Valdez Reyes
    /// </summary>
    public static class ValidatorHelper
    {
        public static bool IsAValidIdentityDocument(string identityDocument)
        {
            int totalVerifier = 0;
            identityDocument = identityDocument.Replace("-", "");
            int identityDocumentLength = identityDocument.Trim().Length;
            int[] multiplierDigits = new int[11] { 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1 };

            if (identityDocumentLength < 11 || identityDocumentLength > 11)
                return false;

            for (int digitVerifier = 1; digitVerifier <= identityDocumentLength; digitVerifier++)
            {
                int verifierCalculation = int.Parse(identityDocument.Substring(digitVerifier - 1, 1)) * multiplierDigits[digitVerifier - 1];
                if (verifierCalculation < 10)
                    totalVerifier += verifierCalculation;
                else
                    totalVerifier += int.Parse(verifierCalculation.ToString().Substring(0, 1)) + int.Parse(verifierCalculation.ToString().Substring(1, 1));
            }

            if (totalVerifier % 10 == 0)
                return true;
            else
                return false;
        }

        public static bool IsAValidJuridicTaxpayerIdentificationNumber(string juridicTaxpayerIdentificationNumber)
        {
            int totalVerifier = 0;

            int[] multiplierDigits = new int[8] { 7, 9, 8, 6, 5, 4, 3, 2 };

            juridicTaxpayerIdentificationNumber = juridicTaxpayerIdentificationNumber.Replace("-", "").Replace(" ", "");

            string digitVerifier = juridicTaxpayerIdentificationNumber.Substring(8, 1);

            if (juridicTaxpayerIdentificationNumber.Length.Equals(9))
                if (!"145".Contains(juridicTaxpayerIdentificationNumber.Substring(0, 1)))
                    return false;

            for (int digitToVerify = 1; digitToVerify <= 8; digitToVerify++)
            {
                int verifierCalculation = int.Parse(juridicTaxpayerIdentificationNumber.Substring(digitToVerify - 1, 1)) * multiplierDigits[digitToVerify - 1];
                totalVerifier += verifierCalculation;
            }

            if (totalVerifier % 11 == 0 && digitVerifier == "1" || totalVerifier % 11 == 1 && digitVerifier == "1" || (11 - (totalVerifier % 11)).Equals(digitVerifier))
                return true;
            else
                return false;
        }

        public static bool IsValidEmail(string email) =>
            Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", 
                RegexOptions.IgnoreCase);
    }
}
