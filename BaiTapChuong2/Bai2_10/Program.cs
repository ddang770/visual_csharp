
using System.Text.RegularExpressions;

string text = "banana";
string substring = "ana";
Console.WriteLine($"'{substring}' xuat hien {countSubstringOverlapping(text, substring)} lan");

static int countSubstringOverlapping(string text, string substring)
{
    if(string.IsNullOrEmpty(text)|| string.IsNullOrEmpty(substring))
        return 0;
    return Regex.Matches(text, $"(?={Regex.Escape(substring)})").Count();
}