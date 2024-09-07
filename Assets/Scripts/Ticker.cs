using UnityEngine;
using System.Collections.Generic;

public class Ticker : MonoBehaviour
{
    private float refTime;
    [SerializeField] private float tickTime = 1 / (120 / 60);

    [SerializeField] public static List<Tickable> tickables = new List<Tickable>();

    [SerializeField] private GameObject tickSFX;

    void Start()
    {
        refTime = Time.time;
    }

    void Update()
    {
        if (Time.time - refTime >= tickTime)
        {
            refTime = Time.time;
            foreach (var tickable in tickables)
            {
                Debug.Log(tickables);
                tickable.OnTick();
            }

            // play metronome tick here to stop overlap
            Instantiate(tickSFX);
        }
    }
}