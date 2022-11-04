using breweries_and_bars.Interface;
using breweries_and_bars.Models;
using System.Collections.Generic;
using System.Linq;

namespace breweries_and_bars.Manager
{
    public class BreweriesManager: IBrewery
    {
        public List<Brewery> brewery = new List<Brewery>();
        public List<Brewery> GetAllBreweries()
        {
            return brewery;
        }
        public Brewery GetBreweriesById(int id)
        {
            return brewery.Where(b => b.Id ==id).FirstOrDefault();
        }
        public void UpdateBreweriesById(int id, Brewery breweryData)
        {
            var updateBeer = brewery.Where(b => b.Id == id).FirstOrDefault();
            var beerList =  updateBeer.Beer.Where(b => b.Id == id);
            if (breweryData != null)
            {
                updateBeer.Name = breweryData.Name;
                foreach (var beer in beerList)
                {
                    beer.Name = breweryData.Beer.Select(a => a.Name).First() ;
                    beer.PercentageAlcoholByVolume = breweryData.Beer.Select(a => a.PercentageAlcoholByVolume).First();
                }
            }
        }
        public void InsertBreweries(Brewery value)
        {
            brewery.Add(value);
        }
    }
}
