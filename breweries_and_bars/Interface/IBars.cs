using breweries_and_bars.Models;
using System.Collections.Generic;

namespace breweries_and_bars.Interface
{
    public interface IBars
    {
        List<Bar> GetBar();
        void InsertBar(Bar value);
        Bar GetBarById(int id);
        void UpdateBar(int id, Bar bar);
    }
}
