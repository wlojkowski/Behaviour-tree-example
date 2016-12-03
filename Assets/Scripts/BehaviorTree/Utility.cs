using System;
using System.Collections.Generic;

public static class Utility {
    public static List<T> Shuffle<T>(this IList<T> list)
    {
        List<T> shuffled = new List<T>();
        shuffled.AddRange(list);
        Random rnd = new Random();
        for(int i = 0;i<=shuffled.Count-2;i++)
        {
            int j = rnd.Next(i, shuffled.Count);
            Swap<T>(shuffled,i,j);
        }

        return shuffled;
    }

    public static void Swap<T>(IList<T> list,int a,int b)
    {
        T temp = list[a];
        list[a] = list[b];
        list[b] = temp;
    }

}
