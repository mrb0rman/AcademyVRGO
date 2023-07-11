using System;

namespace Script
{
    public interface ICommand
    {
        void Execute();
        void ExecuteUndo();
    }
}


