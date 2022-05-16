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
using System.Windows.Shapes;

namespace NET_INIS4_PR2._2_Z4
{
    /// <summary>
    /// Logika interakcji dla klasy OknoGrupy.xaml
    /// </summary>
    public partial class OknoGrupy : Window
    {
        public OknoGrupy(System.Xml.XmlElement grupa)
        {
            DataContext = grupa;
            Console.WriteLine(grupa);
            InitializeComponent();
        }

        private void Szczegóły(object sender, RoutedEventArgs e)
        {
            FrameworkElement parent = (FrameworkElement)((FrameworkElement)sender).Parent;
            ListBox lista = (ListBox)parent.FindName("Produkty");
            new OknoProduktu((System.Xml.XmlElement) lista.SelectedItem).Show();
        }
    }
}
