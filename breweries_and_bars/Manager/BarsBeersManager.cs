using breweries_and_bars.Interface;
using breweries_and_bars.Models;
using System.Collections.Generic;

namespace breweries_and_bars.Manager
{
    public class BarsBeersManager : IBarBeer
    {
        public List<Bar> GetAllBars(IBars _bars)
        {
            return _bars.GetBar();
        }
        public void InsertBarBeer(IBars _bars, Bar barData)
        {
            _bars.InsertBar(barData);
        }

        public Bar GetBarAndAssociatedBeer(int id, IBars _bars)
        {
            return _bars.GetBarById(id);
        }
    }
}
