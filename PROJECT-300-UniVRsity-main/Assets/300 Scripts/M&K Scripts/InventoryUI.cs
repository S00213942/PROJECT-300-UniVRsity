using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryUI : MonoBehaviour
{
    private TextMeshProUGUI collectableText;
    void Start()
    {
        collectableText = GetComponent<TextMeshProUGUI>();
        Object.DontDestroyOnLoad(this.gameObject);
    }

    public void UpdateCollectableText(PlayerInventory playerInventory)
    {
        collectableText.text = playerInventory.NumberOfCollectables.ToString();
        Object.DontDestroyOnLoad(this.gameObject);
    }


}
