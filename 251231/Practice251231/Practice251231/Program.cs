using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice251231
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int mask = 9, rosaries = 7, shard = 425, playtime = 427;
			string crast = "basic", map = "BONE BOTTOM";


			Console.WriteLine("┌───────────────────────┐");
			Console.WriteLine("│\t\t\t│");
			Console.WriteLine($"│{crast} {mask}\t\t│");
			Console.WriteLine("│\t\t\t│");
			Console.WriteLine($"│rosaries: {rosaries}\t\t│");
			Console.WriteLine($"│shard: {shard}\t\t│");
			Console.WriteLine($"│\t\t\t│");
			Console.WriteLine("│\t\t\t│");
			Console.WriteLine("│\t\t\t│");
			Console.WriteLine($"│\t\t   {playtime / 60}H {playtime % 60}M│");
			Console.WriteLine($"│\t     {map}│");
			Console.WriteLine("│\t\t\t│");
			Console.WriteLine("└───────────────────────┘");


		}
	}
}
