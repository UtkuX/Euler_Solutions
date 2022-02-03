int i;
int topla = 0;
for (i = 999; i > 0; i--)
{
    if (i%3 ==0 || i%5 ==0)
    {
        topla += i;
    }
}
Console.WriteLine(topla);//233168
