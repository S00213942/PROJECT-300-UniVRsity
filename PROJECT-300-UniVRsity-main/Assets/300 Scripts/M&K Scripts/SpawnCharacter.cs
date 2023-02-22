using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCharacter : MonoBehaviour
{
    [SerializeField] 
    private GameObject playerPrefab = null;

    [SerializeField]
    public GameObject SpawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        GameObject playerInstance = Instantiate(playerPrefab);
        playerInstance.transform.position = SpawnPoint.transform.position;
        Object.DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
