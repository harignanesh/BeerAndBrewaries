using breweries_and_bars.Interface;
using breweries_and_bars.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace breweries_and_bars.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BarBeersController : ControllerBase
    {
        private IBars _bars;
        private IBarBeer _barBeer;
        public BarBeersController(IBars bars, IBarBeer barBeer)
        {
            _bars = bars;
            _barBeer = barBeer;
        }
        [HttpGet]
        public List<Bar> GetAllBars()
        {
            return _barBeer.GetAllBars(_bars);
        }

        [HttpGet("{id}")]
        public Bar Get(int id)
        {
            return _barBeer.GetBarAndAssociatedBeer(id,_bars);
        }

        [HttpPost]
        public void Post([FromBody] Bar barData)
        {
            _barBeer.InsertBarBeer(_bars, barData);
        }
    }
}
