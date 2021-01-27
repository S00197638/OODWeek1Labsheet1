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

namespace BandInfoApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Setup

        List<Band> allBands = new List<Band>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Band b1 = new Band("BLACKPINK", 2016, "Lisa, Jennie, Jisoo, Rosé");
            Band b2 = new Band("BTS", 2013, "J-Hope, Jimin, Jin, Jungkook, RM, Suga, V");

            Band b3 = new Band("Little Mix", 2011, "Leigh-Anne Pinnock, Jade Thirlwall, Jesy Nelson, Perrie Edwards");
            Band b4 = new Band("Jonas Brothers", 2005, "Joe Jonas, Kevin Jonas, Nick Jonas");

            Band b5 = new Band("The Vamps", 2012, "Brad Simpson, Connor Ball, James McVey, Tristan Evans");
            Band b6 = new Band("McFly", 2003, "Danny Jones, Dougie Poynter, Harry Judd, Tom Fletcher");

            //Add to Collection
            allBands.Add(b1);
            allBands.Add(b2);
            allBands.Add(b3);
            allBands.Add(b4);
            allBands.Add(b5);
            allBands.Add(b6);

            //Sort Bands
            allBands.Sort();

            //Display in Listbox
            lbxBands.ItemsSource = allBands;
        }

        #endregion
    }
}
