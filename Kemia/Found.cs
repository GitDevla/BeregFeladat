namespace Kemia
{
    class Found
    {
        public readonly string Year;
        public readonly Compound Compound;
        public readonly string Discoverer;

        public Found(string year, Compound compound, string discoverer)
        {
            Year = year;
            Compound = compound;
            Discoverer = discoverer;
        }
    }
}
