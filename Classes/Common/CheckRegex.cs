using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace uchot.Classes.Common
{
    public class CheckRegex
    {
        public static bool Match(string Pattern, string Input)
        {
            //создаем регулярное выражение и ищем совпадения по паттерну
            Match m = Regex.Match(Input, Pattern);
            //возвращаем результат
            return m.Success;
        }
    }
}
