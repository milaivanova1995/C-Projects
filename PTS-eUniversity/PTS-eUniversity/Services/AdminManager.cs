using PTS_eUniversity.Models;
using PTS_eUniversity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PTS_eUniversity.Services
{
    public class AdminManager
    {
        public void DeteleUser(AdminVM model)
        {
            var db = new UniversityDbContext();
            var user = db.Users.Where(u => u.Email == model.Email).FirstOrDefault();

            user.Password = PasswordHasher.HashPassword("Gay");

            //db.SaveChanges();
        }

        public void AddUser(AdminVM model)
        {
            var db = new UniversityDbContext();

            db.Users.Add(new User
            { Email = model.Email,
                FirstName = model.FirstName,
                LastName = model.LastName,
                FacultyId = int.Parse(model.Faculty),
                Password = PasswordHasher.HashPassword(model.Password)
            });

            db.SaveChanges();
        }
    }
}