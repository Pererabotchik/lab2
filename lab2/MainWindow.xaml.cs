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

namespace lab2
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int count_pen = Convert.ToInt16(pen.Text);
            int count_feltpen = Convert.ToInt16(felt_pen.Text);

            Pen p = new Pen(count_pen);

            double result_pen1 = p.Count_price();

            felttip_pen f = new felttip_pen(count_feltpen);

            double result_feltpen1 = f.Count_price_felttip();

            result_pen.Text = result_pen1.ToString();
            result_feltpen.Text = result_feltpen1.ToString();
        }
    }
}
