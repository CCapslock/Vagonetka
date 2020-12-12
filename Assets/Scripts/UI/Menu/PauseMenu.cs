﻿using UnityEngine;


namespace Vagonetka
{
    public class PauseMenu : BaseMenu
    {
        [Header("Main panel of pause menu")]
        [SerializeField] private GameObject _mainPanel;
        [SerializeField] private ButtonUI _buttonContinue;

        private UIController _uiController;

        private void Start()
        {
            _uiController = GetComponentInParent<UIController>();

            _buttonContinue.GetControl.onClick.AddListener(() => _uiController.ResumeGame());
        }

        public override void Hide()
        {
            if (!IsShow) return;
            _mainPanel.gameObject.SetActive(false);
            IsShow = false;
        }

        public override void Show()
        {
            if (IsShow) return;
            _mainPanel.gameObject.SetActive(true);
            IsShow = true;
        }
    }
}
