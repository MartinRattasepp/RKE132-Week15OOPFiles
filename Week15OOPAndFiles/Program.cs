
List<Movie> myMovies = new List<Movie>();
string[] data = GetDataFromFile();
//ReadDataFromArray(data);

foreach (string line in data)
{
    string[] teapArray = line.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
    Movie newMovie = new Movie(teapArray[0], teapArray[2]);
    myMovies.Add(newMovie);
}

foreach (Movie movie in myMovies)
{
    Console.WriteLine($"One of my favourite movies {movie.Title} was released in {movie.Year}.");
}

static string[] GetDataFromFile()
{
    string filePath = @"C:\Games\Data\movies.txt";
    return File.ReadAllLines(filePath);
}
static void ReadDataFromArray(string[] someArray)
{
    foreach (string line in someArray)
    {
        Console.WriteLine(line);
    }
}

class Movie
{
    string title;
    string year;
    public string Title
    {
        get { return title; }
    }
    public string Year
    {
        get { return year; }
    }
    public Movie(string _title, string _year)
    {
        title = _title;
        year = _year;
    }
}