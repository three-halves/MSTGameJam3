using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopContainer : Tickable
{
    [SerializeField] private LineHighlight lineHighlight;
    [SerializeField] private List<LineItem> lines;
    [SerializeField] private int currentLineIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        Ticker.tickables.Add(this);
        lineHighlight.highlightLine(lines[0]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    override public void OnTick()
    {
        currentLineIndex = (currentLineIndex + 1) % lines.Count;
        LineItem currentLine = lines[currentLineIndex];
        lineHighlight.highlightLine(currentLine);

        if (currentLine.lineType == LineItem.LineType.Input)
        {
            if (InputManager.timeSincePressed <= InputManager.timingThreshhold)
            {
                Debug.Log("HIT");
            }
            else
            {
                Debug.Log("MISS");
            }
        }
    }
}
