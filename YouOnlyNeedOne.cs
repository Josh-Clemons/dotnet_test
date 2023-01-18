public class Kata
{
  public static bool Check(object[] a, object x)
  {
      foreach (object item in a) {
        if (item.Equals(x)) return true;
      }
    return false;
  }
}