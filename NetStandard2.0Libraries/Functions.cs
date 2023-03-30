using System;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace NetStandard2Libraries
{
	/// <summary>
	/// This class is within a Class Library project that was created targeting .NET Standard 2.0.
	/// The purpose of this is to show what we upgrade our current Bendix/Iteris Library projects TO.
	/// The lowest-level libraries would be converted first, so this represents a lowest-level library of ours such as 
	/// </summary>
	public class Functions
	{
		public void HelloWorld()
		{
			Console.WriteLine( "=========================================================================================" );
			Console.WriteLine( $"Hello World from the .NET Standard 2.0 class library. This library only targets .NET Standard 2.0" );
			Console.WriteLine( "=========================================================================================" );
		}
	}
}
