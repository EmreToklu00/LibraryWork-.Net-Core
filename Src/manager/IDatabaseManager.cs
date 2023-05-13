using System;
using librarywork.src.models;

namespace librarywork.src.manager
{
    public interface IDatabaseManager
    {
        void GetAllBooks();

        void GetBookById(int Id);

        void GetAllAuthors();

        void GetAuthorById(int Id);

        //void CreateBook(Book book);

        void CreateBooks(List<Book> books);

        //void CreateAuthor(Author author);

        void CreateAuthors(List<Author> authors);

        void UpdateBook(Book book);

        void UpdateAuthor(Author author);

        void DeleteBook(Book book);

        void DeleteAuthor(Author author);

    }
}

