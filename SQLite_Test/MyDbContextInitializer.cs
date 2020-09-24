using SQLite.CodeFirst;
using System.Data.Entity;

namespace SQLite_Test
{
    public class MyDbContextInitializer : SqliteDropCreateDatabaseAlways<ApplicationContext>
    {
        public MyDbContextInitializer(DbModelBuilder modelBuilder)
            : base(modelBuilder) { }

        protected override void Seed(ApplicationContext context)
        {
            context.Set<Phone>().Add(new Phone());
        }
    }
}
