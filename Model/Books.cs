namespace books_backend.Model
{
    public class Books
    {
        public string Id { get; set; } //= Guid.NewGuid().ToString();
        public string Title { get; set; }=string.Empty;
        public string Author { get; set; }= string.Empty;
        public int Year {  get; set; } 
        public string Actions { get; set; } = string.Empty;

        
    }
}
