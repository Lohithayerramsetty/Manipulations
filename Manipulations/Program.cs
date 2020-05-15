using System;

namespace Manipulations
{
    class Programṇ
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Type the sentence");
            String sentence = Console.ReadLine();
            String SpacesToUnderScore = sentence.Replace(" ", "_");
            string removeLeadingSpaces = sentence.TrimEnd(' ');
            string removetrailingspaces = sentence.TrimStart(' ');
            String lowerToUppercaseA = sentence. Replace("a", " A");


            Console.WriteLine("Underscore instead of spaces: " + SpacesToUnderScore );
            Console.WriteLine("Without leading spaces:" + removeLeadingSpaces );
            Console.WriteLine("Without trailing spaces:" + removetrailingspaces);
            Console.WriteLine("a to A" + lowerToUppercaseA);

            Console.ReadLine();

        }
    }
}
