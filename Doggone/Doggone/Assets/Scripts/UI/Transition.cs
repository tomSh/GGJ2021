using UnityEngine;

namespace UI
{
    public class Transition : MonoBehaviour
    {
        public GameObject NextScreen;
        public void Go()
        {
            GameTracker.GoToScreen(NextScreen);
        }
    }
}
