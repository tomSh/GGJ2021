using UnityEngine;

namespace DefaultNamespace.UI
{
    public class Story : MonoBehaviour
    {
        public string[] StoryLines;
        public GameObject ActivateObject;
        public void AddStory()
        {
            Dialog.Add(StoryLines, ActivateObject);
            
        }

    }
}