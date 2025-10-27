
namespace Base.cs;

internal class Program
{
    static Theater theater = new Theater[0];
    static Genre _genre = new Genre[0];
    static Movie _yeniFilm = new Movie[0];

    static void Main()
    {
    restart:
        Console.WriteLine("1.Yeni teatr yarat");
        Console.WriteLine("2.Yeni janr yarat");
        Console.WriteLine("3.Yeni film yarat");
        Console.WriteLine("4.Teatra daxil ol");
        Console.WriteLine("5.Programdan cix");

        string input = Console.ReadLine();

        switch (input)
        {
            case "1":
                Console.WriteLine("Teatr adini daxil edin: ");
                string yeniTeatr = Console.ReadLine();
                Theater theaters = new Theater(yeniTeatr);
                Array.Resize(ref theater, theater.Length + 1);
                theater[^1] = theaters;
                Console.WriteLine($"{theaters} ugurla yaradildi!");
                break;

            case "2":
                Console.WriteLine("Janr adini daxil edin: ");
                string yeniJanr = Console.ReadLine();
                Genre genres = new Genre(yeniJanr);
                Array.Resize(ref _genre, _genre.Length + 1);
                _genre[^1] = genres;
                Console.WriteLine($"{genres} janri ugurla yaradildi!");
                break;

            case "3":
                Console.WriteLine("Film adini daxil edin: ");
                string name = Console.ReadLine();
                Console.WriteLine("Rejissorun adini daxil edin: ");
                string director = Console.ReadLine();
                Console.WriteLine("Movcud janrlardan birini secin: ");
                foreach (var item in genres) 
                { 
                Console.WriteLine(item);
                }

                Console.WriteLine($"{_yeniFilms} filmi ugurla yaradildi!");
                break;


            case "4":



                break;

            case "5":
                Console.WriteLine("Programdan ugurla cixildi");
                return;
            default:
                Console.WriteLine("Duzgun deyer verilmeyib");
                break;
            

        }
        goto restart;
    }
}
