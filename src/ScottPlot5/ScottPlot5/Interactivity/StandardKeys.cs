﻿namespace ScottPlot.Interactivity;

public static class StandardKeys
{
    public static readonly Key Alt = new("alt");
    public static readonly Key Control = new("ctrl");
    public static readonly Key Shift = new("shift");

    public static readonly Key Down = new("down");
    public static readonly Key Up = new("up");
    public static readonly Key Left = new("left");
    public static readonly Key Right = new("right");

    public static readonly Key Unknown = new("unknown");

    public static bool IsArrowKey(Key key)
    {
        if (key == Left) return true;
        else if (key == Right) return true;
        else if (key == Down) return true;
        else if (key == Up) return true;
        else return false;
    }
}
