using Microsoft.AspNetCore.Mvc;
using PasswordGenerator.Models;
using System;
using System.Text;

namespace PasswordGenerator.Controllers
{
    public class PasswordGeneratorController : Controller
    {
        public IActionResult Index()
        {
            PasswordGeneratorViewModel model = new PasswordGeneratorViewModel();
           
            return View(model);
        }


        [HttpPost]
        public IActionResult GenerateRandomPassword(int passwordLength)
        {
            PasswordGeneratorViewModel model=new PasswordGeneratorViewModel();
            model.PasswordLength = passwordLength;
            System.Random rand = new System.Random();

            StringBuilder password = new StringBuilder();

            const string chars = "qwertyuiopasdfghjklzxcvbnm"+
                                 "QWERTYUIOPASDFGHJKLZXCVBNM"+
                                 "1234567890"+
                                 "<>?!@#$%^&*()";

            for(int i=0; i<model.PasswordLength; i++)
            {
                int index = rand.Next(chars.Length);
                password.Append(chars[index]);
            }

            model.Password = password.ToString();
            return View("Index", model);

        }
    }
}
/*string password = "";

            const long minPasswordLenght = 5;
            const long maxPasswordLenght = 30;

            int minCharCode = 35;
            int maxCharCode = 126;

            Random random = new Random();
            long passwordLenght = random.NextInt64(minPasswordLenght, maxPasswordLenght);

            for (int i = 0; i < passwordLenght; i++)
            {
                long charIntValue = random.NextInt64(minCharCode, maxCharCode);

                char c = Convert.ToChar(charIntValue);

                password += c;
            }

 */

