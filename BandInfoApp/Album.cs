using System;

namespace BandInfoApp
{
    public class Album
    {
        #region Properties

        public string Name { get; set; }

        public DateTime YearOfRelease { get; set; }

        public int Sales { get; set; }

        #endregion

        #region Constructors

        public Album(string name, DateTime yearOfRelease, int sales)
        {
            Name = name;
            YearOfRelease = yearOfRelease;
            Sales = sales;
        }

        public Album() { }

        #endregion

        #region Methods

        public override string ToString()
        {
            return string.Format($"{Name} | Released {CalculateYearsSinceRelease()} Year(s) Ago | Sales = {Sales}");
        }

        public int CalculateYearsSinceRelease()
        {
            return DateTime.Now.Year - YearOfRelease.Year;
        }

        #endregion
    }
}
