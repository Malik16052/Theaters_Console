
namespace Base.cs;

internal abstract class Base
{

    int say = 0;


    protected int Id { get; set; }
    protected string Name { get; set; }

    public Base(string name)
    {
        say++;
        Id = say;
        Name = name;

    }
}



internal class Movie : Base
{
    public string Director { get; set; }
    public string Genre { get; set; }
    public int AgeLimit { get; set; }

    public Movie(string name, string director, string genre, int age_limit) : base(name)
    {
        Director = director;
        Genre = genre;
        AgeLimit = age_limit;
        if (age_limit < 18 && age_limit > 16)
            Console.WriteLine("Film 18 yas ve yuxaridir.");
        else if (age_limit < 16 && age_limit > 13)
            Console.WriteLine("Film 16 yas ve yuxaridir.");
        else if (age_limit < 13)
            Console.WriteLine("Film 13 yas ve yuxaridir.");
        else
            Console.WriteLine("Yas cox kicikdir.");

    }


}

internal class Genre : Base
{
    public Genre(string name) : base(name)
    {
    }


}

internal class Theater : Base
{
    public Movie[] _movies;
    public Theater(string name) : base(name)
    {
        _movies = new Movie[0];
    }

    public void AddMovie(Movie movie)
    {
        if (_movies.Contains(movie))
        {
            Console.WriteLine("Bu film artig reperturada movcuddur.");
            return;
        }

        Array.Resize(ref _movies, _movies.Length + 1);
        _movies[^1] = movie;
        Console.WriteLine("Film reperturaya ugurla elave olundu.");
    }

    public void ListAllMovies()
    {
        Console.WriteLine("Reperturadaki filmler: ");
        foreach (var item in _movies)
        {
            Console.WriteLine(item);
        }
    }

    public void RemoveMovie(Movie movie)
    {

        for (int i = 0; i < _movies.Length; i++)
        {
            if (_movies[i] != movie)
            {
                Console.WriteLine("Daxil etdiyiniz film repertuarda olmadigi ucun silinmek funksiyasi islemir");
            }
            else if (_movies[i] == movie)
            {
                Console.WriteLine("Film silinir ....");
                _movies[i] = null;
                Console.WriteLine($"{movie} Filmi silindi!");
            }

        }
    }

}