using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class DebugText : MonoBehaviour
{
    [SerializeField] TMP_Text debugText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        debugText.text = "TSP: " + InputManager.timeSincePressed;
    }
}
