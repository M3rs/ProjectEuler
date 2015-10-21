using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
	class Program
	{
		static void Main(string[] args)
		{
			Problems.Problem1 prob = new Problems.Problem1();

			Console.WriteLine(prob.Answer());
		}
	}
}
