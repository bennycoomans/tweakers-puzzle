namespace TweakersPuzzle;

public class Solver
{
	private readonly Grid _grid;

	private static readonly List<Tuple<int, int>> _directions = new()
	{
		new(0, 1),
		new(0, -1),
		new(1, 0),
		new(-1, 0)
	};

	public Solver(Grid grid)
	{
		_grid = grid;
	}

	public void Solve()
	{
		int x = 0;
		int y = 0;
		var firstCell = _grid.Cells[y][x];
		foreach (var direction in _directions)
		{
			int newCellX = x + direction.Item1;
			int newwCellY = y + direction.Item2;
			var allVisitedCells = TrySolve(newCellX, newwCellY, new List<Cell> { firstCell });
			if (allVisitedCells != null)
			{
				foreach (var cell in allVisitedCells)
				{
					Console.WriteLine($"X: {cell.X}, Y: {cell.Y}, Number: {cell.Number}");
				}
				break;
			}
		}
	}

	public List<Cell>? TrySolve(int newCellX, int newCellY, List<Cell> visitedCells)
	{
		if (newCellX < 0 || newCellY < 0 || newCellX >= _grid.Cells[0].Length || newCellY >= _grid.Cells.Length) return null;
		var nextCell = _grid.Cells[newCellY][newCellX];
		if (visitedCells.Any(x => x == nextCell || x.Number == nextCell.Number)) return null;
		var newVisitedCells = new List<Cell>(visitedCells) { nextCell };
		if (nextCell.Number == 27)
		{
			if (newVisitedCells.Count < 27) return null;
			
			if (newVisitedCells.Count > 27) throw new InvalidOperationException("More than 27 visited cells???");
			
			return newVisitedCells;
		}

		foreach (var direction in _directions)
		{
			int nextNextCellX = newCellX + direction.Item1;
			int nextNextCellY = newCellY + direction.Item2;
			var totalVisitedCells = TrySolve(nextNextCellX, nextNextCellY, newVisitedCells);
			if (totalVisitedCells != null) return totalVisitedCells;
		}

		return null;
	}
}