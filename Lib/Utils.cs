using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lib
{
    public static class Utils
    {
        public static Category[] Categories = new Category[]
        {
            new Category("Diversity", "DiversityColumn", "Diversity  measures the concentrations of various ethnic groups within a country.", CategoryEnum.Diversity),
            new Category("Freedom","FreedomColumn","Freedom  represents the degree to which a country grants its citizens certain civil and political freedoms.",CategoryEnum.Freedom),
            new Category("Broadband","BroadbandColumn","Broadband  measures a country’s total available bandwidth per internet user.",CategoryEnum.Broadband),
            new Category("Human Capital","HumanCapitalColumn","Human Capital  evaluates a country’s educated workforce by weighting equally its high-skilled employment.",CategoryEnum.HumanCapital),
            new Category("Tax Friendliness","TaxFriendlinessColumn","Tax Friendliness  ranks the competitiveness of a country’s tax system.",CategoryEnum.TaxFriendliness),
            new Category("R&D Investment","RDInvestmentColumn","R&D Investment  measures a country’s gross expenditures (regardless of the source of funds) on R&D operations as a percentage of GDP.",CategoryEnum.RDInvestment),
            new Category("Entrepreneurial Activity","EntrepreneurialActivityColumn","Entrepreneurial Activity  evaluates the ease of starting a new business in a country.",CategoryEnum.EntrepreneurialActivity),
            new Category("Unicorns","UnicornsColumn","Unicorns  calculates the number of “unicorn” businesses — domestic companies that have achieved an actual or implied market valuation of at least US $1 billion — founded within the past decade, per 10 million people in population.",CategoryEnum.Unicorns),
            new Category("Resilience","ResilienceColumn","Resilience  quantifies the degree to which a country’s government and society and sustainable.",CategoryEnum.Resilience),
            new Category("Drones","DronesColumn","Drones  assesses a country’s federal laws and regulations on consumer and commercial use of drone technologies.",CategoryEnum.Drones),
            new Category("Ridesharing","RidesharingColumn","Ridesharing  assesses federal laws and regulations governing ridesharing services.",CategoryEnum.Ridesharing),
            new Category("Short-Term Rentals","ShortTermRentalsColumn","Short-Term Rentals  assesses a country’s federal laws and regulations affecting short-term rental services.",CategoryEnum.ShortTermRentals),
            new Category("Self-Driving Vehicles","SelfDrivingVehiclesColumn", "Self-Driving Vehicles  assesses a country’s federal laws and regulations on self-driving vehicles (SDVs).",CategoryEnum.SelfDrivingVehicles),
            new Category("Environment","EnvironmentColumn","Environment  uses World Health Organization data to measure the quality of a country’s air and drinking water.",CategoryEnum.Environment)
        };
        public static Category CountryParam = new Category("Country", "CountryParamColumn", "Country name.");
        public static Category Rank = new Category("Rank", "RankColumn", "Position of the country in the sorted list by score.");
        public static Category CountryScore = new Category(CountryParam.Text, "CountryScoreColumn", CountryParam.Description);
        public static Category Score = new Category("Score", "ScoreColumn", "Score measures an average score through all selected categories.");
        private static XmlSerializer formatter = new XmlSerializer(typeof(Country[]));
        public static void Serialize(StreamWriter writer, Country[] countries)
        {
            formatter.Serialize(writer, countries.ToArray());
        }
        public static Country[] Deserialize(StreamReader reader)
        {
            return (Country[])formatter.Deserialize(reader);
        }
    }
}
