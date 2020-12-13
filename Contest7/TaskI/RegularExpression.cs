using System;
using System.Text.RegularExpressions;

public class RegularExpression
{
    private readonly string regularExpression;

    public RegularExpression(string expression)
    {
        this.regularExpression = expression
            .Replace(@"\\", "ХЕР")
            .Replace("^", @"\^").Replace(".", @"\.")
            .Replace("[!", "[^").Replace(@"\!", "!")
            .Replace("?", ".").Replace(@"\.", @"\?")
            .Replace("#", @"\#").Replace("&", @"\&")
            .Replace(":", @"\:").Replace(";", @"\;")
            .Replace("<", @"\<").Replace(",", @"\,")
            .Replace(">", @"\>").Replace("=", @"\=")
            .Replace("@", @"\@").Replace("_", @"\_")
            .Replace("~", @"\~").Replace("%", @"\%")
            .Replace("'", @"\'").Replace("/", @"\/")
            .Replace("`", @"\`").Replace("|", @"\|")
            .Replace("+", @"\+").Replace("{", @"\{")
            .Replace("}", @"\}").Replace("*", @"\*")
            .Replace("ХЕР", @"\\");
    }

    public string FindAndReplace(string text, string replace)
    {
        replace = Regex.Replace(replace, @"(\\)([0-9])", "${$2}");
        return Regex.Replace(text, regularExpression, replace.Replace(@"\", "$"));
    }
}
