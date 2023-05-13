using librarywork.src.manager;
using librarywork.src.models;

namespace LibraryWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME");
            DatabaseManager manager = new DatabaseManager();

            //add 1 author to database 
            /* Author authorTest = new Author() { Id = 3, Name = "lisa", Surname = "Can" };
            manager.CreateAuthor(authorTest); */
            //

            //add multiple authors to database
            /*  List<Author> authorListTest = new List<Author>() {
                 new Author() { Id = 43, Name = "Emre", Surname = "Toklu" },
                 new Author() { Id = 13, Name = "Caren", Surname = "Flow" },
                 new Author() { Id = 32, Name = "Adam", Surname = "Shimi" }
             };
             manager.CreateAuthors(authorListTest); */
            //

            //add 1 book to database
            /* Book bookTest = new Book()
            {
                Id = 2,
                Name = "Fırtına ötesinde",
                AuthorId = 43,
                PublishYear = "22.02.2022",
                Title = "Bilim kurgu dünyasına yeni bir bakış",
            };
            manager.CreateBook(bookTest); */
            //


            //add multiple books to database
            /* List<Book> bookListTest = new List<Book>
            {
            new Book()
                {
                    Id = 4,
                    AuthorId = 32,
                    Name = "Fırtına dünyası",
                    PublishYear = "02.02.2022",
                    Title = "Aşk içerikli fantastik bir kitap",
                },
                new Book()
                {
                    Id = 6,
                    Name = "Tutunamayanlar",
                    AuthorId = 13,
                    PublishYear = "02.07.2020",
                    Title = "Yazarın son bestesi",
                },
            };
            manager.CreateBooks(bookListTest); */
            //

            //fetch the book with id 2
            //manager.GetBookById(2);
            //

            //fetch the author with id 43
            //manager.GetAuthorById(43);
            //


            //update author
            //var author = new Author() { Id = 13, Name = "Caren", Surname = "flowers" };
            //manager.UpdateAuthor(author);
            //

            //update book
            //var book = new Book()
            //{
            //    Id = 4,
            //    Name = "Fırtına Hesapı",
            //    AuthorId = 43,
            //    PublishYear = "02.02.1990",
            //    Title = "Aşk içerikli fantastik bir kitap",
            //};
            //manager.UpdateBook(book);
            //

        }
    }
}