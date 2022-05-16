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
    public partial class OknoKategorii : Window
    {
        public OknoKategorii(System.Xml.XmlElement kategoria)
        {
            DataContext = kategoria ;
            Console.WriteLine(kategoria);
            InitializeComponent();
        }

        private void WyswietlPodkategorie(object sender, RoutedEventArgs e)
        {
            FrameworkElement parent = (FrameworkElement)((FrameworkElement)sender).Parent;
            ListBox lista = (ListBox)parent.FindName("Podkategorie");
            new OknoPodkategorii((System.Xml.XmlElement) lista.SelectedItem).Show();
        }
    }
}
