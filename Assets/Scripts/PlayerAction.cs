using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAction : MonoBehaviour
{
    [SerializeField] private Transform interactionPoint;
    [SerializeField] private float playerActivateDistans = 3f;

    [SerializeField] private LayerMask interactTableMask;

    private readonly Collider[] colliders = new Collider[3];
    [SerializeField] private int numFound;

    // Update is called once per frame
    void Update()
    {
        numFound = Physics.OverlapSphereNonAlloc(interactionPoint.position, playerActivateDistans, colliders, interactTableMask);

        if (Input.GetKeyDown(KeyCode.E) && numFound > 0)
        {
            //check if colliders is one of ore then mine 
            Debug.Log(colliders[0].name);
        }

    }
}
