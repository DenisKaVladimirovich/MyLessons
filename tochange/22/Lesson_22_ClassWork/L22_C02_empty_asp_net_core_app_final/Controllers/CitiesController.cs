using System.Linq;
using Microsoft.AspNetCore.Mvc;
using L22_C02_empty_asp_net_core_app_final.DataStore;
using L22_C02_empty_asp_net_core_app_final.Moldels;

namespace L22_C02_empty_asp_net_core_app_final.Controllers
{
	[Route("/api/cities")]
	public class CitiesController : Controller
	{
		[HttpGet]
		public IActionResult GetCities()
		{
			var citiesDataStore = CitiesDataStore.GetInstance();
			return Ok(citiesDataStore.Citites);
		}

		[HttpGet("{id}", Name = "GetCity")]
		public IActionResult GetCity(int id)
		{ 
			var citiesDataStore = CitiesDataStore.GetInstance();
			var city = citiesDataStore
				.Citites
				.Where(x => x.Id == id)	
				.FirstOrDefault();

			if (city == null)
			{
				return NotFound();
			}

			return Ok(city);
		}

		[HttpPost()]
		public IActionResult CreateCity([FromBody] CityCreateModel city)
		{
			if (city == null)
			{
				return BadRequest();
			}

			var citiesDataStore = CitiesDataStore.GetInstance();
			int newCityId = citiesDataStore.Citites.Max(x => x.Id) + 1;

			var newCity = new CityGetModel
			{
				Id = newCityId,
				Name = city.Name,
				Description = city.Description,
				NumberOfPointsOfInterests = city.NumberOfPointsOfInterests
			};

			citiesDataStore.Citites.Add(newCity);

			return CreatedAtRoute("GetCity", new { id = newCityId }, newCity);
		}
	}
}