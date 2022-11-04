using System.Collections.Generic;
using breweries_and_bars.Models;

namespace breweries_and_bars.Interface
{
    public interface IBeer
    {
        List<Beer> GetBeer();
        List<Beer> InsertBeer(Beer value);
        Beer GetBeerById(int id);
        void UpdateBeer(int id, Beer beer);
        List<Beer> GetBeerWithRespectToRange(decimal? gtAlcoholByVolume, decimal? ltAlcoholByVolume);
    }
}
