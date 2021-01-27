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
            KPopBand b1 = new KPopBand() { BandName = "BLACKPINK", YearFormed = 2016, Members = "Lisa, Jennie, Jisoo, Rosé" };
            KPopBand b2 = new KPopBand() { BandName = "BTS", YearFormed = 2013, Members = "J-Hope, Jimin, Jin, Jungkook, RM, Suga, V" };

            PopBand b3 = new PopBand() { BandName = "Little Mix", YearFormed = 2011, Members = "Leigh-Anne Pinnock, Jade Thirlwall, Jesy Nelson, Perrie Edwards" };
            PopBand b4 = new PopBand() { BandName = "Jonas Brothers", YearFormed = 2005, Members = "Joe Jonas, Kevin Jonas, Nick Jonas" };

            PopRockBand b5 = new PopRockBand() { BandName = "The Vamps", YearFormed = 2012, Members = "Brad Simpson, Connor Ball, James McVey, Tristan Evans" };
            PopRockBand b6 = new PopRockBand() { BandName = "McFly", YearFormed = 2003, Members = "Danny Jones, Dougie Poynter, Harry Judd, Tom Fletcher" };

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
