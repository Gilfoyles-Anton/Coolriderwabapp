using CoolRider_1.Models;
using CoolRider_1.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoolRider_1.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AccountController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Show login page
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        // Handle login form submission
        [HttpPost]
        public IActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                // For now, compare plain text (in real project: hash model.Password and compare with PasswordHash)
                var user = _context.Users
                    .FirstOrDefault(u => u.Username == model.Username && u.PasswordHash == model.Password);

                if (user != null)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid username or password");
                }
            }
            return View(model);
        }

        // Show register page
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        // Handle register form submission
        [HttpPost]
        public IActionResult Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                // If role is Admin, validate activation code
                if (model.Role == "Admin")
                {
                    var code = _context.AdminActivationCodes
                        .FirstOrDefault(c => c.Code == model.AdminCode && c.Status == "Unused");

                    if (code == null)
                    {
                        ModelState.AddModelError("AdminCode", "Activation code is invalid or already used");
                        return View(model);
                    }

                    // Activation code is valid → mark as used (UserId will be updated later)
                    code.Status = "Used";
                    code.UsedByUserId = null;
                    code.UsedAt = DateTime.Now;
                    _context.AdminActivationCodes.Update(code);
                }

                // Save user information to database
                var newUser = new RegisterModel
                {
                    Username = model.Username,
                    Email = model.Email,
                    PhoneNumber = model.PhoneNumber,
                    PasswordHash = model.PasswordHash, // Important: use PasswordHash
                    Role = model.Role,
                    AdminCode = model.Role == "Admin" ? model.AdminCode : null
                };

                _context.Users.Add(newUser);
                _context.SaveChanges();

                // If Admin, update activation code with user ID
                if (model.Role == "Admin")
                {
                    var code = _context.AdminActivationCodes
                        .FirstOrDefault(c => c.Code == model.AdminCode);
                    if (code != null)
                    {
                        code.UsedByUserId = newUser.Id;
                        _context.AdminActivationCodes.Update(code);
                        _context.SaveChanges();
                    }
                }

                // After successful registration, redirect to login page
                return RedirectToAction("Login", "Account");
            }

            return View(model);
        }
    }
}
