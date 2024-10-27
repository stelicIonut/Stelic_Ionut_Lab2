namespace Stelic_Ionut_Lab2.Models
{
    public class Author
    {
        public int ID { get; set; } 
        public string FirstName { get; set; }   
        public string LastName { get; set; }
        public string Author_Name{
            get {
                return $"{FirstName} {LastName}";
            }
        }

        public ICollection<Book>? Books { get; set; }


    }
}
