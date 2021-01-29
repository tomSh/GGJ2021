using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace.UI
{
    public class Dialog : MonoBehaviour
    {
        public Image ToSwap;

        public Sprite WithArrow;
        public Sprite WithoutArrow;
        public GameObject NextButton;
        public TextMeshProUGUI Text;
        private string[] _dialog;
        private int _index;
        private static Dialog _instance;
        private GameObject _result;

        private void Awake()
        {
            _instance = this;
        }

        public void SetDialog(string[] lines, GameObject result)
        {
            _dialog = lines;
            _index = 0;

            _result = result;
            ToSwap.sprite = WithArrow;
            NextButton.SetActive(true);
            ShowNextLine();
        }

        public void ShowNextLine()
        {
            if (_dialog.Length == _index + 1)
            {
                ToSwap.sprite = WithoutArrow;
                NextButton.SetActive(false);

                if (_result != null)
                {
                    _result.SetActive(true);
                }
            }

            Text.text = _dialog[_index];
            _index++;
        }

        public static void Add(string[] storyLines, GameObject gameObject)
        {
            _instance.SetDialog(storyLines, gameObject);
        }
    }
}