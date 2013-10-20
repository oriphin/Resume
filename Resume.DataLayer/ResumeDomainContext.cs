using System.Data.Entity;
using Resume.Domain;

namespace Resume.DataLayer
{
    public class ResumeDomainContext:DbContext
    {
        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Location> Location { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Domain.Resume> Resumes { get; set; }
        public DbSet<Snapshot> Snapshots { get; set; }
    }
}
