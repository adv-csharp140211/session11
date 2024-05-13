using System.Text.RegularExpressions;

namespace AppRegex.Utils;
public static class RegexUtils
{
    static public string EMAIL_PATTERN = @"^((?!\.)[\w\-_.]*[^.])(@\w+)(\.\w+(\.\w+)?[^.\W])$";
    public static bool ValidateEmail(string email)
    {
        return Regex.IsMatch(email, EMAIL_PATTERN); 
    }
}
