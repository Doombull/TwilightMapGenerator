using System;
using System.Collections.Generic;
using System.Configuration;
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
			double sectorValueTarget = Double.Parse(ConfigurationSettings.AppSettings["SectorValueTarget"]);
			double sectorValueMargin = Double.Parse(ConfigurationSettings.AppSettings["SectorValueMargin"]);
			double systemValueMax = Double.Parse(ConfigurationSettings.AppSettings["SystemValueMax"]);

			var sectors = new List<Sector>();
			var blockingSystems = SystemFactory.GetBlockingSystems();

			var allSystems = (from s in SystemFactory.GetPlanetSystems()
							  where s.GetValue() <= systemValueMax
							  select s).ToList();

			for (int i = 0; i < 6; i++)
			{
				Sector sector = new Sector();
				sectors.Add(sector);

				sector.GetSystems(allSystems, blockingSystems, i + 1, sectorValueTarget, sectorValueMargin);

				Console.WriteLine("*** Player {0}: {1} ***", i, sector.Value);
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
