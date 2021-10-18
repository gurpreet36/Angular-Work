using Microsoft.AspNetCore.Mvc;
using Test.Repository;
using Test.Model;
using AutoMapper;

namespace Test.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountController : ControllerBase
    {
        IAccountRepository accountRepository;
        IMapper imapper;

        public AccountController(IAccountRepository _accountRepository, IMapper _imapper)
        {
            accountRepository = _accountRepository;
            imapper = _imapper;
        }

        [HttpPost]
        [Route("AddUser")]

        public IActionResult AddUser(AccountDTO accountDTO)
        {
            var accountmap = imapper.Map<Account>(accountDTO);
            // Account account1 = new Account();
            // account1.Username = account.Username;
            // account1.Password = account.Password;
            // account1.Age = account.Age;
            accountRepository.createUser(accountmap);
            return Ok(accountDTO.Username);
        }

       [HttpPost("Login")]
        public IActionResult Check(AccountDTO userDTO)
        {
            if(userDTO.Password==null||userDTO.Username==null)
            {
                return BadRequest("Enter Valid Data");
            }
            var r=accountRepository.GetSingleRecord(userDTO.Username,userDTO.Password);
            if (r==null)
            {
                return BadRequest("False");
            }
            return Ok(r);
        }
       
    }
}