using System.Text.RegularExpressions;
using static System.Console;

namespace Assignment1;

public static class RegExpr
{
    public static IEnumerable<string> SplitLine(IEnumerable<string> lines) => throw new NotImplementedException();

    public static IEnumerable<(int width, int height)> Resolution(IEnumerable<string> resolutions){
        var pattern = @"^(?<width>\d{3,4})x(?<height>\d{3,4})$";
        var rg = new Regex(pattern);

        foreach(string s in resolutions){
            string[] words = s.Split(',');
            foreach (var word in words){
                var trimmed = word.Trim();
                var match   = Regex.Match(trimmed, pattern);
                var width   = int.Parse(match.Groups["width"].Value);
                var height  = int.Parse(match.Groups["height"].Value);
                yield return (width, height);
            }
        }
    }

    public static IEnumerable<string> InnerText(string html, string tag) => throw new NotImplementedException();
}