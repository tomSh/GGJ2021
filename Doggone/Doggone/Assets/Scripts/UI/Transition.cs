using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

public class Transition : MonoBehaviour
{
    public GameObject NextScreen;
    public void Go()
    {
        GameTracker.GoToScreen(NextScreen);
    }
}
