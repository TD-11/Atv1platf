using System;
using UnityEngine;

public static class Door
{
    public static Action ButtonPressed;

    public static void DoorOpen()
    {
        ButtonPressed?.Invoke();
    }
}