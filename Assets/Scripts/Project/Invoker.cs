using System;
using Script.Game;
using System.Collections.Generic;

namespace Script.Project
{
    public class Invoker
    {
        public Stack<ISpellCommand> sCommand = new Stack<ISpellCommand>();

        public void Execute(ISpellCommand command)
        {
            if (command != null)
            {
                sCommand.Push(command);
                sCommand.Peek().Execute();
            }
        }

        public void Undo()
        {
            if (sCommand.Count > 0)
            {
                sCommand.Peek().ExecuteUndo();
                sCommand.Pop();
            }
        }
    }
}


