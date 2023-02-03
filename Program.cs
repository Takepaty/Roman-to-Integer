public class Solution
{
    public int RomanToInt(string s)
    {
        Dictionary<char, int> map = new Dictionary<char, int>();
        map.Add('I', 1);
        map.Add('V', 5);
        map.Add('X', 10);
        map.Add('L', 50);
        map.Add('C', 100);
        map.Add('D', 500);
        map.Add('M', 1000);

        char[] chars = s.ToCharArray();
        int result = 0;
        int temp = 0;
        for (int i = 0; i < chars.Length; i++)
        {
            int j = i - 1;
            if (i == 0)
            {
                temp = map[chars[i]];
                result += temp;
                continue;
            }
            else if (map[chars[j]] < map[chars[i]])
            {
                result -= temp;
                result += map[chars[i]] - map[chars[j]];
                temp = 0;
            }
            else
            {
                temp = map[chars[i]];
                result += temp;
            }
        }

        return result;
    }
}