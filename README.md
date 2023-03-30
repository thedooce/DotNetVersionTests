Steps Taken to Create Prototype:

	1. Create solution 'VersionTests' as a blank solution.

	2. Create a new project that represents .NET Standard 2.0 libraries. This is what we *should* to convert our current libraries to.
		a. Create new project -> search 'library' -> select option "Class Library: A project for creating a class library that targets .NET or .NET Standard". 
		b. When choosing the version, select .NET Standard 2.0.
		c. Implement Hello World.
		d. Confirm work by building solution.

	3. Create a new project that represents .NET 6.0 libraries. This represents what we *believed* we wanted to upgrade our libraries to.
		a. Repeat step 2, but this time select .NET 6.0 while creating the project.

	4. Create a new project that represents .NET Framework 4.6.1 libraries. This represents our current libraries as they are now.
		a. Create new project -> search 'library' -> select option Class Library (.NET Framework): A project for creating a C# class library (.dll)"
		b. When choosing the version, select .NET Framework 4.6.1
		c. Implement Hello World to display version.
		d. Confirm work by building solution.

	5. Create a new project as a .NET Framework 4.6.1 console app. This represents our current console apps (services) such as Decoder, Export, Import.
		a. Create new project -> search 'console' -> select option Console App (.NET Framework): A project for creating a command-line application'.
		b. When choosing the version, select .NET Framework 4.6.1
		c. Add References from the projects from steps 2, 3, and 4 into the console app.
		d. Build solution. This should produce an Error:
			Project '..\Net6Libraries\Net6Libraries.csproj' targets 'net6.0'. It cannot be referenced by a project that targets '.NETFramework,Version=v4.6.1'.
		e. It should also throw a Warning:
			The project 'Net6Libraries' cannot be referenced. The referenced project is targeted to a different framework family (.NETCoreApp)			

	-----------

	This represents the issue at hand - how do we upgrade our libraries before our applications, without breaking support?
	It seems the answer to this is either (upgrade to 6.0 AND multitarget) OR (upgrade to .NET Standard 2.0).

	Lets try multi targetting in our 6.0 project.
		e. Implement multi targetting in 6.0 Library project!
		f. Try rebuilding. Success? Continue. Fail? Research more solutions.
		g. In the console app main() method, try calling both Libraries Hello world. Log what happens!
	
	x. Create a new project as a .NET 6.0 console app, repeat step 4?

Objectives
	1. Create a program in which a 4.6.1 console app can use a 6.0 library.
		a. This original objective may be slightly incorrect. I think newly defined goal here is to have a 4.6.1 console app use both 
			.NET Standard 2.0 library and a 4.6.1 library. This gives us the backwards compatibility we need.
		b. See https://learn.microsoft.com/en-us/dotnet/standard/net-standard?tabs=net-standard-2-0

Questions to answer/problems to solve:
	1. We need to update our libraries BEFORE the console apps. Can we convert our libraries from 4.6.1 to Standard 2.0 and then 
		use multitargetting for that library, so that it can be consumed by both a 4.6.1 console app AND a 6.0 console app?
	2. Once we convert our libraries to Standard 2.0, what are the benefits to putting them into nuget packages?
	3. Generate a dependency graph for a basic library and a basic service.