using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControll : MonoBehaviour
{
    public GameObject player;
    public GameObject pivot;



    // Start is called before the first frame update
    void Start()
    {
        
        pivot.transform.position = player.transform.position;
    }



    // Update is called once per frame
    void LateUpdate()
    {

        // We set camera behaind player
        transform.position = player.transform.position;
        pivot.transform.rotation = player.transform.rotation;
    }
}
