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

namespace EnglishSchoolBulatDemo.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationPage.xaml
    /// </summary>
    public partial class AuthorizationPage : Page
    {
        const string code = "0000";
        public AuthorizationPage()
        {
            InitializeComponent();

        }

        private void SubmitBt_Click(object sender, RoutedEventArgs e)
        {
            if (CodeTb.Text == code)
            {
                MessageBox.Show("Режим администратора включен!");
            }
            else
            {
                MessageBox.Show("Код неверный!");
            }
        }
    }
}
