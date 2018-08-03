using System.ComponentModel.DataAnnotations.Schema;

namespace example.Models
{
    [Table("mytable")]
    public class Data
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }
}