namespace CensorYourEmailAddress
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CensorMain
    {
        public static void Main(string[] args)
        {
            string text = "My name is Pesho Peshev. I am from Sofia, \n" 
                          + "my email is: pesho.peshev@email.bg \n"
                          + "(not pesho.peshev@email.com). Test: \n" 
                          + "pesho.meshev@email.bg, pesho.peshev@email.bg";
            string emailToCensor = "pesho.peshev@email.bg";

            string replacementEmail = new string('*', emailToCensor.IndexOf("@")) 
                + emailToCensor.Substring(emailToCensor.IndexOf("@"));
            string replacedText = text.Replace(emailToCensor, replacementEmail);
            Console.WriteLine(replacedText);
        }
    }
}
