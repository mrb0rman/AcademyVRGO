
//Класс Invoker реализует
//стек комманд, их добавление и удаление из стека

using System.Collections.Generic;

namespace Script
{
    public class InvokerCube
    {
        Stack<ICubeCommand> sCommand = new Stack<ICubeCommand>();

        public void Execute(ICubeCommand command)
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

