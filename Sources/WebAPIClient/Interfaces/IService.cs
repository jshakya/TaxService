namespace WebApiClient
{
    interface IService
    {
        TaxRateAttributes GetTaxRate(string zip);

        float CalculateSalesTaxForOrder(string to_country, float shipping);
    }
}