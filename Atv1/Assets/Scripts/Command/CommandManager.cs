using System.Collections.Generic;

public class CommandManager 
{
    private List<ICommand> commands;

    public CommandManager()
    {
        commands = new List<ICommand>();
    }

    public void AddCommand(ICommand command)
    {
        commands.Add(command);
        command.Do();
    }
}
