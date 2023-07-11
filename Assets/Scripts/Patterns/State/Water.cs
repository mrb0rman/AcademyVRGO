using System;
namespace Script
{
    public class Water
    {
        public IState state { get; set; }

        public Water(IState ws)
        {
            state = ws;
        }

        public void Heat()
        {
            state.Heat(this);
        }

        public void Frost()
        {
            state.Frost(this);
        }
    }
}


