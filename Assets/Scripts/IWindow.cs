using UnityEngine;
using UnityEngine.UI;

namespace Script.UI
{
    public interface IWindow
    {
        void Show(Image image, float speed);
    }
}