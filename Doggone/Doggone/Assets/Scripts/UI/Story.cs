using UnityEngine;

namespace UI
{
    public class Story : MonoBehaviour
    {
        public string[] StoryLines;
        public GameObject[] ActivateObject;
        public void AddStory()
        {
            Dialog.Add(StoryLines, ActivateObject);
            
        }

    }
}