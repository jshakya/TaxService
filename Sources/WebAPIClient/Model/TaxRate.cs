using System.Text.Json.Serialization;

namespace WebApiClient
{
    class TaxRate
    {
        #region  Public Interface

        [JsonPropertyName("zip")]
        public string Zip { get ; set ; }
        
        [JsonPropertyName("country")]
        public string Country {get;set;}
        
        [JsonPropertyName("country_rate")]
        public float Country_rate {get;set;}
        
        [JsonPropertyName("state")]
        public string State {get;set;}
        
        [JsonPropertyName("state_rate")]
        public float State_rate {get;set;}
        
        [JsonPropertyName("county")]
        public string County {get;set;}
        
        [JsonPropertyName("county_rate")]
        public float County_rate {get;set;}
        [JsonPropertyName("city")]
        public string City {get;set;}
        
        [JsonPropertyName("city_rate")]
        public float City_rate {get;set;}
        
        [JsonPropertyName("combined_district_rate")]
        public float Combined_district_rate {get;set;}
        
        [JsonPropertyName("combined_rate")]
        public float Combined_rate {get;set;}
        
        [JsonPropertyName("freight_taxable")]

        #region Australia-Specific

        #endregion

        #region Australia-Specific

        #endregion
        public bool Freight_taxable {get;set;}
        #endregion
    }
}