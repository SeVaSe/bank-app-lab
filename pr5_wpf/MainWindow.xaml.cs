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


namespace pr5_wpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BankAccountNS.BankAccount account;

        public MainWindow()
        {
            InitializeComponent();
            
            account = new BankAccountNS.BankAccount("Роман Абромович", 11.99);
            DataContext = account;
            TxtBl_balance.Text = account.Balance.ToString();
        }

        private void Btn_credit_Click(object sender, RoutedEventArgs e) // пополнение
        {
            double num;
            if (double.TryParse(TxtBox_sum.Text, out num))
            {
                try
                {
                    account.Credit(num);
                    TxtBl_balance.Text = account.Balance.ToString();
                }
                catch(System.Exception ex)
                {
                    MessageBox.Show("Вы ввели отрицательное значение!", "Ошибка значений");
                }
            }
            else
            {
                MessageBox.Show("Вы ввели не те данные, в поля ввода!", "Ошибка ввода");
            }
        }

        private void Btn_debit_Click(object sender, RoutedEventArgs e)
        {
            double num;
            if (double.TryParse(TxtBox_sum.Text, out num))
            {
                try
                {
                    account.Debit(num);
                    TxtBl_balance.Text = account.Balance.ToString();
                }
                catch
                {
                    MessageBox.Show("Вы ввели отрицательное значение или вы пытаетесь снять не существующее количество денег с вашего баланса!", "Ошибка значений");
                }
            }
            else
            {
                MessageBox.Show("Вы ввели не те данные, в поля ввода!", "Ошибка ввода");
            }
        }
    }
}
