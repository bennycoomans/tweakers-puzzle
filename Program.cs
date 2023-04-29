// See https://aka.ms/new-console-template for more information

using TweakersPuzzle;

try
{
	var grid = new Grid();
	var solver = new Solver(grid);
	solver.Solve();
}
catch (Exception ex)
{
	Console.WriteLine(ex.Message);
}
