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

namespace _002_Factorial
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int x = int.Parse(txtNum.Text);

            var watch = System.Diagnostics.Stopwatch.StartNew();
            long rfact = rFactorial(x);
            watch.Stop();
            //수행시간을 Ticks 단위로 알려준다
            var elap = watch.ElapsedTicks;
            string result = "R_Ticks = " + elap;
            listbox.Items.Add(result);

            watch = System.Diagnostics.Stopwatch.StartNew();
            long fact = Factorial(x);
            watch.Stop();
            elap = watch.ElapsedTicks;
            result = "Loop_Ticks = " + elap;
            listbox.Items.Add(result);

            listbox.Items.Add("Recursive : " + rfact);
            listbox.Items.Add("반복문 : " + fact);
        }

        private long Factorial(long x)
        {
            long f = 1;
            for (int i = 2; i <= x; i++)
                f *= i;

            return f;
        }

        private long rFactorial(long x)
        {
            if (x == 1)
                return 1;
            else
                return rFactorial(x - 1) * x;
        }

        private void listbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
