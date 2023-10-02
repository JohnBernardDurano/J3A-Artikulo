using System;
using System.Linq;
using ENTJAVA_Week3.Models.DB;
using ENTJAVA_Week3.Models.ViewModel;
using Microsoft.AspNetCore.Http.HttpResults;

namespace ENTJAVA_Week3.Models.EntityManager
{
    public class GenreManager
    {
        public void AddUserGenre(GenreModel user)
        {
            using (MyDBContext db = new MyDBContext())
            {
                //Add checking here if login exists

                SYSGenres newGenres = new()
                {
                    GenreID = user.GenresID,
                    LoginName = user.LoginName,
                    GenreType = user.GenreType,
                    CreatedBy = 1,
                    CreatedDateTime = DateTime.Now,
                    //ModifiedBy = 1,
                    //ModifiedDateTime = DateTime.Now
                };

                db.SYSGenres.Add(newGenres);
                db.SaveChanges();

            }
        }
        public bool IsLoginNameExist(string loginName)
        {
            using (MyDBContext db = new MyDBContext())
            {
                return db.SystemUsers.Where(u => u.LoginName.Equals(loginName)).Any();
            }
        }
    }


}

