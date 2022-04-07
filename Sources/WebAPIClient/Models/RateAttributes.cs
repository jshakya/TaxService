using System.Text.Json.Serialization;

namespace WebApiClient
{
    class RateAttributes
    {
        #region  Common Attributes 

        [JsonPropertyName("zip")]
        public string Zip { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("country_rate")]
        public float Country_Rate { get; set; }

        [JsonPropertyName("state")]
        public string State { get; set; }

        [JsonPropertyName("state_rate")]
        public float State_Rate { get; set; }

        [JsonPropertyName("county")]
        public string County { get; set; }

        [JsonPropertyName("county_rate")]
        public float County_Rate { get; set; }
        [JsonPropertyName("city")]
        public string City { get; set; }

        [JsonPropertyName("city_rate")]
        public float City_Rate { get; set; }

        [JsonPropertyName("combined_district_rate")]
        public float Combined_District_Rate { get; set; }

        [JsonPropertyName("combined_rate")]
        public float Combined_Rate { get; set; }

        [JsonPropertyName("freight_taxable")]
        public bool Freight_taxable { get; set; }
        #endregion

        #region Additional EU Attributes
        [JsonPropertyName("standard_rate")]
        public float Standard_Rate { get; set; }

        [JsonPropertyName("reduced_rate")]
        public float Reduced_Rate { get; set; }

        [JsonPropertyName("super_reduced_rate")]
        public float Super_Reduced_Rate { get; set; }

        [JsonPropertyName("parking_rate")]
        public float Parking_Rate { get; set; }

        [JsonPropertyName("distance_sale_threshold")]
        public float Distance_Sale_Threshold { get; set; }
        
        #endregion
    }
}