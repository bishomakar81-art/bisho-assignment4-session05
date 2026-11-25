using System;
class program
{
    static void Main(string[] args)
    {

        // Q1 , this causes an error because the password is private 
        book myBook = new book();

        //Q2
        Console.WriteLine(myBook.CopiesInStock);

        //Q3
        myBook.Title = "c# basics";
        Console.WriteLine(myBook.Title);

        //Q4
        myBook.Genre = Genre.science;
        Console.WriteLine(myBook.Genre);

        //Q5
        Console.WriteLine((int)Genre.Fiction);
        Console.WriteLine((int)Genre.NonFiction);
        Console.WriteLine((int)Genre.science);

        //Q6
        int genreNumber = 1;
        Genre selectedGenre = (Genre)genreNumber;
        Console.WriteLine(selectedGenre);

        //Q7
        Genre genre = Genre.Fiction;
        string genreName = genre.ToString();
        Console.WriteLine(genreName);


        //Q8
        string genreText = "Science";
        genre = (Genre)Enum.Parse(typeof(Genre), genreText, true);
        Console.WriteLine(genre);

        //Q9 

        string genreText2 = "mystery";
        if (Enum.TryParse(genreText2, true, out Genre parsedGenre))
        {
            Console.WriteLine(parsedGenre);
        }
        else
        {
            Console.WriteLine("unknown genre");
        }


    }

}



enum Genre
{
    Fiction,
    NonFiction,
    science

}


class book
{
   private  string password = "secret";

    internal int CopiesInStock = 5;
    public string Title;

    public Genre Genre { get; set; }
}






