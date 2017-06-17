using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwilightMapGenerator.Model
{
	public interface ISystem : IComparable<ISystem>
	{
		double x { get; set; }

		double y { get; set; }

		int r { get; set; }

		int q { get; set; }

		string Panel { get; set; }

		string GetName();

		double GetValue();
	}
}
