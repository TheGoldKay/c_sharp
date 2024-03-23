using System.Linq;
using System.Collections.Generic;
using System;

public class Kata
{
  public static int GetAverage(int[] marks)
  {
    int sum = marks.Aggregate(0, (acc, next) => acc + next);
    return sum / marks.Length;
  }
}