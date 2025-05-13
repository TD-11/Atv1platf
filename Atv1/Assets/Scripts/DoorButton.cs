using UnityEngine;

public class DoorButton : MonoBehaviour
{
    public string doorID;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            DoorController.ButtonPressed(doorID);
        }
    }
}