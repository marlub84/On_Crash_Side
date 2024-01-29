using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 3f;
    private float horizontalInput;
    private float verticalInput;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");

        transform.Translate(Vector3.forward * verticalInput * speed);
        transform.Rotate(Vector3.up * horizontalInput * speed);
        
    }

}
