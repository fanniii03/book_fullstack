using books_backend.Model;
using Microsoft.EntityFrameworkCore.ChangeTracking;


namespace books_backend.Data
{
    public interface IRepository
    {
        public void Update(Books newbook, string id);
        public void Delete(string id);
        public void Create(Books newbook);
        IEnumerable <Books> Get();
    }


    public class Repository : IRepository
    {
        private readonly DbContextBooks books_ctx;
        public Repository(DbContextBooks books_context)
        {
            this.books_ctx = books_context;
        }


        public void Create(Books newbook)
        {
            
                books_ctx.Add(newbook);
                books_ctx.SaveChanges();
            
            
        }

        public void Delete(string id)
        {
            books_ctx.Remove(books_ctx.Book.FirstOrDefault(t => t.Id == id));
            books_ctx.SaveChanges();
        }

        public void Update(Books newbook, string book_id)
        {
            Books old_book = books_ctx.Book.FirstOrDefault(i=>i.Id == book_id);
            if (old_book != null)
            {
                //old_book.Id = newbook.Id;
                old_book.Title = newbook.Title;
                old_book.Author = newbook.Author;
                old_book.Year = newbook.Year;
                old_book.Actions = newbook.Actions;
                books_ctx.SaveChanges();
            }
        }

        public IEnumerable<Books> Get()
        {
            return books_ctx.Book.ToList();
        }
    }
}
