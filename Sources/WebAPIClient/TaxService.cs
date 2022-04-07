namespace WebApiClient
{
    class TaxService: IService
    {
        private ICalculator _calculator;
        public TaxService(ICalculator calculator)
        {
            _calculator = calculator;
        }

        public float CalculateSalesTaxForOrder(string to_country, float shipping)
        {
            _calculator.CalculateSalesTaxForOrder(to_country, shipping);
            throw new NotImplementedException();
        }

        public TaxRate GetTaxRate(string zip)
        {
            _calculator.GetTaxRate(zip);
            throw new NotImplementedException();
        }
    }
}