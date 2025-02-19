using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AL.Manager.Aplication.Interface;
using AL.Manager.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AL.Manager.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MemberController : ControllerBase
    {
        private readonly IMemberService _memberService;
        public MemberController(IMemberService memberService)
        {
            _memberService=memberService;
        }

        [HttpGet("GetAllMembers")]
        public IActionResult GetAllMembers(){
            try
            {
               List<Member>? listMembers= _memberService.GetAll().ToList();
               return Ok(listMembers);
            }
            catch (System.Exception e)
            {
                return BadRequest("Não foi possivel buscar os membros"+e);
                
            }
            
        }
    }
}