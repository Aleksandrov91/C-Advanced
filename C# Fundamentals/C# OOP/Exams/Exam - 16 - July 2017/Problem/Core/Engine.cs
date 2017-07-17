using System;
using System.Collections.Generic;
using System.Linq;

public class Engine
{
    private bool isRunning;
    private DraftManager manager;

    public Engine()
    {
        this.isRunning = true;
        this.manager = new DraftManager();
    }

    public void Run()
    {
        while (this.isRunning)
        {
            var line = Console.ReadLine().Split(' ').ToList();
            this.ExecuteCommand(line);
        }
    }

    private void ExecuteCommand(List<string> commandArgs)
    {
        var command = commandArgs[0];
        commandArgs.Remove(command);

        switch (command)
        {
            case "RegisterHarvester":
                Console.WriteLine(this.manager.RegisterHarvester(commandArgs));
                break;
            case "RegisterProvider":
                Console.WriteLine(this.manager.RegisterProvider(commandArgs));
                break;
            case "Day":
                Console.WriteLine(this.manager.Day());
                break;
            case "Mode":
                Console.WriteLine(this.manager.Mode(commandArgs));
                break;
            case "Check":
                Console.WriteLine(this.manager.Check(commandArgs));
                break;
            case "Shutdown":
                this.isRunning = false;
                Console.WriteLine(this.manager.ShutDown());
                break;
        }
    }
}