using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;


namespace vuecms.Domains
{
    public class DTContext: DbContext
    {
       public DbSet<ClassInfo> ClassInfo { get; set; }

        public DbSet<Account> Account { get; set; }

        public DbSet<LunBo> LunBo { get; set; }

        public DTContext()
            : base("mydb")
        {

        }
     
    }
}
