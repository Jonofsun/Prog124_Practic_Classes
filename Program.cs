namespace Prog124_Practic_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bike bike = new Bike("Honda", "Electric", "black", 2);
            Car car = new Car("Toyota", "Camery", 1999, "Tan", 90000);
            Anime anime = new Anime("Clannad", "April 28, 2004", 90, "Tomoyo Sakagami");
            Console.WriteLine(car._make + " " + car._modle + " " + car._year + " " + car._color + " " + car._mileage);
            Console.WriteLine($"{bike.Brand} {bike.Type} {bike.Color} {bike.NumberOfWheels}");
            Console.WriteLine($"Anime: {anime.Name} \nRealesed: {anime.ReleaseDate} \nRateing: {anime.Rateing} \nMy Favorite Character is {anime.FavoriteCharacter}");


        }
    }
}