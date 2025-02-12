using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using AL.Manager.Domain.Entities.Base;

namespace AL.Manager.Domain.Entities
{
    public class Member : EntityBase
    {
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Email { get; set; }
        public List<AcademicLeague> AcademicLeagues{get;}=[];
        public List<MemberAcademicLeague> MemberAcademicLeagues{get;set;}=[];
        public Member(string nome, string email)
        {
            this.Nome = nome;
            this.Email = email;
        }
    }
}