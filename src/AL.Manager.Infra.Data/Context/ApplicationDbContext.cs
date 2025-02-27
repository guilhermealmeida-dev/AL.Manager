using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AL.Manager.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AL.Manager.Infra.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {
        }
        public DbSet<Member> Member{get;set;}
        public DbSet<AcademicLeague> AcademicLeague{get;set;}
        public DbSet<MemberAcademicLeague> MemberAcademicLeague{get;set;}
        

    }
}