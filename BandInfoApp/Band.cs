using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BandInfoApp
{
    public class Band
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

        #endregion
    }
}
