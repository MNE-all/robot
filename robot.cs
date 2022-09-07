

class Robot
{
    int x = 0, y = 0;

    public void Swipe(char dir)
    {
        switch (dir)
        {
            case 'N':
                y++;
                break;
            case 'S':
                y--;
                break;
            case 'E':
                x++;
                break;
            case 'W':
                x--;
                break;
        }
    }

    public bool WhereBot(int step)
    {
        if (x == 0 && y == 0 && step != 0)
        {
            Console.SetCursorPosition(20, 20);
            Console.WriteLine($"Робот вернуля за {step} шагов");
            return true;
        }
        return false;
    }


    
}

