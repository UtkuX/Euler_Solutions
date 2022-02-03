
using System.Collections;
using System.Threading.Channels;


for (int i = 999; i > 99; i--)
{
    for (int j = 999; j > 99; j--)
    {
        int p = i * j;
        string _p = p.ToString();
        int a = _p.Length;
        if (a == 6)
        {
            int ilk_uc = Convert.ToInt32(_p[0..3]);
            int son_uc = Convert.ToInt32(_p[^2..a]);
            int son_uc_uc = Convert.ToInt32(_p[4..5]);
            int son_ucc = Convert.ToInt32(_p[3..4]);
            int nihai = son_uc * 100 + son_uc_uc * 10 + son_ucc;
            if (ilk_uc == nihai)
            {
               
                Console.WriteLine(p);
                return;
            }
        }
        else
        {
            int ilk_iki = Convert.ToInt32(_p[0..2]);
            int son_iki = Convert.ToInt32(_p[^1..a]);
            int son_iki_iki = Convert.ToInt32(_p[3..4]);
            int nihai = son_iki * 10 + son_iki_iki;
            if (ilk_iki == nihai)
            {
                Console.WriteLine(p);
                return;

            }
        }

        
    }
}
