using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineHighlight : MonoBehaviour
{
    private RectTransform rt;

    void Start()
    {
        rt = GetComponent<RectTransform>();
    }

    public void highlightLine(LineItem l)
    {
        RectTransform lrt = l.GetComponent<RectTransform>();
        rt.anchoredPosition = lrt.anchoredPosition;
    }
}