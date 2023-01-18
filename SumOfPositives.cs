using System;
using System.Linq;

public class Kata
{
  public static int PositiveSum(int[] arr)
  {
    int sum = 0;
    foreach (int value in arr) {
      if (value > 0) sum += value;
    }
    return sum;
  }
}
