using UnityEngine;

public class InputManager : MonoBehaviour
{
    // seconds
    public static float timeSincePressed = 9f;
    public static float timingThreshhold = 0.2f;
    public static bool trackTime = true;

    void Update()
    {
        // Debug.Log(timeSincePressed);
        if(Input.GetKeyDown(KeyCode.Space))
        {
            timeSincePressed = 0f;
        }

        if (!trackTime) 
        {
            timeSincePressed = 9f;
            return;
        }

        timeSincePressed += Time.deltaTime;
    }
}