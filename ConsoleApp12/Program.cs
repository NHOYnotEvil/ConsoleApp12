namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int picturesInAlbum = 52;
            int picturesInRow = 3;
            int filledSerises = picturesInAlbum / picturesInRow;
            int remainingPictures = picturesInAlbum % picturesInRow;
            Console.WriteLine(filledSerises);
            Console.WriteLine(remainingPictures);
        }
    }
}