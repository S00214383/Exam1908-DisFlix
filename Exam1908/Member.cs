using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1908
{

    //creating public in the member class to be used enum to be used
    public enum SubscriptionType { Monthly, Biannual, Annual }


    public abstract class Member
    {

        //properties
        public virtual decimal BaseFee { get ; set; }

        public string Name { get; set; }

        public DateTime JoinDate { get; set; }

        public DateTime RenewalDate
        {
            get
            {
                int year = DateTime.Now.Year;
                //if renewal date has passed for this year
                if (DateTime.Now.DayOfYear > JoinDate.DayOfYear)

                    //set renewal year to next year
                    year++;

                return new DateTime(year, JoinDate.Month, JoinDate.Day);


            }
        }

        public SubscriptionType TypeOfSubscription { get; set; }

        public decimal CalculateFee()
        {
            switch (TypeOfSubscription)
            {
                case SubscriptionType.Biannual:
                    return 0.5m;
                case SubscriptionType.Monthly:
                    return 12;

                default:
                    return 0m;
            }
        }

        public override string ToString()
        {
            return Name;
        }

        //return string type
        public virtual string DisplayDetails()
        {
            return $"{Name}\n" +
                   $"Join Date { JoinDate.ToShortDateString()}\n" +
                   $"Basic Fee { BaseFee:C}\n" +
                   $"Payment Schedule { TypeOfSubscription } - {CalculateFee():C}\n" +
                   $"Renewal date { RenewalDate.ToShortDateString()}\n";
                

        }

        #region constructors
        //constructors
        public Member()
        {

        }
        
        public Member(string name, DateTime joinDate, decimal fee, SubscriptionType paymentType)
        {
            Name = name;
            JoinDate = joinDate;
            BaseFee = fee;
            TypeOfSubscription = paymentType;
        }

        public Member(string name, DateTime joinDate) : this(name, joinDate, 750, SubscriptionType.Annual)
        {

        }

        #endregion constructors




        //inherated subclasses
        public class  MonthlyMember : Member
        {
            //taking from base and doing maths
            public override decimal BaseFee { get => base.BaseFee * 0.1m / 12; }

            //to return extra content
            public override string DisplayDetails()
            {
                return base.DisplayDetails() + "\nMonthly Fee";

            }


        }

        public class AnnualMember : Member
        {
            public override decimal BaseFee { get => base.BaseFee = 200m; }

            public override string DisplayDetails()
            {
                return base.DisplayDetails() + "\nAnnual Fee";

            }
        }
    }
}
