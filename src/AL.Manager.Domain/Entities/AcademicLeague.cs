using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using AL.Manager.Domain.Entities.Base;

namespace AL.Manager.Domain.Entities
{
    public class AcademicLeague : EntityBase
    {
        [Required]
        public string Name { get; set; }
        public bool Status { get; set;}=true;
        public List<Member> Members { get; } = [];
        public List<MemberAcademicLeague> MemberAcademicLeagues { get; set; } = [];
         public AcademicLeague(string name) 
        {
            this.Name = name;
   
        }
    }
}