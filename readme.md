# Todo List Demo Application
The purpose of this app is to create a small vertical slice application to test
some new technology integrations and stacks as they evolve.

First Iteration
---------------
Here is what the ap uses now (in its very primitive state)

- ASP.NET Core 1 with MVC 6
	Build on the latest RC version of ASP.NET 5 (or Core 1 Rename). Utilizing "src" folder style.
	Liking the wwwroot structure, but I refuse to checkin files stored in this root (don't duplicate generated assets).
- Entity Framework 7
	While its still the same EF rebuilt for Core 1, there are thing that have changed. Most notably the missing automatic database initializer and automatic migrations....better get use to DNVM and DNX. 
	One bug I have found thus far is that DNX doesn't seem to want to update a migration when they are in different projects. As such all my EF models and context have been moved inside the web project until I can resolve it.
- SASS
	Long time fan of LESS, but want to get experience with SASS as it seems to be trending a bit ahead as industry standard.
- Bootstrap 4
	Huge fan of Bootstrap 3, so naturally wanted to see what Bootstrap 4 had in it....its got flexbox, some more fluidity...hmm...
- Grunt / NPM / Bower
	Enjoy all of this tool stack, but want experience with it in Visual Studio and how it integrates with ASP.NET Core 1.

Next Iterations
---------------

Plan to evolve this demo with the following technologies / libraries:
- TypeScript
	Try angular 1.x out in a conversion to TypeScript.
- Gulp
	Always used Grunt, but Gulp is pretty hot right now, lets give it a try...
- Angular 2
	Convert Angular 1.x to 2.x beta to give 'er a try.
- ngUpgrade
	Testing Angular 1.x with 2.x components together (this will be important for upgrading apps).
- Signalr 3
	It won't be released with ASP.NET Core 1, but there is a beta of it...lets add it into the mix.
- Ionic Mobile 1.x
	Hook up a simple Ionic version of the app connected to the todos1
- Ionic Mobile 2.x
	Hook up a an upraded Ionic 2.x version (not released) when time is right to test migration.
- Identity Server / OAuth Support