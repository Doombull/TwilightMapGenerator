using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwilightMapGenerator.Model
{
	public class Sector
	{
		public List<ISystem> Systems { get; set; }
		public double Value { get; set; }

		public void GetSystems(List<ISystem> allSystems, List<ISystem> blockingSystems, int player, double targetValue, double margin) {

			while (Value < targetValue - margin)
			{
				Value = 0;
				Systems = new List<ISystem>(6);

				for (int i = 0; i < 4; i++)
				{
					var legalSystems = (from s in allSystems
										where s.GetValue() <= targetValue - Value
										select s).Except(Systems).ToList();

					var system = legalSystems[Random.Next(0, legalSystems.Count)];

					Systems.Add(system);

					Value += system.GetValue();
				}
			}

			foreach (ISystem system in Systems)
				allSystems.Remove(system);

			var blockingSystem = blockingSystems[Random.Next(0, blockingSystems.Count)];

			Systems.Add(blockingSystem);
			blockingSystems.Remove(blockingSystem);

			Systems.Add(new HomeSystem(player));
			Systems.Shuffle();
		}
	}
}
