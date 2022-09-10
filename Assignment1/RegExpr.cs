using System.Text.RegularExpressions;

namespace Assignment1;

public static class RegExpr
{
    public static IEnumerable<string> SplitLine(IEnumerable<string> lines) => throw new NotImplementedException();

    public static IEnumerable<(int width, int height)> Resolution(string resolutions) => throw new NotImplementedException();

    // Regex: (?<=">|a>)\w.*?(?=<\/a>) where "a" is a variable
    public static IEnumerable<string> InnerText(string html, string tag) {
        String pattern = "(?<=\">|a>)\\w.*?(?=<\\/a>)";
        String replacePattern = "<\\w+>|<\\/\\w+>";
        MatchCollection matches = Regex.Matches(html, pattern);
        foreach(Match match in matches){
            var replacedMatch = Regex.Replace(match.ToString(), replacePattern, "");
            yield return replacedMatch.ToString();
        }
    }

    public static IEnumerable<(Uri url, string title)> Urls(string html){
        String pattern = "(?<=href=\"|title=\").*?(?=\")";
        MatchCollection matches = Regex.Matches(html, pattern);
        for(int i = 0; i < matches.Count(); i = i+2){
            yield return (new Uri(matches[i].ToString()), matches[i+1].ToString());
        }
    }
}