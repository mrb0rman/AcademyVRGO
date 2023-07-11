
//Класс Invoker реализует
//стек комманд, их добавление и удаление из стека

using System;
using System.Collections;
using System.Collections.Generic;

namespace Script
{
    public class Invoker
    {
        Stack<ICommand> sCommand = new Stack<ICommand>();

        public void Execute(ICommand command)
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

