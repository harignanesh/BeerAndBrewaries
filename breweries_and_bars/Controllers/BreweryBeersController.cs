using breweries_and_bars.Interface;
using breweries_and_bars.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace breweries_and_bars.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BreweryBeersController : ControllerBase
    {
        private IBrewery _brewery;
        private IBrewaeyBeer _brewaeyBeer; 
        public BreweryBeersController(IBrewery brewery, IBrewaeyBeer brewaeyBeer)
        {
            _brewery = brewery;
            _brewaeyBeer = brewaeyBeer;
        }
        [HttpGet]
        public List<Brewery> GetAllBrewery()
        {
            return  _brewaeyBeer.GetBrewaeyBeer(_brewery);
        }

        [HttpGet("{id}")]
        public Brewery GetBreweryAndAssociatedBeer(int id)
        {
            return _brewaeyBeer.GetBreweryAndAssociatedBeer(id,_brewery);
        }

        [HttpPost]
        [Route("/brewery/beer")]
        public void InserBreweyBeer([FromBody] Brewery breweryData)
        {
            _brewaeyBeer.InsertBrewaeryBeer(_brewery, breweryData);
        }
    }
}
