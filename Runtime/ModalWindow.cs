using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Hirame.Athena
{
    public enum ModalWindowActionType
    {
        Action,
        Cancel,
        Close
    }
    
    public class ModalWindow : MonoBehaviour
    {
        [Header ("Content")]
        [SerializeField] private TMP_Text textContent;
        
        [Header ("Controls")]
        [SerializeField] private Button closeButton;

        public event UnityAction WindowClosed;
        
        public ModalWindow CreateWithContent (string textContent, UnityAction windowClosed = null)
        {
            var window = Instantiate (this);
            window.textContent.SetText (textContent);

            WindowClosed += windowClosed;
            return window;
        }
        
        private void Awake ()
        {
            if (closeButton)
                closeButton.onClick.AddListener (Close);
        }

        public void Close ()
        {
            WindowClosed?.Invoke ();
            WindowClosed = null;
            Destroy (gameObject);
        }
    }

}