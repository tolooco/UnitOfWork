using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tolooco.Entity.Models;

namespace Tolooco.Data.DatabaseContext
{
    public class EntiryDb : DbContext
    {
        static  EntiryDb()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<EntiryDb>());
        }

        public EntiryDb():base("EntityDb")
        {

        }

        public DbSet<User> Users { get; set; }
    }
}
