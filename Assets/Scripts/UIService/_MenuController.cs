using UnityEngine;
using DG.Tweening;
using UnityEngine.EventSystems;
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
            _uiService.Get<StartUIWindow>().Button.onClick.AddListener(HideButton);
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.M) && !isShow)
            {
                _uiService.Show<StartUIWindow>();
                _uiService.Get<StartUIWindow>().Button.transform.DOMoveX(Screen.width / 2, 2f);
                isShow = !isShow;
            }
            
        }

        public void HideButton()
        {
            _uiService.Get<StartUIWindow>().Button.transform.DOMoveX(2 * Screen.width, 2f)
                .OnComplete(HideMenu);
            isShow = !isShow;
        }
        public void HideMenu()
        {
            _uiService.Hide<StartUIWindow>();
        }
    }
}