namespace BandInfoApp
{
    public class Album
    {
        #region Properties

        public string Name { get; set; }

        public int YearOfRelease { get; set; }

        public int Sales { get; set; }

        #endregion

        #region Constructors

        public Album(string name, int yearOfRelease, int sales)
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
            return string.Format($"{Name} | Released in {YearOfRelease} | Sales = {Sales}");
        }

        #endregion
    }
}
