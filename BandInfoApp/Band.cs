using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BandInfoApp
{
    public class Band : IComparable
    {
        #region Properties

        public string BandName { get; set; }

        public int YearFormed { get; set; }

        public string Members { get; set; }

        #endregion

        #region Constructors

        public Band(string bandName, int yearFormed, string members)
        {
            BandName = bandName;
            YearFormed = yearFormed;
            Members = members;
        }

        public Band() { }

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
}
