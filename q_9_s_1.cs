int c;
int b;
int a;
for (c = 1; c <= 1000; c++)
{
    for (b = 1000; b >= 1; b--)
    {
        for (a = 1000; a >= 1; a--)
        {
            if (c > b && b > a && a + b + c == 1000 && a * a + b * b == c * c)
            {
                Console.WriteLine(a*b*c);
            }
        }
    }
}
