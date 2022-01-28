using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyInformationJSON
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using System.Text.Json.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class BedrijfsData
    {
        [JsonProperty("enterprise")]
        public Enterprise Enterprise { get; set; }

        [JsonProperty("denomination")]
        public Denomination Denomination { get; set; }

        [JsonProperty("kpis")]
        public Kpi[] Kpis { get; set; }

        [JsonProperty("establishments")]
        public Establishment[] Establishments { get; set; }

        [JsonProperty("activities")]
        public Activity[] Activities { get; set; }

        [JsonProperty("contacts")]
        public object[] Contacts { get; set; }
    }

    public partial class Activity
    {
        [JsonProperty("ActivityGroup")]
        public object ActivityGroup { get; set; }

        [JsonProperty("NaceCodeLabel")]
        public string NaceCodeLabel { get; set; }

        [JsonProperty("NaceCode")]
      
        public long NaceCode { get; set; }

        [JsonProperty("Classification")]
        public string Classification { get; set; }
    }

    public partial class Denomination
    {
        [JsonProperty("Lei")]
        public object Lei { get; set; }

        [JsonProperty("Denomination")]
        public string DenominationDenomination { get; set; }

        [JsonProperty("Language")]
        public string Language { get; set; }

        [JsonProperty("TypeOfDenomination")]
        public string TypeOfDenomination { get; set; }
    }

    public partial class Enterprise
    {
        [JsonProperty("EnterpriseNumber")]
        public string EnterpriseNumber { get; set; }

        [JsonProperty("Status")]
        public string Status { get; set; }

        [JsonProperty("StatusColor")]
        public string StatusColor { get; set; }

        [JsonProperty("FiscalYearEnd")]
        public DateTimeOffset FiscalYearEnd { get; set; }

        [JsonProperty("Employees")]
        public string Employees { get; set; }

        [JsonProperty("JuridicalSituation")]
        public string JuridicalSituation { get; set; }

        [JsonProperty("TypeOfEnterprise")]
        public string TypeOfEnterprise { get; set; }

        [JsonProperty("JuridicalForm")]
        public string JuridicalForm { get; set; }

        [JsonProperty("StartDate")]
        public string StartDate { get; set; }

        [JsonProperty("address")]
        public Address Address { get; set; }
    }

    public partial class Address
    {
        [JsonProperty("TypeOfAddress")]
        public string TypeOfAddress { get; set; }

        [JsonProperty("Zipcode")]
       
        public long Zipcode { get; set; }

        [JsonProperty("MunicipalityNL")]
        public string MunicipalityNl { get; set; }

        [JsonProperty("StreetNL")]
        public string StreetNl { get; set; }

        [JsonProperty("HouseNumber")]
      
        public long HouseNumber { get; set; }

        [JsonProperty("ExtraAddressInfo")]
        public string ExtraAddressInfo { get; set; }

        [JsonProperty("DateStrikingOff")]
        public string DateStrikingOff { get; set; }
    }

    public partial class Establishment
    {
        [JsonProperty("EstablishmentNumber")]
        public string EstablishmentNumber { get; set; }

        [JsonProperty("StartDate")]
        public string StartDate { get; set; }

        [JsonProperty("denomination")]
        public Denomination Denomination { get; set; }

        [JsonProperty("address")]
        public Address Address { get; set; }
    }

    public partial class Kpi
    {
        [JsonProperty("Label")]
        public string Label { get; set; }

        [JsonProperty("Display")]
        public bool Display { get; set; }

        [JsonProperty("Years")]
        public Dictionary<string, Year> Years { get; set; }
        public override string ToString()
        {
            foreach (string key in Years.Keys)
            {
                return key;
            }
            return "OOOOPS";
        }
    }

    public partial class Year
    {
        [JsonProperty("Amount")]
        public string Amount { get; set; }

        [JsonProperty("Reference", NullValueHandling = NullValueHandling.Ignore)]
        public string Reference { get; set; }

        [JsonProperty("ChangePct")]
        public long? ChangePct { get; set; }
    }



 
}
