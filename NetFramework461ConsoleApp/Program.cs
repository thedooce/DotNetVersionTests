using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework461ConsoleApp
{
	/// <summary>
	/// The purpose of this project is to demonstrate our current console apps (services), such as Decoder Service, Export Service, etc.
	/// and whether or not they can they can work with both the .NET Standard 2.0 libraries AND the .NET Framework 4.6.1 libraries.
	/// </summary>
	internal class Program
	{
		static void Main( string[] args )
		{
			NetStandard2Libraries.Functions standard2Lib = new NetStandard2Libraries.Functions();
			NetFramework461Libraries.Functions framework461Lib = new NetFramework461Libraries.Functions();

			standard2Lib.HelloWorld();
			framework461Lib.HelloWorld();

		}
	}
}
