namespace TweakersPuzzle;

public class Grid
{
	public Cell[][] Cells { get; }

	public Grid()
	{
		Cells = new[]
		{
			new []{ new Cell(1, 0, 0), new Cell(20, 1, 0), new Cell(6, 2, 0), new Cell(11, 3, 0), new Cell(3, 4, 0), new Cell(18, 5, 0) },
			new []{ new Cell(26, 0, 1), new Cell(16, 1, 1), new Cell(11, 2, 1), new Cell(12, 3, 1), new Cell(13, 4, 1), new Cell(25, 5, 1) },
			new []{ new Cell(13, 0, 2), new Cell(9, 1, 2), new Cell(13, 2, 2), new Cell(17, 3, 2), new Cell(8, 4, 2), new Cell(13, 5, 2) },
			new []{ new Cell(7, 0, 3), new Cell(17, 1, 3), new Cell(3, 2, 3), new Cell(25, 3, 3), new Cell(14, 4, 3), new Cell(24, 5, 3) },
			new []{ new Cell(18, 0, 4), new Cell(12, 1, 4), new Cell(5, 2, 4), new Cell(6, 3, 4), new Cell(10, 4, 4), new Cell(17, 5, 4) },
			new []{ new Cell(19, 0, 5), new Cell(2, 1, 5), new Cell(4, 2, 5), new Cell(16, 3, 5), new Cell(4, 4, 5), new Cell(11, 5, 5) },
			new []{ new Cell(10, 0, 6), new Cell(6, 1, 6), new Cell(18, 2, 6), new Cell(21, 3, 6), new Cell(7, 4, 6), new Cell(22, 5, 6) },
			new []{ new Cell(25, 0, 7), new Cell(22, 1, 7), new Cell(4, 2, 7), new Cell(14, 3, 7), new Cell(12, 4, 7), new Cell(21, 5, 7) },
			new []{ new Cell(9, 0, 8), new Cell(23, 1, 8), new Cell(8, 2, 8), new Cell(23, 3, 8), new Cell(2, 4, 8), new Cell(18, 5, 8) },
			new []{ new Cell(24, 0, 9), new Cell(16, 1, 9), new Cell(15, 2, 9), new Cell(6, 3, 9), new Cell(14, 4, 9), new Cell(3, 5, 9) },
			new []{ new Cell(11, 0, 10), new Cell(25, 1, 10), new Cell(14, 2, 10), new Cell(21, 3, 10), new Cell(18, 4, 10), new Cell(20, 5, 10) },
			new []{ new Cell(1, 0, 11), new Cell(12, 1, 11), new Cell(24, 2, 11), new Cell(6, 3, 11), new Cell(4, 4, 11), new Cell(13, 5, 11) },
			new []{ new Cell(16, 0, 12), new Cell(19, 1, 12), new Cell(23, 2, 12), new Cell(11, 3, 12), new Cell(7, 4, 12), new Cell(26, 5, 12) },
			new []{ new Cell(19, 0, 13), new Cell(25, 1, 13), new Cell(18, 2, 13), new Cell(25, 3, 13), new Cell(9, 4, 13), new Cell(27, 5, 13) },
		};
	}
}