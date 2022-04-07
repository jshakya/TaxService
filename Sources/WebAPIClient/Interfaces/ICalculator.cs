namespace WebApiClient
{
    interface ICalculator
    {
        void CalculateSalesTaxForOrder(string to_country, float shipping);
        void GetTaxRate(string zip);
    }
}