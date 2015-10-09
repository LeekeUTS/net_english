using System;
using System.Data.Entity;

namespace net_english.Models
{
    public class English
    {
        public int ID { get; set; }
        public int PID { get; set; }
        public String cn { get; set; }
        public String google { get; set; }
        public String trans { get; set; }
        public String hit { get; set; }
        public String notes { get; set; }
        public String status { get; set; }
    }

    public class EnglishDBContext : DbContext
    {
        public DbSet<English> Englishs { get; set; }
    }
}