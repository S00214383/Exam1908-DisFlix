using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1908
{

    //creating public in the member class to be used enum to be used
    public enum SubscriptionType { Monthly, Biannual, Annual }


    public class Member
    {

        //properties
        public  decimal BaseFee = 200m;

        public string Name { get; set; }

        public DateTime JoinDate { get; set; }

        //public DateTime RenewalDate
        //{
        //    //get
        //    //{
        //    //    int year = DateTime.Now.Year;
        //    //    //if renewal date has passed for this year
        //    //    if (DateTime.Now.DayOfYear > JoinDate.DayOfYear)

        //    //        //set renewal year to next year
        //    //        year++;

        //  // return new DateTime(year, JoinDate.Month, JoinDate.Day);


        //    //}
        //}

        public SubscriptionType TypeOfSubscription { get; set; }

        //public decimal CalculateFee()
        //{
        //    switch (TypeOfSubscription)
        //    {
        //        case SubscriptionType.Biannual:
        //            return 0.5m;
        //        case SubscriptionType.Monthly:
        //            return  12;

        //        default:
        //            return 0m;
        //    }
        //}

        public override string ToString()
        {
            return Name;
        }

        //return string type
        public virtual string DisplayDetails()
        {
            return $"{Name}\n";
                   //$"Join Date { JoinDate.ToShortDateString()}\n" +
                   //$"Basic Fee { Fee:C}\n" +
                   //$"Payment Schedule { PaymentType} - {CalculateFee():C}\n" +
                   //$"Renewal date { RenewalDate.ToShortDateString()}\n" +
                   //$"Days to renew {DaysToRenewal}\n";

        }

        //constructors
        public Member()
        {

        }








        //inherated subclasses
        public class  MonthlyMember : Member
        {
            //public


        }

        public class AnnualMember : Member
        {

        }
    }
}
