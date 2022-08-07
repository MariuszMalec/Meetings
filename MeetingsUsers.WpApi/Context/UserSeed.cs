using MeetingsUsers.WpApi.Models;
using Microsoft.EntityFrameworkCore;

namespace MeetingsUsers.WpApi.Context
{
    public static class UserSeed
    {
        private static List<User> Users = new List<User>()
        {
            new User {Id = 1, FirstName = "Mariusz", LastName="Malec" , Email ="mm@example.com", PhoneNumber = "", CreatedDate = DateTime.Now, PasswordHash = "mm13@!"},
            new User {Id = 2, FirstName = "Barbara", LastName="Malec" , Email ="bm@example.com", PhoneNumber = "", CreatedDate = DateTime.Now, PasswordHash = "bm01@!"}

        };

        public static List<User> GetAll()
        {
            return Users;
        }
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                GetAll()
                );
        }
    }
}
