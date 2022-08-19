using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using static Exam1908.Member;

namespace Exam1908
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //creating list of members
        List<Member> allMembers;

        public MainWindow()
        {
            InitializeComponent();
        }

        private List<Member> GetMembers()
        {
            List<Member> members = new List<Member>();

            //creating the objects
             Member sm1 = new Member() { Name = "Caetano Veloso", BaseFee = 200m, JoinDate = new DateTime(2019, 8, 15),TypeOfSubscription = SubscriptionType.Annual  };
             Member sm2 = new Member() { Name = "Gal Costa", BaseFee = 200m, JoinDate = new DateTime(2017, 8, 20),TypeOfSubscription = SubscriptionType.Annual  };
             Member sm3 = new Member() { Name = "Gilberto Gil", BaseFee = 200m, JoinDate = new DateTime(2016, 7, 23),TypeOfSubscription = SubscriptionType.Annual  };


            Member.MonthlyMember mm1 = new Member.MonthlyMember() { Name = "Jhoony Hooker", BaseFee = 100m, JoinDate = new DateTime(2019, 7, 10), TypeOfSubscription = SubscriptionType.Monthly };
            Member.MonthlyMember mm2 = new Member.MonthlyMember() { Name = "Marisa Monte", BaseFee = 100m, JoinDate = new DateTime(2015, 7, 10), TypeOfSubscription = SubscriptionType.Monthly };
            Member.MonthlyMember mm3 = new Member.MonthlyMember() { Name = "Marina Senna", BaseFee = 100m, JoinDate = new DateTime(2018, 7, 10), TypeOfSubscription = SubscriptionType.Monthly };
            //MonthlyMember mm1 = new MonthlyMember() { }


            //SeniorMember sm1 = new SeniorMember() { Name = "Cian Daly", Fee = 1000, JoinDate = new DateTime(2015, 4, 24), PaymentType = PaymentSchedule.Annual };
            //SeniorMember sm2 = new SeniorMember() { Name = "Bobby Quinn", Fee = 1000, JoinDate = new DateTime(2014, 12, 1), PaymentType = PaymentSchedule.Biannual };
            //SeniorMember sm3 = new SeniorMember() { Name = "Eve Gallagher", Fee = 1000, JoinDate = new DateTime(2013, 6, 1), PaymentType = PaymentSchedule.Monthly };

            //adding members to the list
            members.Add(sm1);
            members.Add(sm2);
            members.Add(sm3);

            members.Add(mm1);
            members.Add(mm2);
            members.Add(mm3);

            //members.Add(sm1);
            //members.Add(sm2);
            //members.Add(sm3);

            return members;


        }

        //display members in the listbox when loaded
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            allMembers = GetMembers();
            lbxMembers.ItemsSource = allMembers;
        }

        private void tblkDetails_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void lbxMembers_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void lbxMembers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Member selectedMember = lbxMembers.SelectedItem as Member;

            if (selectedMember != null)
            {
                tblkDetails.Text = selectedMember.DisplayDetails();
            }
        }


        //filtering buttons
        private void rb_Checked(object sender, RoutedEventArgs e)
        {
            lbxMembers.ItemsSource = null;

            if (rbAll.IsChecked.Value == true)
            {
                lbxMembers.ItemsSource = allMembers;
            }
        }
    }
}
