using System;
namespace Script
{
    public class Object_
    {
        public IState state { get; set; }

        public Object_(IState ws)
        {
            state = ws;
        }

        public void Up()
        {
            state.Up(this);
        }

        public void Down()
        {
            state.Down(this);
        }
    }
}


