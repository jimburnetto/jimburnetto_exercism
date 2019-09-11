using System;

public static class ResistorColor
{
    public static int ColorCode(string color)
    {
        //var colors = Colors();
        return Array.FindIndex(Colors(), (x) => x.Equals(color));


    }

    public static string[] Colors()
    {
        //var colors = new[] { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };
        //return colors;
        return new[] { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };
    }
}