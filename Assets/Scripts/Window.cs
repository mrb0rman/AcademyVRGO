using UnityEngine;
using UnityEngine.UI;

namespace Script.UI
{

    public abstract class Window : IWindow
    {
        public Vector3 direction;
        public float StartPositionX { get; set; }
        public float EndPositionX { get; set; }
        public float StartPositionY { get; set; }
        public float EndPositionY { get; set; }
        public float Magnitude { get; set; }
        

        public virtual void Show(Image image, float speed)
        {
            if (!((new Vector3(EndPositionX - image.rectTransform.localPosition.x, EndPositionY - image.rectTransform.localPosition.y, 0)).magnitude<= 4f))
            {
                image.rectTransform.localPosition += new Vector3(direction.x, direction.y, 0) * Time.deltaTime * speed;
            }
        }
    }
}