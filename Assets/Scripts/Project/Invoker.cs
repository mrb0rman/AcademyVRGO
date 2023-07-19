using System.Collections.Generic;

namespace Script.Project
{
    public class Invoker
    {
        public Stack<CreateSpell> sCommand = new Stack<CreateSpell>();

        public void Execute(CreateSpell command)
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


