using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutSystemTests.Core
{
    public class CheckoutSystemHelper
    {
        private const decimal Starters = 4.00M;
        private const decimal Mains = 7.00M;
        private const decimal Drinks = 2.5M;
        private const decimal Charge = 0.1M;

        public decimal CalculateCheckOut(int nrOfStarters = 0, int nrOfMains = 0, int nrOfDrinks = 0)
        {
            var cost = ((nrOfStarters * Starters) + (nrOfMains * Mains) + (nrOfDrinks * Drinks));

            return (cost + cost * Charge);
        }

    }
}
