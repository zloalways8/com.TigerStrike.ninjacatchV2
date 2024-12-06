using System;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public static bool IsPaused { get; private set; }

    public static event Action Paused;
    public static event Action Resumed;

    public void SetPause()
    {
        IsPaused = true;
        Paused?.Invoke();
    }

    public void SetResume()
    {
        IsPaused = false;
        Resumed?.Invoke();
    }
}