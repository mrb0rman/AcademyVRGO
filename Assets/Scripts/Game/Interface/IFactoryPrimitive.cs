using UnityEngine;

namespace Script.Game
{
    public interface IFactoryPrimitive
    {
        public Player Create(Primitive primitive);
    }
}