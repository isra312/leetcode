namespace Questions.Questions;

public class ValidParenthesis
{
    public static bool IsValidDictionary(string s)
    {
        if (string.IsNullOrEmpty(s))
            return false;

        if (s.Length % 2 != 0)
            return false;

        Stack<char> characterStack = new();
        Dictionary<char, char> parenthesis = new()
        {
            { '(', ')' },{'[',']' },{'{','}'}
        };

        if (s.Any(c => !parenthesis.ContainsKey(c) && !parenthesis.ContainsValue(c)))
            return false;

        foreach (char c in s)
        {

            if (parenthesis.ContainsKey(c))
                characterStack.Push(c);

            if (characterStack.Count == 0)
                return false;

            if (parenthesis.ContainsValue(c))
            {
                char peak = characterStack.Peek();

                switch (peak)
                {
                    case '(':
                        if (c != ')')
                            return false;
                        characterStack.Pop();
                        break;
                    case '[':
                        if (c != ']')
                            return false;
                        characterStack.Pop();
                        break;
                    case '{':
                        if (c != '}')
                            return false;
                        characterStack.Pop();
                        break;
                    default:
                        return false;
                }
            }
        }

        if (characterStack.Count > 0)
            return false;

        return true;
    }

    public static bool IsValidSimpleLoop(string s)
    {
        if (string.IsNullOrEmpty(s))
            return false;

        if (s.Length % 2 != 0)
            return false;

        var stack = new Stack<char>();
        foreach (var c in s)
        {
            if (c == '(')
                stack.Push(')');
            else if (c == '{')
                stack.Push('}');
            else if (c == '[')
                stack.Push(']');
            else if (stack.Count == 0 || stack.Pop() != c)
                return false;
        }
        return stack.Count == 0;
    }

    public static bool IsValidNestedIfs(string s)
    {
        if (string.IsNullOrEmpty(s))
            return false;

        if (s.Length % 2 != 0)
            return false;

        Stack<char> openingParentheses = new Stack<char>();

        foreach (char c in s)
        {
            if (c == '(' || c == '{' || c == '[')
            {
                openingParentheses.Push(c);
            }
            else
            {
                if (openingParentheses.Count == 0) return false;
                var opening = openingParentheses.Pop();

                if (opening == '(' && c != ')'
                    || opening == '{' && c != '}'
                    || opening == '[' && c != ']') return false;
            }
        }

        if (openingParentheses.Count > 0) return false;

        return true;
    }
}
