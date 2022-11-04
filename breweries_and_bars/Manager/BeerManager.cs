using breweries_and_bars.Interface;
using breweries_and_bars.Models;
using System.Collections.Generic;
using System.Linq;

namespace breweries_and_bars.Manager
{
    public class BeerManager : IBeer
    {
        public List<Beer> beers = new List<Beer>();
        public List<Beer> GetBeer()
        {
            return beers;
        }
        public List<Beer> InsertBeer(Beer value)
        {
            if (value != null)
            {
                beers.Add(value);
            }
            else
            {
                return null;
            }
                
            return beers;
        }

        public Beer GetBeerById(int id)
        {
            return beers.Where(a => a.Id == id).FirstOrDefault();
        }

        public void UpdateBeer(int id, Beer beer)
        {
            var updateBeer = beers.Where(a => a.Id == id).FirstOrDefault();
            if (beer != null)
            {
                updateBeer.PercentageAlcoholByVolume = beer.PercentageAlcoholByVolume;
                updateBeer.Name = beer.Name;
            }
        }

        public List<Beer> GetBeerWithRespectToRange(decimal? gtAlcoholByVolume = 0, decimal? ltAlcoholByVolume = 0)
        {
            return beers.Where(b => b.PercentageAlcoholByVolume > gtAlcoholByVolume && gtAlcoholByVolume <= ltAlcoholByVolume).ToList();
        }
    }
}
