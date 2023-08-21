using DoyDoyWebApp.Entities;
using DoyDoyWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace DoyDoyWebApp.Controllers
{
    public class AuthController : Controller
    {
        DoydoyDBContext _context = new DoydoyDBContext();

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginModel data)
        {
            return View();
        }
        
        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }
    
        [HttpPost]
        public IActionResult SignUp(SignupModel data)
        {
            if (!ModelState.IsValid) return View();//TODO: Bilgiler hatalı mesajı

            User a = _context.Users.Where(x => x.Email == data.Email).SingleOrDefault();
            if (a is not null) return View();
            
            User _user = new User() {
                Name = data.Name, 
                Surname=data.Surname,
                Email = data.Email,
                Password= data.Password
            };

            _context.Users.Add(_user);
            _context.SaveChanges();

            return RedirectToAction(nameof(SignUpSuccess));
        }

        public IActionResult SignUpSuccess() 
        { 
            return View();
        }
    }
}
