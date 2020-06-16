using System;
using System.Text.RegularExpressions;

public class Example
{
    public static void Main()
    {
        
        
        string input = @"Episode IV, A NEW HOPE It is a period of civil war. Rebel spaceships, striking from a hidden
                        base, have won their first victory against the evil Galactic Empire. During the battle, Rebel spies
                        managed to steal secret plans to the Empire’s ultimate weapon, the DEATH STAR, an armored
                        space station with enough power to destroy an entire planet. Pursued by the Empire’s sinister
                        agents, Princess Leia races home aboard her starship, custodian of the stolen plans that can
                        save her people and restore freedom to the galaxy….";
        RegexOptions options = RegexOptions.Multiline;

        // 2a. Find all of the occurrences of the letter ‘d’ or ‘e’
        string pattern1 = @"[d-e]";
        foreach (Match m in Regex.Matches(input, pattern1, options))
        {
            Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
        }

        // 2b. Find all of the occurrences of the letter ‘d’ or’ e’, followed by another ‘d’
        string pattern2 = @"[d-e][*d]";
        foreach (Match m in Regex.Matches(input, pattern2, options))
        {
            Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
        }

        // 2c. Find all of the occurrences of the letter ‘a’, followed by any letter, then the letter ‘a’ again
        string pattern3 = @"[a][a-z][a]";
        foreach (Match m in Regex.Matches(input, pattern3, options))
        {
            Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
        }

        // 2d.Find all of the words that start with the letter “p”
        string pattern4 = @"[ ][p][a-z]*";
        foreach (Match m in Regex.Matches(input, pattern4, options))
        {
            Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
        }

        // 2e. Find all of the words that end with the letter e
        string pattern5 = @"[a-z]*[e][ ]";
        foreach (Match m in Regex.Matches(input, pattern5, options))
        {
            Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
        }

        // 2f. Find all of the capital letters
        string pattern6 = @"[A-Z]";
        foreach (Match m in Regex.Matches(input, pattern6, options))
        {
            Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
        }
    }
}