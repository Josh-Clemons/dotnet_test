using System;

public class LoveDetector
{
    public static bool lovefunc(int flower1, int flower2)
    { 
        int flower1Remainder = flower1 % 2;
        int flower2Remainder = flower2 % 2;
        if (flower1Remainder == flower2Remainder) {
            return false;
        }
        return true;
    }
}