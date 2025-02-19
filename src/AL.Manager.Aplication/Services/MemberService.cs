using System;
using AL.Manager.Aplication.Interface;
using AL.Manager.Aplication.Services.Base;
using AL.Manager.Infra.Data.Repositories.Base;
using AL.Manager.Domain.Entities;
using AL.Manager.Domain.Interface.Base;

namespace AL.Manager.Aplication.Services;

public class MemberService : Service<Member>, IMemberService
{
    public MemberService(IRepository<Member> repository) : base(repository)
    {
    }
}
