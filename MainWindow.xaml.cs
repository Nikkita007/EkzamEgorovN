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

namespace EkzamEgorovN
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

        private void ms_Click(object sender, RoutedEventArgs e)
        {
            Massa massa = new Massa(Convert.ToInt32(ob.Text), Convert.ToInt32(plot.Text));
            lbOtv.Content = "Масса";
            lbOtv.Content += massa.Vivod().ToString();
        }

        private void vzac_Click(object sender, RoutedEventArgs e)
        {
            Hranilise hranilise = new Hranilise(Convert.ToInt32(TecZapas.Text), Convert.ToInt32(Vzac.Text));
            lbOtv.Content ="Обьем топлива" + HranOb.Text;
            lbOtv.Content +="\n Текущий обьем топлива "+ hranilise.Podschet().ToString(); 


        }

        private void zap_Click(object sender, RoutedEventArgs e)
        {
           Zapravka zaprav = new Zapravka(Convert.ToInt32(TecZapas.Text), Convert.ToInt32(Vzac.Text), Convert.ToInt32(Zap.Text));
            lbOtv.Content += "\n Заправил - " +Zap.Text +" запас топлива - " + zaprav.Zapravit().ToString();
        }
    }
}
