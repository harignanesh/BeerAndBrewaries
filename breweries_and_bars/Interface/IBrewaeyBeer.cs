using breweries_and_bars.Models;
using System.Collections.Generic;

namespace breweries_and_bars.Interface
{
    public interface IBrewaeyBeer 
    {
        List<Brewery> GetBrewaeyBeer(IBrewery _brewery);
        Brewery GetBreweryAndAssociatedBeer(int id, IBrewery _brewery);
        void InsertBrewaeryBeer(IBrewery _brewery, Brewery breweryData);
    }
}
