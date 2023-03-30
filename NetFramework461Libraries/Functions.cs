using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework461Libraries
{
	/// <summary>
	/// This is a Class Library project that was created targeting .NET Framework 4.6.1, which all 
	/// of our libraries CURRENTLY target.
	/// </summary>
	public class Functions
    {
		public void HelloWorld()
		{
			Console.WriteLine( "=========================================================================================" );
			Console.WriteLine( $"Hello World from the .NET Framework 4.6.1 class library. This library only targets .NET Framework 4.6.1" );
			Console.WriteLine( "=========================================================================================" );
		}
    }
}
