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
    /// Logika interakcji dla klasy OknoProduktu.xaml
    /// </summary>
    public partial class OknoProduktu : Window
    {
        public OknoProduktu(System.Xml.XmlElement produkt)
        {
            DataContext = produkt;
            InitializeComponent();
        }
    }
}
