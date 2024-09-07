using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineItem : Tickable
{
    public enum LineType
    {
        Pass,
        Input
    }

    [SerializeField] public LineType lineType;

    void Start()
    {
        Ticker.tickables.Add(this);
    }

    public override void OnTick()
    {
        Debug.Log("Tick");
    }
}