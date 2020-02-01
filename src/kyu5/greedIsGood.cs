// CSharp
using System;
using System.Collections.Generic;
using System.Linq;


public static class Kata
{
    public static int Score(int[] dice)
    {
        int points = 0;
        int[] rank = new int[] {1000,600,500,400,300,200};
        IEnumerable<int>[] dies =
        {
            dice.Where(x => x == 1),
            dice.Where(x => x == 6),
            dice.Where(x => x == 5),
            dice.Where(x => x == 4),
            dice.Where(x => x == 3),
            dice.Where(x => x == 2),
        };

        for (int i = 0; i < 6; i++)
        {
DiceCond:
            if (dies[i].Count() >= 3)
            {
                points += rank[i];
                dies[i] = dies[i].Skip(3);
                goto DiceCond;
            }
        }

        return points + dies[0].Count() * 100 + dies[2].Count() * 50;
  }
}
