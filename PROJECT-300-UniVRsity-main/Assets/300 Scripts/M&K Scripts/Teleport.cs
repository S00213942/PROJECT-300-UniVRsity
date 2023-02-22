using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Teleport : MonoBehaviour
{
    public Transform teleportDestination;
    void OnTriggerEnter(Collider teleport)
    {

        if (teleport.gameObject.tag == "Teleport")
        {

            transform.position = teleportDestination.position;
            
        }
    }
}