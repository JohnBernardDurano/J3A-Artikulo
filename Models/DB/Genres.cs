using System.ComponentModel.DataAnnotations;

namespace ENTJAVA_Week3.Models.DB
{
    public class SYSGenres
    {
        [Key]
        public int GenreID { get; set; }
        public string LoginName { get; set; }
        public string GenreType { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDateTime { get; set; }
        //public int ModifiedBy { get; set; }
        //public DateTime ModifiedDateTime { get; set; }
    }
}