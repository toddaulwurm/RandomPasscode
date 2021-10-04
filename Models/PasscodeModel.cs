using System;
namespace RandomPasscode.Models
{
    public class Passcode
    {
        public string Pass;

        public Passcode(int length = 14)
        {
            Pass = CreateRandomPassword(length);
        }

        public string CreateRandomPassword(int length)  
        {  
            string validChars = "ABCDEFGHJKLMNOPQRSTUVWXYZ0123456789";  
            Random random = new Random();  
            char[] chars = new char[length];  
            for (int i = 0; i < length; i++)  
            {  
                chars[i] = validChars[random.Next(0, validChars.Length)];  
            }  
            return new string(chars);  
        }
    } 
}

