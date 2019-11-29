using System.Collections.Generic;
using L22_C02_empty_asp_net_core_app_final.Moldels;

namespace L22_C02_empty_asp_net_core_app_final.DataStore
{
	public class CitiesDataStore
	{
		private static CitiesDataStore _store;

		public List<CityGetModel> Citites { get; private set; }

		private CitiesDataStore()
		{
			Citites = new List<CityGetModel>
			{
				new CityGetModel
				{
					Id = 1,
					Name = "Moscow",
					Description = "The capital of Russia"
				},
				new CityGetModel
				{
					Id = 2,
					Name = "New York",
					Description = "The one of the biggest cities in the world"
				}
			};
		}

		public static CitiesDataStore GetInstance()
		{
			if (_store == null)
			{
				_store = new CitiesDataStore();
			}

			return _store;
		}
	}
}
