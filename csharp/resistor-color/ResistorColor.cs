using System;

public static class ResistorColor
{
    static string[] RColors { get; } = new[] { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };

    public static int ColorCode(string color)
    {
        return Array.FindIndex(Colors(), (x) => x == color);

    }

    public static string[] Colors()
    {
        return RColors;
    }
}