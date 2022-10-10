using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateOnHit : MonoBehaviour
{
    public GameObject pipePrefab;
        
    void OnTriggerEnter2D(Collider2D other)
    {
        bool otherGuyIsPlayer = other.gameObject.CompareTag("Player");
        if(otherGuyIsPlayer)
      {
        Debug.Log("REALY dumb fAT UGLY DOG-LOOKING FATY YOU ARE REALY FAT FATY BOOM BADY  UGLYDOG LOOKING FATTY 30000 POUNDS FAT Sweaty Fernando was hit by player AKA fAAAAAAAAAAAAAAAAAAAAAAAAAAAAATY beeeeeeeeeeeeeeeeeeean looking but! D:<");
        //TODO: Create a pipe thing yeah
        GameObject pipeCopy = GameObject.Instantiate(pipePrefab);
        Transform t = pipeCopy.GetComponent<Transform>();
        t.position = new Vector3(
                gameObject.transform.position.x + 18f,
                gameObject.transform.position.y,
                gameObject.transform.position.z);
      }
    }
 }