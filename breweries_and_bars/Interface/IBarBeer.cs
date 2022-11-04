using breweries_and_bars.Models;
using System.Collections.Generic;

namespace breweries_and_bars.Interface
{
    public interface IBarBeer
    {
        List<Bar> GetAllBars(IBars _bars);
        Bar GetBarAndAssociatedBeer(int id, IBars _bars);
        void InsertBarBeer(IBars _bars, Bar barData);
    }
}
