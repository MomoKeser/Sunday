using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{       
        public float sensitivity;
    // Update is called once per frame
    void Update()
    {
        float xMovement = Input.GetAxis("Mouse X");
        float yMovement = Input.GetAxis("Mouse Y");
      
        Transform t = GetComponent<Transform>();
      t.Rotate(new Vector3(0, xMovement * sensitivity, 0f), Space.World);
      t.Rotate(new Vector3(-yMovement * sensitivity, 0f, 0f), Space.Self);
    }
}