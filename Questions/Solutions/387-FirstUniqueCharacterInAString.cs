namespace Questions.Solutions;

public class FirstUniqueCharacterInAString
{
    public int FirstUniqChar(string s)
    {
        Dictionary<char, int> characters = [];

        foreach (var letter in s)
        {
            int count = 1;
            if (characters.ContainsKey(letter))
                characters[letter] += 1;

            else
                characters.Add(letter, count);
        }

        if (characters.FirstOrDefault(x => x.Value == 1).Key != '\0')
            return s.IndexOf(characters.FirstOrDefault(x => x.Value == 1).Key);

        return -1;
    }
}
