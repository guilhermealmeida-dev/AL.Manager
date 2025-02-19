using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AL.Manager.Domain.Entities;
using AL.Manager.Domain.Interface;
using AL.Manager.Infra.Data.Context;
using AL.Manager.Infra.Data.Repositories.Base;

namespace AL.Manager.Infra.Data.Repositories
{
    public class MemberRepository : Repository<Member>,IMemberRepository
    {
        public MemberRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}