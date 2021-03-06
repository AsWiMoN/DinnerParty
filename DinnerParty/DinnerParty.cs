﻿namespace DinnerParty
{
    class DinnerParty : Party
    {
        
        public bool HealthyOption { get; set; }

        public DinnerParty(int numberOfPeople, bool healthyOption, bool fancyDecoration)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecoration;
            HealthyOption = healthyOption;
        }

      

        private decimal CalculateCostOfBeveragesPerPerson()
        {
            decimal costOFBeveragesPerPerson;
            if (HealthyOption)
            {
                costOFBeveragesPerPerson = 5.00M;
            }
            else
            {
                costOFBeveragesPerPerson = 20.00M;
            }
            return costOFBeveragesPerPerson;
        }

        override public decimal Cost
        {
            get
            {
                decimal totalCost = base.Cost;
                totalCost += CalculateCostOfBeveragesPerPerson()*NumberOfPeople;
                if (HealthyOption)
                {
                    totalCost += .95M;
                }
                return totalCost;
            }
            
        }

        //const int CostOfFoodPerPerson = 25;
        //public int NumberOfPeople;
        //public decimal CostOFBeveragesPerPerson;
        //public decimal CostOfDecorations = 0;

        //public void SetHelthyOption(bool healtyOption)
        //{
        //    if (healtyOption)
        //    {
        //        CostOFBeveragesPerPerson = 5.00M;
        //    }
        //    else
        //    {
        //        CostOFBeveragesPerPerson = 20.00M;
        //    }
        //}

        //public void CalculateCostOfDecoration(bool fancy)
        //{
        //    if (fancy)
        //    {
        //        CostOfDecorations = (NumberOfPeople * 15.00M) + 50M;
        //    }
        //    else
        //    {
        //        CostOfDecorations = (NumberOfPeople * 7.50M) + 30M;
        //    }
        //}

        //public decimal CalculateCost(bool healthyOption)
        //{
        //    decimal totalCost = CostOfDecorations + ((CostOFBeveragesPerPerson + CostOfFoodPerPerson) * NumberOfPeople);
        //    if (healthyOption)
        //    {
        //        return totalCost * .95M;
        //    }
        //    else
        //    {
        //        return totalCost;
        //    }
        //}
    }
}
