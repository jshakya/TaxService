namespace WebApiClient
{
    interface IService
    {
        RateAttributes GetTaxRate(string zip);

        float CalculateSalesTaxForOrder(string to_country, float shipping);
    }
}