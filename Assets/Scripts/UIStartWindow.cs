using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

namespace Script.UI
{
    public class UIStartWindow : Window
    {
        public UIStartWindow(Image image, float endX = 0, float endY = 0)
        {
            StartPositionX = image.rectTransform.localPosition.x;
            StartPositionY = image.rectTransform.localPosition.y;
            EndPositionX = endX;
            EndPositionY = endY;
            direction = new Vector3(EndPositionX - StartPositionX, EndPositionY - StartPositionY, 0)
                / (new Vector3(EndPositionX - StartPositionX, EndPositionY - StartPositionY, 0)).magnitude;
        }
    }
}