
 Console.Clear();

int xa = 1; int ya = 1;
int xb = 1; int yb = 30;
int xc = 40; int yc = 30;
Console.SetCursorPosition(xa, ya);
Console.WriteLine("a");
Console.SetCursorPosition(xb, yb);
Console.WriteLine("b");
Console.SetCursorPosition(xc, yc);
Console.WriteLine("c");
int x = xa, y = xb;
int count = 0;
while (count < 10000)
{   
    int what = new Random().Next(0, 3);
        if (what == 0)
            {
                x = (x + xa) / 2;
                y = (y + ya) / 2;
            }
        if (what == 1)
            {
                x = (x + xb) / 2;
                y = (y + yb) / 2;
            }
        if (what == 2)
            {
                x = (x + xс) / 2;
                y = (y + yс) / 2;
            }
    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    int v = count++;
}
