using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Authetication1.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;

namespace Authetication1.Controllers
{
    public class AccountController : Controller
    {
        private RegisterModelContext context1;
        private RegisterModel user;
        private List<RegisterModel> _register;
        private encrypted enc;
        private byte[] encrypt;
        public AccountController(RegisterModelContext context1) {
            this.context1 = context1;
            enc = new encrypted();
            
        }
        public IActionResult Registration()
        {
             return View();
        }
        [HttpPost]
        public IActionResult Registration(string userName, string password)
        {

            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                return View();
            }

            else
            {
                // user = context1.RegisterModels.Find(userName);


                using (Aes myAes = Aes.Create())
                {
                    
                    String s= enc.EncryptStringToBytes_Aes(password, myAes.Key, myAes.IV);
                    //String s = Encoding.ASCII.GetString(encrypt);
                    user = new RegisterModel { Name = userName, Password = s };
                };                                                                              
                
                    context1.RegisterModels.Add(user);
                    context1.SaveChanges();
                    return RedirectToAction("Login"); //Give message already register

               }
                //return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
      
        public IActionResult Login(string userName, string password)
        {

            using (Aes myAes = Aes.Create())
            {

                //byte[] bytes = Encoding.ASCII.GetBytes(password);
                // Decrypt the bytes to a string.
                password = enc.EncryptStringToBytes_Aes(password, myAes.Key, myAes.IV);
            }

                if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                return RedirectToAction("Login");
            }
            //Check the user name and password
            //Here can be implemented checking logic from the database
            ClaimsIdentity identity = null;
            bool isAuthenticated = false;

            //user=context1.RegisterModels.Find(userName);
            
            IEnumerable<RegisterModel> _register =  context1.RegisterModels;
            //int userId= _register.Max(v => v.Id) + 1;
            foreach (var user in _register)
            {
                if (userName == "Admin" && password == user.Password)
                {
                    var claims = new List<Claim> {
                        new Claim(ClaimTypes.Name, userName),
                        new Claim(ClaimTypes.Role, "Admin")
                    };
                    identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    isAuthenticated = true;
                    break;
                }
                else if (userName == user.Name && password == user.Password)
                {
                    var claims = new List<Claim> {
                        new Claim(ClaimTypes.Name, userName),
                        new Claim(ClaimTypes.Role, "User")
                    };
                    identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    isAuthenticated = true;
                    break;

                }
            }

           // if (userName == user.Name && password == user.Password)
            //{

                //Create the identity for the user
                
                /*identity = new ClaimsIdentity(new[] {
                    new Claim(ClaimTypes.Name, userName),
                    new Claim(ClaimTypes.Role, "Admin")
                }, CookieAuthenticationDefaults.AuthenticationScheme);
                */
               
            //}
            /*
            if (userName == "Mukesh" && password == "password")
            {
                //Create the identity for the user
                var claims = new List<Claim> {
                    new Claim(ClaimTypes.Name, userName),
                    new Claim(ClaimTypes.Role, "Admin")
                };
                identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                /*identity = new ClaimsIdentity(new[] {
                    new Claim(ClaimTypes.Name, userName),
                    new Claim(ClaimTypes.Role, "User")
                }, CookieAuthenticationDefaults.AuthenticationScheme);
                */
             //   isAuthenticated = true;
           // }

            if (isAuthenticated)
            {
                var authProperties = new AuthenticationProperties();

                var principal = new ClaimsPrincipal(identity);

                var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, authProperties);

                return RedirectToAction("Index", "Home");
            }
            else return RedirectToAction("Registration", "Account");
        }


        public IActionResult Logout()
        {
            var login = HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login");
        }
    }
}

