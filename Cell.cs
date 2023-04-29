namespace TweakersPuzzle;

public class Cell
{
	public int Number { get; }
	public int X { get; }
	public int Y { get; }

	public Cell(int number, int x, int y)
	{
		Number = number;
		X = x;
		Y = y;
	}
}