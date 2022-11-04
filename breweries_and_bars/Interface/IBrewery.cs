using breweries_and_bars.Models;
using System.Collections.Generic;

namespace breweries_and_bars.Interface
{
    public interface IBrewery
    {
        public List<Brewery> GetAllBreweries();
        Brewery GetBreweriesById(int id);
        void UpdateBreweriesById(int id, Brewery breweryData);
        void InsertBreweries(Brewery value);
    }
}
