using System.Linq;
using System.Collections.Generic;
using System;

public class Kata
{
  public static int GetAverage(int[] marks)
  {
    int s = 0;
    foreach(int num in marks)
    {
        s += num;
    }
    return s / marks.Length;
  }
}