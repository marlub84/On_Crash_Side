using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControll : MonoBehaviour
{
    public GameObject player;
    public GameObject pivot;

    //private Vector3 offset = new Vector3(0, 4, -7);
    //private Vector3 axis = new Vector3(1, 0, 0);
    //private float rotate = 25.0f;


    // Start is called before the first frame update
    void Start()
    {
        
        // Rotate camara to beter view
        //transform.Rotate(axis, rotate);
        pivot.transform.position = player.transform.position;
    }



    // Update is called once per frame
    void LateUpdate()
    {

        // We set camera behaind player
        transform.position = player.transform.position;// + offset;
        pivot.transform.rotation = player.transform.rotation;
    }
}
