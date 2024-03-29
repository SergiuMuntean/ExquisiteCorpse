using System;

namespace ExquisiteCorpse
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomMode();
            Console.ReadLine();
        }

        static void SwitchCase(int head, int body, int feet)
        {
            switch (head)
            {
                case 1:
                    GhostHead();
                    break;
                case 2:
                    BugHead();
                    break;
                case 3:
                    MonsterHead();
                    break;
            }
            switch (body)
            {
                case 1:
                    GhostBody();
                    break;
                case 2:
                    BugBody();
                    break;
                case 3:
                    MonsterBody();
                    break;
            }
            switch (feet)
            {
                case 1:
                    GhostFeet();
                    break;
                case 2:
                    BugFeet();
                    break;
                case 3:
                    MonsterFeet();
                    break;
            }
        }

        static int TranslateToNumber(string creature)
        {
            switch (creature)
            {
                case "ghost":
                    return 1;
                    break;
                case "bug":
                    return 2;
                    break;
                case "monster":
                    return 3;
                    break;
                default:
                    return 0;
                    break;
            }
        }

        static void RandomMode()
        {
            Random randomNumber = new Random();
            int choiceHead = randomNumber.Next(1, 4);
            int choiceBody = randomNumber.Next(1, 4);
            int choiceFeet = randomNumber.Next(1, 4);
            SwitchCase(choiceHead, choiceBody, choiceFeet);
            switch (choiceHead)
            {
                case 1:
                    BugHead();
                    break;
                case 2:
                    MonsterHead();
                    break;
                case 3:
                    GhostHead();
                    break;
            }
            switch (choiceBody)
            {
                case 1:
                    BugBody();
                    break;
                case 2:
                    MonsterBody();
                    break;
                case 3:
                    GhostBody();
                    break;
            }
            switch (choiceFeet)
            {
                case 1:
                    BugFeet();
                    break;
                case 2:
                    MonsterFeet();
                    break;
                case 3:
                    GhostFeet();
                    break;
            }
        }

        static void BuildACreature(string head, string body, string feet)
        {
            int headNum = TranslateToNumber(head);
            int bodyNum = TranslateToNumber(body);
            int feetNum = TranslateToNumber(feet);
            SwitchCase(headNum, bodyNum, feetNum);
        }

        static void GhostHead()
        {
            Console.WriteLine("     ..-..");
            Console.WriteLine("    ( o o )");
            Console.WriteLine("    |  O  |");
        }

        static void GhostBody()
        {
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
        }

        static void GhostFeet()
        {
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
            Console.WriteLine("    '~~~~~'");
        }

        static void BugHead()
        {
            Console.WriteLine("     /   \\");
            Console.WriteLine("     \\. ./");
            Console.WriteLine("    (o + o)");
        }

        static void BugBody()
        {
            Console.WriteLine("  --|  |  |--");
            Console.WriteLine("  --|  |  |--");
            Console.WriteLine("  --|  |  |--");
        }

        static void BugFeet()
        {
            Console.WriteLine("     v   v");
            Console.WriteLine("     *****");
        }

        static void MonsterHead()
        {
            Console.WriteLine("     _____");
            Console.WriteLine(" .-,;='';_),-.");
            Console.WriteLine("  \\_\\(),()/_/");
            Console.WriteLine("　  (,___,)");
        }

        static void MonsterBody()
        {
            Console.WriteLine("   ,-/`~`\\-,___");
            Console.WriteLine("  / /).:.('--._)");
            Console.WriteLine(" {_[ (_,_)");
        }

        static void MonsterFeet()
        {
            Console.WriteLine("    |  Y  |");
            Console.WriteLine("   /   |   \\");
            Console.WriteLine("   \"\"\"\" \"\"\"\"");
        }
    }
}
