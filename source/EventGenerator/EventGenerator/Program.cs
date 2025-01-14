﻿using Terminal.Gui;
using System;
using System.Globalization;
using System.Net.Http.Headers;
using EventGenerator.Handlers;
using EventGenerator.Modules;

namespace EventGenerator
{
    internal partial class Program
    {
        public static string Version = "1.0-preview";
        
        static void Main(string[] args)
        {
            if (OperatingSystem.IsWindows())
            {
                Console.SetWindowSize(160, 80);
            }
            
            Application.Init();
                  
            var editor = new Editor();
            editor.DisplayEditorWindow();
            
            Application.Top.Closed += (_) => Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
            Application.Run();
        }
    }
}
