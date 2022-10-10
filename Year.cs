namespace Jackie {
    internal class Year {
        readonly public int date;
        readonly public int races;
        readonly public int wins;
        readonly public int podiums;
        readonly public int datepoles;
        readonly public int fastests;

        public Year(int date, int races, int wins, int podiums, int datepoles, int fastests) {
            this.date = date;
            this.races = races;
            this.wins = wins;
            this.podiums = podiums;
            this.datepoles = datepoles;
            this.fastests = fastests;
        }
    }
}
