using UnityEngine;

public class InputManager : MonoBehaviour
{
    // seconds
    public static float timeSincePressed = 9f;
    public static float timingThreshhold = 0.2f;
    public static bool trackTime = false;

    void Update()
    {
        // Debug.Log(timeSincePressed);
        if(Input.GetKeyDown(KeyCode.Space))
        {
            timeSincePressed = 0f;
            trackTime = true;
        }

        if (!trackTime) 
        {
            timeSincePressed = 9f;
            return;
        }

        timeSincePressed += Time.deltaTime;

        if (timeSincePressed >= timingThreshhold)
        {
            Debug.Log("MISS");
            trackTime = false;
        }
    }
}