using Microsoft.AspNetCore.Mvc;
using guardian.Models;
using System.Security.Cryptography;
using guardian.Data;
using System.Text;

namespace guardian.Controllers
{
    public class AuthenticationController : Controller
    {
        private readonly GuardianDbContext _context;

        public AuthenticationController(GuardianDbContext context)
        {
            _context = context;
        }


        public IActionResult Login()
        {
            return View();
        }

        // GET: Authentication/Create
        public IActionResult CreateAccount()
        {
            // Initialize a new Account instance to pass to the Create view
            var account = new Account();
            return View(account);
        }

        // POST: Authentication/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateAccount(Account account)
        {
            if (ModelState.IsValid)
            {
                int id = IdGenerator.GenerateUniqueNumber();
                account.Id = id;
                string hashedPassword = HashPassword(account.Password);
                account.Password = hashedPassword; // Update the password with the hashed value
                // Here, you would typically add code to save the new account to a database.
                // For demonstration, we're just redirecting to the Index view.
                _context.Account.Add(account); // Add the account to the DbSet
                _context.SaveChanges(); // Save changes to the database

                return RedirectToAction(nameof(Index));
            }

            // If the model state is not valid, display the form again with the entered data and validation messages.
            return View(account);
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(hashedBytes);
            }
        }
    }
}
