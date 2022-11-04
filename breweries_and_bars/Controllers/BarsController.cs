using breweries_and_bars.Interface;
using breweries_and_bars.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace breweries_and_bars.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BarsController : ControllerBase
    {
        private IBars _bars;
        public BarsController(IBars bars)
        {
            _bars = bars;
        }
        [HttpGet]
        public List<Bar> GetBarList()
        {
            return _bars.GetBar();
        }

        [HttpGet("{id}")]
        public Bar GetBarById(int id)
        {
            return _bars.GetBarById(id);
        }

        [HttpPost]
        public void InsertBar([FromBody] Bar value)
        {
            _bars.InsertBar(value);
        }

        [HttpPut("{id}")]
        public void UpdateBar(int id, [FromBody] Bar barData)
        {
            _bars.UpdateBar(id, barData);
        }

    }
}
