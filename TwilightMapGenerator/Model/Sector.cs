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

		public Sector()
		{
			Systems = new List<ISystem>(6);
		}

		public void GetSystems(List<ISystem> allSystems) {
			
			for (int i = 0; i < 6; i++)
			{
				int number = Random.Next(0, allSystems.Count);

				Systems.Add(allSystems[number]);
				allSystems.RemoveAt(number);
			}
		}
	}
}
