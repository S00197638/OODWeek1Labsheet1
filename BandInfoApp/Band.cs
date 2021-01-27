using System;
using System.Collections.Generic;

namespace BandInfoApp
{
    public abstract class Band : IComparable
    {
        #region Properties

        public string BandName { get; set; }

        public int YearFormed { get; set; }

        public string Members { get; set; }

        public List<Album> AlbumList { get; set; }

        #endregion

        #region Constructors

        public Band(string bandName, int yearFormed, string members)
        {
            BandName = bandName;
            YearFormed = yearFormed;
            Members = members;
            AlbumList = new List<Album>();
        }

        public Band() : this("Unknown", 0000, "Unknown") { }

        #endregion

        #region Methods

        public override string ToString()
        {
            return BandName;
        }

        public int CompareTo(object obj)
        {
            Band otherBand = obj as Band;

            return this.BandName.CompareTo(otherBand.BandName);
        }

        #endregion
    }

    public class KPopBand : Band
    {
        #region Methods

        public override string ToString()
        {
            return base.ToString() + "  |  K-Pop Band";
        }

        #endregion
    }

    public class PopBand : Band
    {
        #region Methods

        public override string ToString()
        {
            return base.ToString() + "  |  Pop Band";
        }

        #endregion
    }

    public class PopRockBand : Band
    {
        #region Methods

        public override string ToString()
        {
            return base.ToString() + "  |  Pop-Rock Band";
        }

        #endregion
    }
}
