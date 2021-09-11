using System;

namespace Acme.Common
{
    public static class StringHandler
    {
        /// <summary>
        /// Добавляет пробел в каждую переменную перед заглавной буквой
        /// </summary>
        /// <param name="sourse"></param>
        /// <returns></returns>
        public static string InsertSpace (this string sourse)
        {
            string result = string.Empty;
            if(!String.IsNullOrWhiteSpace(sourse))
            {
                foreach (char letter in sourse)
                {
                    if(char.IsUpper(letter))
                    {
                        result = result.Trim();
                        result += " ";
                    }
                    result += letter; 
                }
            }
            result = result.Trim();
            return result;
        }
    }
}
