using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopContainer : Tickable
{
    [SerializeField] private LineHighlight lineHighlight;
    [SerializeField] private List<LineItem> lines;
    [SerializeField] private int currentLineIndex = 0;
    private float tickTime = 0f;
    private bool resultThisTick;
    // Start is called before the first frame update
    void Start()
    {
        Ticker.tickables.Add(this);
        lineHighlight.highlightLine(lines[0]);
    }

    // Update is called once per frame
    void Update()
    {
        tickTime += Time.deltaTime;
        if (resultThisTick) return;
        if (lines[currentLineIndex].lineType == LineItem.LineType.Input)
        {
            if (InputManager.timeSincePressed <= InputManager.timingThreshhold)
            {
                resultThisTick = true;
                Debug.Log("HIT");
            }
            // late
            else if (tickTime >= InputManager.timingThreshhold)
            {
                resultThisTick = true;
                Debug.Log("MISS");
            }
        }
    }

    override public void OnTick()
    {
        tickTime = 0f;
        resultThisTick = false;
        currentLineIndex = (currentLineIndex + 1) % lines.Count;
        lineHighlight.highlightLine(lines[currentLineIndex]);
    }
}
