using ConwayGameOfLife;

internal class Program
{
    private static void Main(string[] args)
    {
        Board board = new Board();

        int generations = 20;

        for (int i = 0; i <= generations; i++)
        {
            Console.WriteLine($"\nGeneration {i}");
            board.PrintBoard();
            board.NextGeneration();
            Thread.Sleep(200);
        }

        //board.PrintBoard();

        //int neighbor = board.CountNeighbors(5, 5);

        //Console.WriteLine($"The spot (5, 5) has {neighbor} neighbors");
    }
}