using breweries_and_bars.Interface;
using breweries_and_bars.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace breweries_and_bars.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BreweriesController : ControllerBase
    {
        private IBrewery _brewery;
        public BreweriesController(IBrewery brewery)
        {
            _brewery = brewery;
        }

        [HttpGet]
        public List<Brewery> GetAllBreweries()
        {
            return _brewery.GetAllBreweries();
        }

        [HttpGet("{id}")]
        public Brewery GetBreweriesById(int id)
        {
            return _brewery.GetBreweriesById(id);
        }

        [HttpPost]
        public void CreateBreweries([FromBody] Brewery value)
        {
            _brewery.InsertBreweries(value);
        }

        [HttpPut("{id}")]
        public void UpdateBreweries(int id, [FromBody] Brewery breweryData)
        {
            _brewery.UpdateBreweriesById(id, breweryData);
        }

    }
}
