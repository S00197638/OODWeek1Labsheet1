using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

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
            //Populate Combo Box
            string[] genres = { "All", "K-Pop", "Pop", "Pop-Rock" };
            cbbxGenres.ItemsSource = genres;
            cbbxGenres.SelectedItem = "All";
            
            //Creating Bands
            KPopBand b1 = new KPopBand() { BandName = "BLACKPINK", YearFormed = 2016, Members = "Lisa, Jennie, Jisoo, Rosé" };
            KPopBand b2 = new KPopBand() { BandName = "BTS", YearFormed = 2013, Members = "J-Hope, Jimin, Jin, Jungkook, RM, Suga, V" };

            PopBand b3 = new PopBand() { BandName = "Little Mix", YearFormed = 2011, Members = "Leigh-Anne Pinnock, Jade Thirlwall, Jesy Nelson, Perrie Edwards" };
            PopBand b4 = new PopBand() { BandName = "Jonas Brothers", YearFormed = 2005, Members = "Joe Jonas, Kevin Jonas, Nick Jonas" };

            PopRockBand b5 = new PopRockBand() { BandName = "The Vamps", YearFormed = 2012, Members = "Brad Simpson, Connor Ball, James McVey, Tristan Evans" };
            PopRockBand b6 = new PopRockBand() { BandName = "McFly", YearFormed = 2003, Members = "Danny Jones, Dougie Poynter, Harry Judd, Tom Fletcher" };

            //Creating Random Number Generator
            Random rng = new Random();

            //Creating Albums
            //BLACKPINK Albums
            Album a1 = new Album("THE ALBUM", new DateTime(2020, 1, 1), rng.Next(10000000, 1000000000));
            Album a2 = new Album("BLACKPINK IN YOUR AREA", new DateTime(2018, 1, 1), rng.Next(10000000, 1000000000));

            //BTS Albums
            Album a3 = new Album("BE", new DateTime(2020, 1, 1), rng.Next(10000000, 1000000000));
            Album a4 = new Album("MAP OF THE SOUL : 7", new DateTime(2020, 1, 1), rng.Next(10000000, 1000000000));

            //Little Mix Albums
            Album a5 = new Album("Confetti", new DateTime(2020, 1, 1), rng.Next(10000000, 1000000000));
            Album a6 = new Album("LM5", new DateTime(2018, 1, 1), rng.Next(10000000, 1000000000));

            //Jonas Brothers Albums
            Album a7 = new Album("Happiness Begins", new DateTime(2019, 1, 1), rng.Next(10000000, 1000000000));
            Album a8 = new Album("JONAS L.A.", new DateTime(2010, 1, 1), rng.Next(10000000, 1000000000));

            //The Vamps Albums
            Album a9 = new Album("Cherry Blossom", new DateTime(2020, 1, 1), rng.Next(10000000, 1000000000));
            Album a10 = new Album("Night & Day", new DateTime(2018, 1, 1), rng.Next(10000000, 1000000000));

            //McFly Albums
            Album a11 = new Album("Young Dumb Thrills", new DateTime(2020, 1, 1), rng.Next(10000000, 1000000000));
            Album a12 = new Album("Above The Noise", new DateTime(2010, 1, 1), rng.Next(10000000, 1000000000));

            //Add Albums
            b1.AlbumList.Add(a1);
            b1.AlbumList.Add(a2);

            b2.AlbumList.Add(a3);
            b2.AlbumList.Add(a4);

            b3.AlbumList.Add(a5);
            b3.AlbumList.Add(a6);

            b4.AlbumList.Add(a7);
            b4.AlbumList.Add(a8);

            b5.AlbumList.Add(a9);
            b5.AlbumList.Add(a10);

            b6.AlbumList.Add(a11);
            b6.AlbumList.Add(a12);

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

        #region Selection

        private void lbxBands_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Band selectedBand = lbxBands.SelectedItem as Band;

            if(selectedBand != null)
            {
                tblkBandInfo.Text = string.Format($"Name : {selectedBand.BandName}" + 
                    $"\nFormed : {selectedBand.YearFormed}" + 
                    $"\nMembers : {selectedBand.Members}");
                
                lbxAlbums.ItemsSource = selectedBand.AlbumList;
            }
        }

        #endregion

        #region Filtering

        //Filter Based on Combo Box
        private void cbbxGenres_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Determine what is selected
            string selectedGenre = cbbxGenres.SelectedItem as string;

            //Setup Filter List
            List<Band> filteredBands = new List<Band>();

            //Check
            switch (selectedGenre)
            {
                case "All":
                    lbxBands.ItemsSource = allBands;
                    break;

                case "K-Pop":
                    foreach (Band band in allBands)
                    {
                        if (band is KPopBand)
                            filteredBands.Add(band);
                    }
                    lbxBands.ItemsSource = filteredBands;
                    break;

                case "Pop":
                    foreach (Band band in allBands)
                    {
                        if (band is PopBand)
                            filteredBands.Add(band);
                    }
                    lbxBands.ItemsSource = filteredBands;
                    break;

                case "Pop-Rock":
                    foreach (Band band in allBands)
                    {
                        if (band is PopRockBand)
                            filteredBands.Add(band);
                    }
                    lbxBands.ItemsSource = filteredBands;
                    break;

            }
        }

        #endregion

        #region Save Button

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            System.IO.File.WriteAllText(@"C:\bandInfo.txt", tblkBandInfo.Text);

            MessageBox.Show("Band Information Saved to bandInfo.txt in your C: Drive");
        }

        #endregion
    }
}
