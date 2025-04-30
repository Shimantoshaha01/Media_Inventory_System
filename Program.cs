using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AssignmentCSE143
{    class Program
        {
        static List<Book> book = new List<Book>();
        static List<CD> cd = new List<CD>();
        static List<DVD> dvd = new List<DVD>();
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Here are some Media options for you:");
                Console.WriteLine("1. Add New Media Item.");
                Console.WriteLine("2. Remove Media Item.");
                Console.WriteLine("3. Update Media Item.");
                Console.WriteLine("4. Query Media Inventoris.");
                Console.WriteLine("5.Show Everything.");
                Console.WriteLine("6. Terminate program.");
                int Option = int.Parse(Console.ReadLine());
                switch (Option)
                {
                    case 1:
                        Console.WriteLine("We are in ADD options: ");
                        AddMediaOption();
                        break;
                    case 2:
                        Console.WriteLine("We are in REMOVE options: ");
                        RemoveMediaOption();
                        break;
                    case 3:
                        Console.WriteLine("We are in UPDATE options: ");
                        UpdateMedia();
                        break;
                    case 4:
                        Console.WriteLine("We are in Query inventory:");
                        QueryMediaInventory();
                        break;
                    case 5:
                        foreach (var result in book)
                        {
                            Console.WriteLine($"Title Name:{result.Title}   Author Name:{result.AuthorName}     Release Year:{result.Releaseyear}");
                        }
                        foreach (var result in cd)
                        {
                            Console.WriteLine($"Title Name:{result.Title}   Artist Name:{result.ArtistName}     Release Year:{result.Releaseyear}");
                        }
                        foreach (var result in dvd)
                        {
                            Console.WriteLine($"Title Name:{result.Title}   Director Name:{result.DirectorName}     Release Year:{result.Releaseyear}");
                        }
                        break;
                    case 6:
                        Console.WriteLine("Terminating the whole Progran.Bye Bye!");
                        break;
                    default:
                        Console.WriteLine("Invalid!Try Again.");
                        break;
                }

            }
            void AddMediaOption()
            {
                Console.WriteLine("You must fill up these Media details:");
                Console.Write("Title of The Media : ");
                string title = Console.ReadLine();
                Console.Write("Release Year: ");
                int releaseYear = int.Parse(Console.ReadLine());
                Console.WriteLine("Select Media type:");
                Console.WriteLine("1. Book");
                Console.WriteLine("2. CD");
                Console.WriteLine("3. DVD");
                int MediaTypeChoice = int.Parse(Console.ReadLine());

                switch (MediaTypeChoice)
                {
                    case 1:
                        Console.Write("The Author Name of the Book: ");
                        string author = Console.ReadLine();
                        book.Add(new Book { Title = title, AuthorName = author, Releaseyear = releaseYear });
                        break;
                    case 2:
                        Console.Write("The Artist Name of the Art: ");
                        string artist = Console.ReadLine();
                        cd.Add(new CD { Title = title, ArtistName = artist, Releaseyear = releaseYear });
                        break;
                    case 3:
                        Console.Write("The Director Name of the DVD: ");
                        string director = Console.ReadLine();
                        dvd.Add(new DVD { Title = title, DirectorName = director, Releaseyear = releaseYear });
                        break;
                    default:
                        Console.WriteLine("Invalid media type. Please try again.");
                        break;
                }

                Console.WriteLine("Media item added successfully!");
            }

            void RemoveMediaOption()
            {
                Console.WriteLine("And You must fill up these Media details for to Remove:");
                Console.Write("Title of The Media : ");
                string title = Console.ReadLine();
                Console.Write("Release Year: ");
                int releaseYear = int.Parse(Console.ReadLine());
                Console.WriteLine("For removing name you have to choose one of this:");
                Console.WriteLine("1. Book");
                Console.WriteLine("2. CD");
                Console.WriteLine("3. DVD");
                int MediaTypeChoice = int.Parse(Console.ReadLine());
                switch (MediaTypeChoice)
                {
                    case 1:
                        Console.Write("Author Name:");
                        string author = Console.ReadLine();
                        book.RemoveAll(book => book.Title == title && book.Releaseyear == releaseYear && book.AuthorName == author);
                        break;

                    case 2:
                        Console.Write("Artist Name:");
                        string artist = Console.ReadLine();
                        cd.RemoveAll(cd => cd.Title == title && cd.Releaseyear == releaseYear && cd.ArtistName == artist);
                        break;
                    case 3:
                        Console.Write("Director Name:");
                        string direct = Console.ReadLine();
                        dvd.RemoveAll(dvd => dvd.Title == title && dvd.Releaseyear == releaseYear && dvd.DirectorName == direct);
                        break;
                    default:
                        Console.WriteLine("It is invalid.Please try Again.");
                        break;
                }


            }
            void UpdateMedia()
            {
                Console.WriteLine("The Title Name:");
                string updateTitle = Console.ReadLine();
                Console.WriteLine("Updates you want to make in-");
                Console.WriteLine("1. Book");
                Console.WriteLine("2. CD");
                Console.WriteLine("3. DVD");
                int MediaTypeChoice = int.Parse(Console.ReadLine());
                switch (MediaTypeChoice)
                {
                    case 1:
                        Console.WriteLine("Enter the new name of Author Name");
                        string UpdateName = Console.ReadLine();
                        Console.WriteLine("Enter the new Release year:");
                        int Updateyear = int.Parse(Console.ReadLine());
                        Book update = book.FirstOrDefault(book => book.Title == updateTitle);
                        if (update != null)
                        {
                            update.AuthorName = UpdateName;
                            update.Releaseyear = Updateyear;

                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter the new name of Artist Name");
                        string UpdateName1 = Console.ReadLine();
                        Console.WriteLine("Enter the new Release year:");
                        int Updateyear1 = int.Parse(Console.ReadLine());
                        CD update1 = cd.FirstOrDefault(cd => cd.Title == updateTitle);
                        if (update1 != null)
                        {
                            update1.ArtistName = UpdateName1;
                            update1.Releaseyear = Updateyear1;

                        }
                        break;
                    case 3:
                        Console.WriteLine("Enter the  new name of Director Name");
                        string UpdateName2 = Console.ReadLine();
                        Console.WriteLine("Enter the new Release year:");
                        int Updateyear2 = int.Parse(Console.ReadLine());
                        DVD update2 = dvd.FirstOrDefault(dvd => dvd.Title == updateTitle);
                        if (update2 != null)
                        {
                            update2.DirectorName = UpdateName2;
                            update2.Releaseyear = Updateyear2;

                        }
                        break;
                    default:
                        Console.WriteLine("Try Again");
                        break;
                }

            }
            void QueryMediaInventory()
            {
                Console.WriteLine("Select media type to query:");
                Console.WriteLine("1. Book");
                Console.WriteLine("2. CD");
                Console.WriteLine("3. DVD");

                int mediaTypeChoice = int.Parse(Console.ReadLine());

                switch (mediaTypeChoice)
                {
                    case 1:
                        QueryBooks();
                        break;
                    case 2:
                        QueryCDs();
                        break;
                    case 3:
                        QueryDVD();
                        break;
                    default:
                        Console.WriteLine("Invalid! Please try again.");
                        break;
                }
            }
            void QueryBooks()
            {
                Console.Write("You want search by 1.Title/2.Author name/3.Release Year: ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        string title = Console.ReadLine();

                        var foundBooks = book.Where(book => book.Title == title).ToList();

                        foreach (var books in foundBooks)
                        {
                            Console.WriteLine($"Title: {books.Title}, Author: {books.AuthorName}, Release Year: {books.Releaseyear}");
                        }
                        break;

                    case 2:
                        string Author = Console.ReadLine();

                        var foundBooks1 = book.Where(book => book.AuthorName == Author).ToList();

                        foreach (var books in foundBooks1)
                        {
                            Console.WriteLine($"Title: {books.Title}, Author: {books.AuthorName}, Release Year: {books.Releaseyear}");
                        }
                        break;
                    case 3:
                        int year = int.Parse(Console.ReadLine());
                        var foundBooks2 = book.Where(book => book.Releaseyear == year).ToList();

                        foreach (var books in foundBooks2)
                        {
                            Console.WriteLine($"Title: {books.Title}, Author: {books.AuthorName}, Release Year: {books.Releaseyear}");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid!");
                        break;
                }
            }
            void QueryCDs()
            {

                Console.Write("You want search by 1.Title/2.Author name/3.Release Year: ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        string title = Console.ReadLine();

                        var foundcd = cd.Where(cd => cd.Title == title).ToList();

                        foreach (var cds in foundcd)
                        {
                            Console.WriteLine($"Title: {cds.Title}, Artist: {cds.ArtistName}, Release Year: {cds.Releaseyear}");
                        }
                        break;

                    case 2:

                        string Artist = Console.ReadLine();

                        var foundcd1 = cd.Where(cd => cd.ArtistName == Artist).ToList();

                        foreach (var cds in foundcd1)
                        {
                            Console.WriteLine($"Title: {cds.Title}, Artist: {cds.ArtistName}, Release Year: {cds.Releaseyear}");
                        }
                        break;

                    case 3:

                        int year = int.Parse(Console.ReadLine());

                        var foundcds = cd.Where(cd => cd.Releaseyear == year).ToList();

                        foreach (var cds in foundcds)
                        {
                            Console.WriteLine($"Title: {cds.Title}, Artist: {cds.ArtistName}, Release Year: {cds.Releaseyear}");
                        }
                        break;
                }


                }
                void QueryDVD()
                {

                    Console.Write("You want search by 1.Title/2.Author name/3.Release Year: ");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            string title = Console.ReadLine();

                            var founddvd = dvd.Where(dvd => dvd.Title == title).ToList();

                            foreach (var dvd in founddvd)
                            {
                                Console.WriteLine($"Title: {dvd.Title}, Director: {dvd.DirectorName}, Release Year: {dvd.Releaseyear}");
                            }
                            break;
                        case 2:

                            string direct = Console.ReadLine();

                            var founddvd1 = dvd.Where(dvd => dvd.DirectorName == direct).ToList();

                            foreach (var dv in founddvd1)
                            {
                                Console.WriteLine($"Title: {dv.Title}, Director: {dv.DirectorName}, Release Year: {dv.Releaseyear}");
                            }
                            break;

                        case 3:

                            int year = int.Parse(Console.ReadLine());

                            var founddvd2 = dvd.Where(dvd => dvd.Releaseyear == year).ToList();

                            foreach (var dv in founddvd2)
                            {
                                Console.WriteLine($"Title: {dv.Title}, Director: {dv.DirectorName}, Release Year: {dv.Releaseyear}");
                            }
                            break;
                    }

                }
            }
        }
    }



