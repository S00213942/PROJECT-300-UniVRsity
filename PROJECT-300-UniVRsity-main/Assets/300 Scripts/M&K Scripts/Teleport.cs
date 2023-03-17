using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Teleport : MonoBehaviour
{
    public Transform RC,CR, CA, AC, CD, DC;
    void OnTriggerEnter(Collider teleport)
    {

        if (teleport.gameObject.tag == "Teleport")
        {

            transform.position = RC.position;
            
        }
        if (teleport.gameObject.tag == "Teleport1")
        {

            transform.position = CR.position;

        }
        if (teleport.gameObject.tag == "Teleport2")
        {

            transform.position = CA.position;

        }
        if (teleport.gameObject.tag == "Teleport3")
        {

            transform.position = AC.position;

        }
        if (teleport.gameObject.tag == "Teleport4")
        {

            transform.position = CD.position;

        }
        if (teleport.gameObject.tag == "Teleport5")
        {

            transform.position = DC.position;

        }

    }
}