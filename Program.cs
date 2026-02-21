using ConwayGameOfLife;

internal class Program
{
    private static void Main(string[] args)
    {
        Board board = new Board();

        board.PrintBoard();

        int neighbor = board.CountNeighbors(5, 5);

        Console.WriteLine($"The spot (5, 5) has {neighbor} neighbors");
    }
}