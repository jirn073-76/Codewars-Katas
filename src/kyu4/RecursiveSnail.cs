using System;
    
public class SnailSolution
{
    public static int[] Snail(int[][] array)
    {
        void RecursiveSnail(int[][] arr, int i, int j, int m, int n, int c, ref int[] ret)
        {
            if (i >= m || j >= n)
                return;

            for (int p = i; p < n; p++)
                ret[c++] = arr[i][p];

            for (int p = i + 1; p < m; p++)
                ret[c++] = arr[p][n - 1];

            if ((m - 1) != i)
                for (int p = n - 2; p >= j; p--)
                    ret[c++] = arr[m - 1][p];

            if ((n - 1) != j)
                for (int p = m - 2; p > i; p--)
                    ret[c++] = arr[p][j];

            RecursiveSnail(arr, i + 1, j + 1, m - 1, n - 1, c, ref ret);
        }
        
        int len = array.Length, wid = array[0].Length;
        int[] retArr = new int[len * wid];
        RecursiveSnail(array, 0, 0, len, wid, 0, ref retArr);
        return retArr;
    }
}
