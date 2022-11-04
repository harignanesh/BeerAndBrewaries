using System.Collections.Generic;

namespace breweries_and_bars.Models
{
    public class Bar
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Beer> Beer { get; set; }

    }
}
