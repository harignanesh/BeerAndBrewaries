using breweries_and_bars.Interface;
using breweries_and_bars.Models;
using System.Collections.Generic;
using System.Linq;

namespace breweries_and_bars.Manager
{
    public class BarsManager:IBars
    {
        public List<Bar> bars = new List<Bar>();

        public List<Bar> GetBar()
        {
            return bars;
        }
        public void InsertBar(Bar value)
        {
            bars.Add(value);
        }

        public Bar GetBarById(int id)
        {
            return bars.Where(b => b.Id == id).FirstOrDefault();
        }

        public void UpdateBar(int id, Bar bar)
        {
            var updateBar = bars.Where(b => b.Id == id).FirstOrDefault();
            var beerList = updateBar.Beer.Where(a => a.Id == id).ToList();
            if (bar != null)
            {
                updateBar.Name = bar.Name;
                updateBar.Address = bar.Address;
                foreach (var beer in beerList)
                {
                    beer.Name = bar.Beer.Select(a => a.Name).First();
                    beer.PercentageAlcoholByVolume = bar.Beer.Select(a => a.PercentageAlcoholByVolume).First();
                }
            }
        }
    }
}
