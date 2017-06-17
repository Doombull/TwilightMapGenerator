using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

using TwilightMapGenerator;
using TwilightMapGenerator.Model;

namespace GeneratorHarness
{
	class Program
	{
		static void Main(string[] args)
		{
			var sectors = new List<Sector>();
			var systems = SystemFactory.GetPlanetSystems();

			for (int i = 0; i < 6; i++)
			{
				Sector sector = new Sector();
				sectors.Add(sector);

				sector.GetSystems(systems);
				sector.Systems.Sort();

				Console.WriteLine("*** Player {0} ***", i);
				foreach (ISystem system in sector.Systems)
				{
					Console.WriteLine("{0}: {1}", system.GetName(), system.GetValue());
				}

				Console.WriteLine("");
				Console.WriteLine("");
			}

			AstralVaultMap generator = new AstralVaultMap(sectors);
			string map = generator.Generate();

			File.WriteAllText("D:\\output.t3m", map);

			Console.WriteLine("");
			Console.WriteLine("");
			Console.WriteLine("*** Generated Map ***");
			Console.WriteLine(map);
			Console.WriteLine("");
			Console.WriteLine("");

			Console.ReadLine();
		}
	}
}
