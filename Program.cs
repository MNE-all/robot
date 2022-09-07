// See https://aka.ms/new-console-template for more information
namespace robot
{
    class Program
    {
        static void Main()
        {
            int step = 0;
            int left = Console.CursorLeft + 20, top = Console.CursorTop + 10;
            Robot robot = new Robot();
            char[] dir = { 'N', 'N', 'N', 'E', 'E', 'S', 'S', 'E', 'S', 'W', 'W' };
            Console.SetCursorPosition(left, top);
            Console.Write(step);
            while (!robot.WhereBot(step) && step < dir.Length)
            {
                robot.Swipe(dir[step]);
                switch (dir[step++])
                {
                    case 'N':
                        Console.SetCursorPosition(left, --top);
                        Console.Write($"{step}");
                        break;
                    case 'S':
                        Console.SetCursorPosition(left, ++top);
                        Console.Write($"{step}");
                        break;
                    case 'W':
                        left -= 4;
                        Console.SetCursorPosition(left, top);
                        Console.Write($"{step}\t");
                        break;
                    case 'E':
                        left += 4;
                        Console.SetCursorPosition(left, top);
                        Console.Write($"{step}\t");
                        break;

                }
            }
            Console.SetCursorPosition(20, 20);
            if (!robot.WhereBot(step)) Console.WriteLine("Робот не вернулся на базу");
            Console.ReadLine();
            
        }
    }
}