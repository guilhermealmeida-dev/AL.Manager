using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AL.Manager.Domain.Entities.Base;

namespace AL.Manager.Domain.Entities
{
    public class MemberAcademicLeague: EntityBase
    {
        public Guid MemberId{get;set;}
        public Guid AcademicLiagueId{get;set;}
        public bool Status{get;set;}
    }
}