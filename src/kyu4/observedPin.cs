// CSharp
// This was an attempt to solve this WITHOUT using monadic functions (Aggregate, SelectMany, etc.)

using System;
using System.Linq;
using System.Collections.Generic;

public class Kata
{
    private static short[,] pad =
    {
            {-1, -1, -1, -1, -1},
            {-1, +1, +2, +3, -1},
            {-1, +4, +5, +6, -1},
            {-1, +7, +8, +9, -1},
            {-1, -1, +0, -1, -1},
            {-1, -1, -1, -1, -1}
    };

    private static (char, (ushort, ushort))[] mapping =
    {
            ('1', (1, 1)), ('2', (1, 2)), ('3', (1, 3)),
            ('4', (2, 1)), ('5', (2, 2)), ('6', (2, 3)),
            ('7', (3, 1)), ('8', (3, 2)), ('9', (3, 3)),
                           ('0', (4, 2))
    };

    private static (ushort, ushort) FindInMapping(char chr)
    {
        for (int i = 0; i < mapping.Length; i++)
            if (mapping[i].Item1 == chr)
                return mapping[i].Item2;

        throw new Exception("Not on the Numpad!");
    }

    public static char[][] _GetPINs(string observed)
    {
        List<short[]> solTemp = new List<short[]>();
        short[] tmp;

        for (int i = 0; i < observed.Length; i++)
        {
            var cords = FindInMapping(observed[i]);
            tmp = new short[5];
            tmp[0] = short.Parse(observed[i].ToString());
            for (int i2 = 1; i2 <= 4; ++i2)
            {
                switch (i2)
                {
                    case 1:
                        tmp[i2] = pad[cords.Item1 - 1, cords.Item2];
                        break;

                    case 2:
                        tmp[i2] = pad[cords.Item1 + 1, cords.Item2];
                        break;

                    case 3:
                        tmp[i2] = pad[cords.Item1, cords.Item2 - 1];
                        break;

                    case 4:
                        tmp[i2] = pad[cords.Item1, cords.Item2 + 1];
                        break;
                }
            }
            solTemp.Add((short[])tmp.Clone());
        }


        var sol = solTemp
              .Select(nums => nums.Where(n => n != -1))
              .Select(nums => nums.Select(n => Char.Parse(n.ToString())).ToArray())
              .ToArray();

        return sol;
    }

    public static List<String> GetPINs(string observed)
    {
        char[][] charArrs = Kata._GetPINs(observed);
        int[] numberOfPossibilities = new int[8];

        for (int i = 0; i < 8; i++)
        {
            if (i < charArrs.Length)
                numberOfPossibilities[i] = charArrs[i].Length;

            else
                numberOfPossibilities[i] = 0;
        }
        List<String> retList = new List<string>();
        String[] startingPos = new string[8];

        for (int i = 0; i < numberOfPossibilities[0]; i++)
        {
            startingPos[0] = "";
            String pos = charArrs[0][i].ToString();
            for (int i2 = 0; i2 < numberOfPossibilities[1]; i2++)
            {
                startingPos[1] = pos;
                pos += charArrs[1][i2].ToString();
                for (int i3 = 0; i3 < numberOfPossibilities[2]; i3++)
                {
                    startingPos[2] = pos;
                    pos += charArrs[2][i3].ToString();
                    for (int i4 = 0; i4 < numberOfPossibilities[3]; i4++)
                    {
                        startingPos[3] = pos;
                        pos += charArrs[3][i4].ToString();
                        for (int i5 = 0; i5 < numberOfPossibilities[4]; i5++)
                        {
                            startingPos[4] = pos;
                            pos += charArrs[4][i5].ToString();
                            for (int i6 = 0; i6 < numberOfPossibilities[5]; i6++)
                            {
                                startingPos[5] = pos;
                                pos += charArrs[5][i6].ToString();
                                for (int i7 = 0; i7 < numberOfPossibilities[6]; i7++)
                                {
                                    startingPos[6] = pos;
                                    pos += charArrs[6][i7].ToString();
                                    for (int i8 = 0; i8 < numberOfPossibilities[7]; i8++)
                                    {
                                        startingPos[7] = pos;
                                        pos += charArrs[7][i8].ToString();
                                        retList.Add(pos);
                                        pos = startingPos[7];
                                    }
                                    retList.Add(pos);
                                    pos = startingPos[6];
                                }
                                retList.Add(pos);
                                pos = startingPos[5];
                            }
                            retList.Add(pos);
                            pos = startingPos[4];
                        }
                        retList.Add(pos);
                        pos = startingPos[3];
                    }
                    retList.Add(pos);
                    pos = startingPos[2];
                }
                retList.Add(pos);
                pos = startingPos[1];
            }
            retList.Add(pos);
            pos = startingPos[0];
        }

        return retList.Where(str => str.Length == charArrs.Length)
                       .ToList();
    }
}

