using System.ComponentModel.DataAnnotations;

namespace ENTJAVA_Week3.Models.ViewModel
{
    public class GenreModel
    {
        [Key]
        public int GenresID { get; set; }
        [Required(ErrorMessage = "*")]
        public int UserID { get; set; }
        [Required(ErrorMessage = "*")]
        public required string Genres { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "Created By")]
        public int CreatedBy { get; set; }
    }

}
