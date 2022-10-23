using System;
using System.Collections;
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
namespace hw2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string num_str = textbox1.Text;
            int num_int;
            bool num1 = int.TryParse(num_str, out num_int);
            ArrayList list = new ArrayList();
            if (textbox1.Text.Length == 0 || !num1 || num_int < 0)
            {
                MessageBox.Show("請重新輸入");
                return;
            }
            for (int i = 2; i <= num_int; i++)
            {
                bool flag = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    list.Add(i);
                }
            }
            textbox2.Text = "";
            int[] aa = (int[])list.ToArray(typeof(int));
            textbox2.Text += $"小於等於{num_int}的質數為";
            foreach (var sum in aa)
            {
                textbox2.Text += $"{sum} ";
            }
            textbox2.Text += $"\n";
            foreach (var i in aa)
            {
                textbox2.Text += $"{i}的倍數：";
                for (int j = 2; j <= num_int; j++)
                {
                    if (j % i == 0)
                    {
                        textbox2.Text += $"{j} ";
                    }
                }
                textbox2.Text += $"\n";
            }
        }
    }
}