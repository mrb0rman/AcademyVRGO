using UnityEngine;

namespace Script.Game
{
    public interface IFactoryPrimitive
    {
        public GameObject Create(Primitive primitive);
    }
}