namespace Questions.Questions;

public class RomanToInteger
{
    public static int RomanToIntWithReplace(string s)
    {
        Dictionary<string, int> romanNumeralsMap = new()
        {
            {"I", 1 },
            {"V", 5 },
            {"X", 10 },
            {"L", 50 },
            {"C" ,100 },
            {"D" ,500 },
            {"M" ,1000 }
        };

        int integer = 0;

        s = s.Replace("IV", "IIII")
                .Replace("IX", "VIIII")
                .Replace("XL", "XXXX")
                .Replace("XC", "LXXXX")
                .Replace("CD", "CCCC")
                .Replace("CM", "DCCCC");

        for (int i = 0; i < s.Length; i++)
            integer += romanNumeralsMap.GetValueOrDefault(s[i].ToString());

        return integer;
    }

    public static int RomanToInt(string s)
    {
        int integer = 0;
        int partial = 0;

        Dictionary<char, int> romanNumeralsMap = new()
        {
            {'I', 1 },
            {'V', 5 },
            {'X', 10 },
            {'L', 50 },
            {'C' ,100 },
            {'D' ,500 },
            {'M' ,1000 }
        };
        for (int i = 0; i < s.Length; i++)
        {
            if (romanNumeralsMap[s[i]] == 0)
            {
                partial = romanNumeralsMap[s[i]];
                continue;

            }

            if (partial >= romanNumeralsMap[s[i]])
            {
                integer += partial;
                partial = romanNumeralsMap[s[i]];
            }
            else
            {
                partial = romanNumeralsMap[s[i]] - partial;
            }
        }

        integer += partial;

        return integer;
    }
}
