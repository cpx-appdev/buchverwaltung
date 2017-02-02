public class BuchViewModel
    {
        public string Titel { get; set; }
        public string VerliehenAn { get; set; }
        public string VerliehenAm { get; set; }

        public BuchViewModel(Buch buch)
        {
            this.Titel = buch.Titel;
            this.VerliehenAm = buch.VerliehenAm.ToString("yyyy.MM.dd, HH:mm:ss");
            this.VerliehenAn = buch.VerliehenAn;
        }
    }