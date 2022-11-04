using System.Collections.Generic;

namespace breweries_and_bars.Models
{
    public class Brewery
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Beer> Beer { get; set; }
    }
}
