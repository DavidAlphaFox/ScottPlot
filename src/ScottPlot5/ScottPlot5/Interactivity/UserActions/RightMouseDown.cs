﻿namespace ScottPlot.Interactivity.UserInputs;

public record struct RightMouseDown(Pixel Pixel) : IMouseInput
{
    public DateTime DateTime { get; set; } = DateTime.Now;
}
