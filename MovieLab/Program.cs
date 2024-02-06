using MovieLab;
//using Validator;

List<Movies> allMovies = new List<Movies>()
{
    new Movies ("How to trian your Dragon", "Fantasy"),
    new Movies ("Pokemon" , "Anime"),
    new Movies ("Spider-Man", "Fantasy"),
    new Movies ("Inception", "Sci-Fi"),
    new Movies ("The Dark Knight", "Action"),
    new Movies ("The Matrix", "Sci-Fi"),
    new Movies ("Titanic", "Romance"),
    new Movies ("Cinderella", "Romance"),
    new Movies ("Hacksaw Ridge", "War"),
    new Movies ("Forest Gump", "AutoBiography")

};

bool runProgram = true;
while (runProgram)
{

    Console.WriteLine("Please choose a movie genre.");
    string category = Console.ReadLine().ToLower().Trim();

    List<Movies> choice = allMovies.Where(m => m.Category.ToLower().Trim() == category).ToList();

    foreach (Movies m in choice)
    {
        Console.WriteLine($"{m.Title} {m.Category}");
    }

    runProgram = Validator.GetContinue();

}