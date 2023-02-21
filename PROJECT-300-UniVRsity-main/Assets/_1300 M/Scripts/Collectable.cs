using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();
        Object.DontDestroyOnLoad(this.gameObject);
        if (playerInventory != null)
        {
            playerInventory.CollectablesCollected();
            gameObject.SetActive(false);
            Object.DontDestroyOnLoad(this.gameObject);
        }
    }
}
