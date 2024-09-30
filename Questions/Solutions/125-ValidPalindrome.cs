namespace Questions.Solutions;

public static class ValidPalindrome
{
    public static bool IsPalindromeStringToLower(string s)
    {
        string cleanedUp = new(s.Where(c => char.IsLetterOrDigit(c)).ToArray());

        cleanedUp = cleanedUp.ToLowerInvariant();

        int leftToRightCursor = 0;
        int rightToLeftCursor = cleanedUp.Length - 1;

        while (leftToRightCursor <= rightToLeftCursor)
        {
            if (cleanedUp[leftToRightCursor] != cleanedUp[rightToLeftCursor])
                return false;

            leftToRightCursor++;
            rightToLeftCursor--;
        }
        return true;
    }

    public static bool IsPalindromeCharToLower(string s)
    {
        string cleanedUp = new(s.Where(c => char.IsLetterOrDigit(c)).ToArray());

        int leftToRightCursor = 0;
        int rightToLeftCursor = cleanedUp.Length - 1;

        while (leftToRightCursor <= rightToLeftCursor)
        {
            if (char.ToLowerInvariant(cleanedUp[leftToRightCursor]) != char.ToLowerInvariant(cleanedUp[rightToLeftCursor]))
                return false;

            leftToRightCursor++;
            rightToLeftCursor--;
        }
        return true;
    }
}
