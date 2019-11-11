using System;
using Godot;

namespace SampleProject
{
    public class Node : Node2D
    {
        public override void _Ready()
        {
            AppDomain.CurrentDomain.UnhandledException += UnhandledExceptionHandler;
        }

        private void UnhandledExceptionHandler(object sender, UnhandledExceptionEventArgs e)
        {
            GD.PrintS($"Got unhandled exception {e.ExceptionObject}");
            GD.PrintErr("Quitting due to exception");
        }
    }
}