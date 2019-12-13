﻿using McMaster.Extensions.CommandLineUtils;
using Variety;

namespace VarletCli.Handler
{
    [Command("new", Description = "Create a new application")]
    public class CmdNewHandler
    {
        private void OnExecute(IConsole console)
        {
            console.WriteLine($"\nThis is new command\n");
        }
    }
}
