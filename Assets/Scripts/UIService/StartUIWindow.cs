using UnityEngine;
using UnityEngine.UI;

namespace Script
{
    public class StartUIWindow : UIWindow
    {
        [SerializeField] private Button button;

        public Button Button { get => button; }
    }
}