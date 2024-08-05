using AravaChat.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace AravaChat.DAL
{
    public class DataLayer : DbContext
    {
        //מקבל סטרינג חיבור ומעביר לקונסטרקטור של קלאס האב
        public DataLayer(string connectionString) : base(GetOptions(connectionString))
        {
            Database.EnsureCreated();
            //הכנסת נתונים
            Seed();
        }

        private void Seed()
        {
            if (Users.Any())
            {
                return;
            }
            User user = new User();
            user.UserName = "מנחם";
            user.NickName = "מני";
            user.Password = "1234567890";
            user.MessageList?.Add(CreateListMessages(user));
            Users.Add(user);
            SaveChanges();
        }

        private Message CreateListMessages(User user)
        {
            Message message = new Message();
            
            message.Text = "helo";
            message.Sender = user;
            message.Reciever = "";
            message.DateTime = DateTime.Now;
            Messages.Add(message);
            SaveChanges();
            return message;

        }


        public DbSet<User> Users { get; set; }

        public DbSet<Message> Messages { get; set; }

        private static DbContextOptions GetOptions(string connectionString)
        {
            //1: 

            return SqlServerDbContextOptionsExtensions.UseSqlServer(new DbContextOptionsBuilder(), connectionString).Options;
        }
    }
}

