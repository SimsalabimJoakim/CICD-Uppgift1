﻿using System;

namespace CICD_Uppgift1
{
    class Program
    {
        static void Main()
        {
            Helpers.DatabaseBootstrapper.CheckTables();
            Views.ConsoleView.PromtLogin();
        }
    }
}