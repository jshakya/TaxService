namespace WebApiClient
{
    interface IService
    {
        TaxRate GetTaxRate(string zip);

        float CalculateSalesTaxForOrder(string to_country, float shipping);
    }
}