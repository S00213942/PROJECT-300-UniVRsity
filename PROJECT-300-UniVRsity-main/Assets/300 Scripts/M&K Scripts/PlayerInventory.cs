using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour
{
    public int NumberOfCollectables { get; set; }

    public UnityEvent<PlayerInventory> OnCollectableCollected;

    public void CollectablesCollected()
    {
        NumberOfCollectables++;
        OnCollectableCollected.Invoke(this);
        Object.DontDestroyOnLoad(this.gameObject);
    }
}
