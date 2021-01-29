using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class GameTracker : MonoBehaviour
    {
        private static GameObject _current;

        private void Awake()
        {
            _current = gameObject;//shortcut
        }

        public static void GoToScreen(GameObject screen)
        {
            if (_current != null)
            {
                _current.SetActive(false);
            }

            _current = screen;
            screen.SetActive(true);
        }
    }
}