using breweries_and_bars.Interface;
using breweries_and_bars.Models;
using System.Collections.Generic;

namespace breweries_and_bars.Manager
{
    public class BreweryBeerManager: IBrewaeyBeer
    {
        
        public List<Brewery> GetBrewaeyBeer(IBrewery _brewery)
        {
            return _brewery.GetAllBreweries();
        }
        public void InsertBrewaeryBeer(IBrewery _brewery,Brewery breweryData)
        {
            _brewery.InsertBreweries(breweryData);
        }

        public  Brewery  GetBreweryAndAssociatedBeer(int id,IBrewery _brewery)
        {
            return _brewery.GetBreweriesById(id);
        }
    }
}
