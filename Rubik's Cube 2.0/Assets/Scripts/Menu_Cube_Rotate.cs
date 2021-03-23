using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_Cube_Rotate : MonoBehaviour {

    public GameObject Menu_Cube;

    private void Update()
    {
        float spin_speed = 20f;
        //if (Input.GetMouseButtonDown(1))
            transform.Rotate(Vector3.up, spin_speed * Time.deltaTime);
    }

    private void OnMouseDrag()
    {
        float rotation_speed = 20;
        float rotX = Input.GetAxis("Mouse X") * rotation_speed * Mathf.Deg2Rad;
        float rotY = Input.GetAxis("Mouse Y") * rotation_speed * Mathf.Deg2Rad;
        float rotZ = Input.GetAxis("Mouse Y") * rotation_speed * Mathf.Deg2Rad;

        transform.RotateAround(Vector3.up, -rotX);
        transform.RotateAround(Vector3.right, rotY);
        transform.RotateAround(Vector3.forward, rotZ);
        //transform.Rotate(Vector3.up, -rotX);
        //transform.Rotate(Vector3.right, rotY);
        //transform.Rotate(Vector3.forward, rotZ);
    }
}
