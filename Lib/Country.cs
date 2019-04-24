using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class Country
    {
        public string Name;
        public Grade Diversity;
        public Grade Freedom;
        public Grade Broadband;
        public Grade HumanCapital;
        public Grade TaxFriendliness;
        public Grade RDInvestment;
        public Grade EntrepreneurialActivity;
        public Grade Unicorns;
        public Grade Resilience;
        public Grade Drones;
        public Grade Ridesharing;
        public Grade ShortTermRentals;
        public Grade SelfDrivingVehicles;
        public Grade Environment;
        protected Country() { }
        public Country(string name, Grade[] grades)
        {
            Name = name;
            Diversity = grades[(int)CategoryEnum.Diversity];
            Freedom = grades[(int)CategoryEnum.Freedom];
            Broadband = grades[(int)CategoryEnum.Broadband];
            HumanCapital = grades[(int)CategoryEnum.HumanCapital];
            TaxFriendliness = grades[(int)CategoryEnum.TaxFriendliness];
            RDInvestment = grades[(int)CategoryEnum.RDInvestment];
            EntrepreneurialActivity = grades[(int)CategoryEnum.EntrepreneurialActivity];
            Unicorns = grades[(int)CategoryEnum.Unicorns];
            Resilience = grades[(int)CategoryEnum.Resilience];
            Drones = grades[(int)CategoryEnum.Drones];
            Ridesharing = grades[(int)CategoryEnum.Ridesharing];
            ShortTermRentals = grades[(int)CategoryEnum.ShortTermRentals];
            SelfDrivingVehicles = grades[(int)CategoryEnum.SelfDrivingVehicles];
            Environment = grades[(int)CategoryEnum.Environment];
        }
        public Grade[] GetGrades()
        {
            return new Grade[]
            {
                Diversity,
                Freedom,
                Broadband,
                HumanCapital,
                TaxFriendliness,
                RDInvestment,
                EntrepreneurialActivity,
                Unicorns,
                Resilience,
                Drones,
                Ridesharing,
                ShortTermRentals,
                SelfDrivingVehicles,
                Environment
            };
        }
        public double GetScore(Boolean[] take = null)
        {
            Grade[] grades = GetGrades();
            int s = 0, n = 0;
            if (take == null)
            {
                for (int i=0; i<grades.Length; i++)
                {
                    s += grades[i].Score;
                }
                n = grades.Length;
            }
            else
            {
                for (int i = 0; i < grades.Length; i++)
                {
                    if (take[i])
                    {
                        s += grades[i].Score;
                        n++;
                    }
                }
            }
            if (n == 0)
            {
                return 0;
            }
            else
            {
                return (double)s / n;
            }
        }
    }
}
