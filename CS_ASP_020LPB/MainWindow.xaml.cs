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

namespace CS_ASP_020LPB
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void actionButton_Click(object sender, RoutedEventArgs e)
        {
            string result1 = string.Format("Thank you, {0} for your business.", nameText.Text);

            int phoneNumber = int.Parse(phoneText.Text);

            string result2 = string.Format("Phone number is {0: (000)000-0000}", phoneNumber);

            double salary = double.Parse(salaryText.Text);

            string result3 = string.Format("Salary is {0:c}", salary);

            int ss = int.Parse(ssText.Text);

            string result4 = string.Format("Social Security Number is : {0: 000-00-0000}",ss);

            string result5 = string.Format("Loan Date is {0}", loanDateCalendar.SelectedDate);





            resultLabel1.Content = result1;

            resultLabel2.Content = result2;

            resultLabel3.Content = result3;

            resultLabel4.Content = result4;

            resultLabel5.Content = result5;

        }
    }
}
