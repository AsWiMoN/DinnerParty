namespace DinnerParty
{
    class BirthdayParty:Party
    {

        private int actualLength
        {
            get
            {
                if (CakeWriting.Length > MaxWritingLength()) return MaxWritingLength(); else return CakeWriting.Length;
            }
        }
        public string CakeWriting { get; set; }
        public BirthdayParty(int numberOfPeople, string cakeWriting, bool fancyDecorations)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            CakeWriting = cakeWriting;
        }

        private int CakeSize()
        {
            if (NumberOfPeople <= 8) return 8; else return 16;            
        }
        private int MaxWritingLength()
        {
            if (CakeSize() == 8) return 16; else return 40;
        }

        public bool CakeWritingTooLong
        {
            get
            {
                if (CakeWriting.Length > MaxWritingLength()) return true; else return false;
            }
        }       

        override public decimal Cost
        {
            get
            {
                decimal totalCost = base.Cost;
                decimal cakeCost;
                if (CakeSize() == 8)
                    cakeCost = 40m + actualLength + .25M;
                else
                    cakeCost = 75M + actualLength * .25M;
                return totalCost + cakeCost;
                
            }
        }
            


    }
}
