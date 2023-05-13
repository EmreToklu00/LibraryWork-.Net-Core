using librarywork.src.models;
using librarywork.src.context;

namespace librarywork.src.manager
{
    public class DatabaseManager : IDatabaseManager
    {
        /*  public void CreateAuthor(Author author)
         {
             using (LibraryContext context = new LibraryContext())
             {
                 try
                 {
                     context.Authors.Add(author);
                     Console.WriteLine("Author Added");
                 }
                 catch (Exception ex)
                 {
                     Console.WriteLine(ex);
                 }
                 finally
                 {
                     context.SaveChanges();
                 }
             }
         } */

        public void CreateAuthors(List<Author> authors)
        {
            using (LibraryContext context = new LibraryContext())
            {
                try
                {
                    context.Authors.AddRange(authors);
                    Console.WriteLine("Authors Added");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                finally
                {
                    context.SaveChanges();
                }
            }
        }

        /* public void CreateBook(Book book)
        {
            using (LibraryContext context = new LibraryContext())
            {
                try
                {
                    context.Books.Add(book);
                    Console.WriteLine("Book Added");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                finally
                {
                    context.SaveChanges();
                }
            }
        }
 */
        public void CreateBooks(List<Book> books)
        {
            using (LibraryContext context = new LibraryContext())
            {
                try
                {
                    context.Books.AddRange(books);
                    Console.WriteLine("Books Added");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                finally
                {
                    context.SaveChanges();
                }
            }
        }

        public void DeleteAuthor(Author author)
        {
            using (LibraryContext context = new LibraryContext())
            {
                try
                {
                    context.Authors.Remove(author);
                    Console.WriteLine("Author Deleted");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                finally
                {
                    context.SaveChanges();
                }
            }
        }


        public void DeleteBook(Book book)
        {
            using (LibraryContext context = new LibraryContext())
            {
                try
                {
                    context.Books.Remove(book);
                    Console.WriteLine("Book Deleted");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                finally
                {
                    context.SaveChanges();
                }
            }
        }

        public void GetAllAuthors()
        {
            using (LibraryContext context = new LibraryContext())
            {
                try
                {
                    List<Author> authors = context.Authors.ToList();
                    foreach (var author in authors)
                    {
                        Console.WriteLine("Author--------------");
                        Console.WriteLine("Authors Id: " + author.Id);
                        Console.WriteLine("Authors Name: " + author.Name);
                        Console.WriteLine("Authors Surname:" + author.Surname);
                        Console.WriteLine();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                finally
                {
                    context.SaveChanges();
                }
            }
        }

        public void GetAllBooks()
        {
            using (LibraryContext context = new LibraryContext())
            {
                try
                {
                    List<Book> books = context.Books.ToList();
                    foreach (var book in books)
                    {
                        Console.WriteLine("Book--------------");
                        Console.WriteLine("Book Id: " + book.Id);
                        Console.WriteLine("Book Name: " + book.Name);
                        Console.WriteLine("Book Title: " + book.Title);
                        Console.WriteLine("Author Id: " + book.AuthorId);
                        Console.WriteLine();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                finally
                {
                    context.SaveChanges();
                }
            }
        }

        public void GetAuthorById(int Id)
        {
            using (LibraryContext context = new LibraryContext())
            {
                try
                {
                    var author = context.Authors.Where(p => p.Id == Id).FirstOrDefault();
                    if (author != null)
                    {
                        Console.WriteLine($"name: {author.Name} surname: {author.Surname} id: {author.Id}");

                    }
                    else
                    {
                        Console.WriteLine("Kullanıcı bulunamadı");
                    }


                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                finally
                {
                    context.SaveChanges();
                }
            }
        }

        public void GetBookById(int Id)
        {
            using (LibraryContext context = new LibraryContext())
            {
                try
                {
                    var book = context.Books.Where(p => p.Id == Id).FirstOrDefault();
                    if (book != null)
                    {
                        Console.WriteLine("-----Book-----");
                        Console.WriteLine("Book Id: " + book.Id);
                        Console.WriteLine("Book Name: " + book.Name);
                        Console.WriteLine("Book Title: " + book.Title);
                        Console.WriteLine("Author Id: " + book.AuthorId);

                    }
                    else
                    {
                        Console.WriteLine("Book not found");
                    }


                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                finally
                {
                    context.SaveChanges();
                }
            }
        }

        public void UpdateAuthor(Author author)
        {
            using (LibraryContext context = new LibraryContext())
            {
                try
                {
                    var DbAuthor = context.Authors.Where(p => p.Id == author.Id).FirstOrDefault();
                    if (DbAuthor != null)
                    {
                        DbAuthor.Id = author.Id;
                        DbAuthor.Name = author.Name;
                        DbAuthor.Surname = author.Surname;
                        Console.WriteLine("Author Updated");
                    }
                    else
                    {
                        Console.WriteLine("Author not found");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                finally
                {
                    context.SaveChanges();
                }
            }
        }

        public void UpdateBook(Book book)
        {
            using (LibraryContext context = new LibraryContext())
            {
                try
                {
                    var DbBook = context.Books.Where(p => p.Id == book.Id).FirstOrDefault();
                    if (DbBook != null)
                    {
                        DbBook.Id = book.Id;
                        DbBook.Name = book.Name;
                        DbBook.Title = book.Title;
                        DbBook.PublishYear = book.PublishYear;
                        DbBook.AuthorId = book.AuthorId;
                        Console.WriteLine("Book Updated");
                    }
                    else
                    {
                        Console.WriteLine("Author not found");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                finally
                {
                    context.SaveChanges();
                }
            }
        }
    }
}

