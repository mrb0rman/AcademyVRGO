using System.Collections.Generic;

namespace Script.Game
{
    public class Invoker
    {
        public Stack<IPlayerCommand> sCommand = new Stack<IPlayerCommand>();

        public void Execute(IPlayerCommand command)
        {
            if (command != null)
            {
                sCommand.Push(command);
                sCommand.Peek().Execute();
            }
        }

        public void Undo()
        {
            if(sCommand.Count > 0)
            {
                sCommand.Peek().ExecuteUndo();
                sCommand.Pop();
            }
        }
    }
}

