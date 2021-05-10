using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace API.Entities
{
    [Table("Workers")]
    public class Worker
    {
        [Key]
        public int WorkerId { get; set; }
        public string FullName { get; set; }
        public string Coordinates { get; set; }        
        public bool IsDeleted { get; set; }
        
    }
}