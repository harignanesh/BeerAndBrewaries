using breweries_and_bars.Interface;
using breweries_and_bars.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace breweries_and_bars.Controllers
{
    [Route("api/[controller]/[action]")]
    public class BeersController : ControllerBase
    {
        private IBeer _beer;
        public BeersController(IBeer beer)
        {
            _beer = beer;
        }

        [HttpGet]
        public List<Beer> GetAllBeer()
        {
            return _beer.GetBeer();
        }

        [HttpGet("{id}")]
        public Beer GetBeerById(int id)
        {
            return _beer.GetBeerById(id);
        }

        [HttpGet]
        public List<Beer> GetBeerWithRespectToRange(decimal? gtAlcoholByVolume=0,decimal? ltAlcoholByVolume=0)
        {
            return _beer.GetBeerWithRespectToRange(gtAlcoholByVolume, ltAlcoholByVolume);
        }

        #region BeerPost_JsonData
        //        {
        //  "id": 1,
        //  "name": "Beer1",
        //  "percentageAlcoholByVolume": 1.0
        //},
        //{
        //  "id": 2,
        //  "name": "Beer2",
        //  "percentageAlcoholByVolume": 3.0
        //},
        //{
        //    "id": 3,
        //  "name": "Beer3",
        //  "percentageAlcoholByVolume": 6.0
        //}
        #endregion
        [HttpPost]
        public void InsertBeer([FromBody] Beer value)
        {
            _beer.InsertBeer(value);
        }

        [HttpPut("{id}")]
        public void UpdateBeer(int id, [FromBody] Beer value)
        {
            _beer.UpdateBeer(id, value);
        }


    }
}
