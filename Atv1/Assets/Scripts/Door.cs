using System;
using UnityEngine;

public class Door : MonoBehaviour
{
    public string DoorID;

    private void OnEnable()
    {
        DoorController.OnButtonPressed += OnButtonPressed;
    }

    private void OnDisable()
    {
        DoorController.OnButtonPressed -= OnButtonPressed;
    }

    private void OnButtonPressed(string triggeredID)
    {
        if (triggeredID == DoorID)
        {
            OpenDoor();
        }
    }

    private void OpenDoor()
    {
        gameObject.SetActive(false);
    }
}