using System;
using UnityEngine;

public class DiableObject : MonoBehaviour
{
    public GameObject toDisable;
    private void Start()
    {
        toDisable.SetActive(false);
    }
}