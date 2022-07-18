using System.ComponentModel.DataAnnotations;

namespace Book1.Model
{
    public class Books
    {
        [Key]
        public int Bk_Id { get; set; }
        public string Bk_Name { get; set; }
        public string Bk_Author { get; set; }
        public int Bk_NoOfPages { get; set; }
        public int Bk_Type { get; set; }
        public DateTime Bk_PubDate { get; set; }

    }

}