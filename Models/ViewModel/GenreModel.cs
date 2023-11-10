using System.ComponentModel.DataAnnotations;

namespace ENTJAVA_Week3.Models.ViewModel
{
    public class GenreModel
    {
        [Key]
        public int GenresID { get; set; }
        //[Required(ErrorMessage = "*")]
        public required string LoginName { get; set; }
        //[Required(ErrorMessage = "*")]
        public required string GenreType { get; set; }
        //[Required(ErrorMessage = "*")]
        //[Display(Name = "Created By")]
        public int CreatedBy { get; set; }
    }

    public class GenresModel
    {
        public List<UserModel> Genres { get; set; }
    }

}
