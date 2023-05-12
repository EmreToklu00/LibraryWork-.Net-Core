using System;
using librarywork.src.models;
using librarywork.src.context;
using static System.Reflection.Metadata.BlobBuilder;

namespace librarywork.src.manager
{
    public class DatabaseManager : IDatabaseManager
    {
        public void CreateAuthor(Author author)
        {
            using (LibraryContext context = new LibraryContext())
            {
                try
                {
                    context.Authors.Add(author);
                    Console.WriteLine("Yazar eklendi");
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

        public void CreateAuthors(List<Author> authors)
        {
            using (LibraryContext context = new LibraryContext())
            {
                try
                {
                    context.Authors.AddRange(authors);
                    Console.WriteLine("Yazarlar eklendi");
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

        public void CreateBook(Book book)
        {
            using (LibraryContext context = new LibraryContext())
            {
                try
                {
                    context.Books.Add(book);
                    Console.WriteLine("Kitap eklendi");
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

        public void CreateBooks(List<Book> books)
        {
            using (LibraryContext context = new LibraryContext())
            {
                try
                {
                    context.Books.AddRange(books);
                    Console.WriteLine("Kitaplar eklendi");
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
                    Console.WriteLine("Yazar Silindi");
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
                    Console.WriteLine("Kitap Silindi");
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
                        Console.WriteLine("Yazar--------------");
                        Console.WriteLine("Yazarın Id'si: " + author.Id);
                        Console.WriteLine("Yazarın ismi: " + author.Name);
                        Console.WriteLine("Yazarın soyismi:" + author.Surname);
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
                        Console.WriteLine("Kitap--------------");
                        Console.WriteLine("Kitapın Id'si: " + book.Id);
                        Console.WriteLine("Kitapın ismi: " + book.Name);
                        Console.WriteLine("Kitap Başlığı: " + book.Title);
                        Console.WriteLine("Yazarın Id'si: " + book.AuthorId);
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
                        Console.WriteLine("-----Kitap-----");
                        Console.WriteLine("Kitapın Id'si: " + book.Id);
                        Console.WriteLine("Kitapın ismi: " + book.Name);
                        Console.WriteLine("Kitap Başlığı: " + book.Title);
                        Console.WriteLine("Yazarın Id'si: " + book.AuthorId);

                    }
                    else
                    {
                        Console.WriteLine("Kitap bulunamadı");
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
                        Console.WriteLine("Yazar Güncellendi");
                    }
                    else
                    {
                        Console.WriteLine("Yazar Bulunamadı");
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
                        Console.WriteLine("Kitap Güncellendi");
                    }
                    else
                    {
                        Console.WriteLine("Yazar Bulunamadı");
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

