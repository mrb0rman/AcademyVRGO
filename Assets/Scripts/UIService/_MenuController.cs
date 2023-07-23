using UnityEngine;
using DG.Tweening;
using UnityEngine.UIElements;

namespace Script
{
    public class _MenuController : MonoBehaviour
    {
        /*public GameObject activePanel;
        public GameObject loadPanel;*/

        [SerializeField] UIROOT _ui;
        private UIService _uiService = new UIService();
        private AnimConroller _animConroller;
        private bool isShow = false;

        private void Start()
        {
            _uiService.Load();
            _uiService.Init(_ui);
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.M))
            {
                if (!isShow)
                {
                    _uiService.Show<StartUIWindow>();
                    _uiService.Get<StartUIWindow>().Button.transform.DOMoveX(Screen.width / 2, 2f);
                }
                else
                {
                    _uiService.Get<StartUIWindow>().Button.transform.DOMoveX(3 * Screen.width, 2f);
                    Invoke("HideMenu", 1f);

                }
                isShow = !isShow;
            }
            
        }

        public void HideMenu()
        {
            _uiService.Hide<StartUIWindow>();
        }
    }
}