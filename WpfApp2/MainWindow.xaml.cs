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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        double DevineMethod(double weight, string gender)
        {
            double answer = 0.0;

            switch (gender)
            {
                case "Мужчина":
                    answer = 50 + 2.3 * (0.394 * weight - 60);
                    break;

                case "Женщина":
                    answer = 45.5 + 2.3 * (0.394 * weight - 60);
                    break;

                default:
                    MessageBox.Show("Укажите пол");
                    break;
            }


            return answer;

        }

        double RobinsonMethod(double weight, string gender)
        {
            double answer = 0.0;

            switch (gender)
            {
                case "Мужчина":
                    answer = 52 + 1.9 * (0.394 * weight - 60);
                    break;

                case "Женщина":
                    answer = 49 + 1.7 * (0.394 * weight - 60);
                    break;

                default:
                    MessageBox.Show("Укажите пол");
                    break;
            }


            return answer;

        }

        private void btnCalc_Click(object sender, RoutedEventArgs e)
        {
            double hg = 0.0;
            try
            {
                hg = Convert.ToDouble(Humansheight.Text);
            }
            catch (Exception error)
            {
                MessageBox.Show($"Произошла ошибка, обратитесь к администратору: {error.Message}");
            }


            switch (cbMethod.Text)
            {
                case "Devine":
                    Weight.Content = $"{DevineMethod(hg, cbGender.Text)}";

                    break;

                case "Robinson":
                    Weight.Content = $"{RobinsonMethod(hg, cbGender.Text)}";
                    break;

                default:
                    MessageBox.Show("Выберите метод расчёта");
                    break;
            }
        }
    }
    
}
