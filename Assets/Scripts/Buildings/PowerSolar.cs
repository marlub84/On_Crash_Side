using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerSolar : Building
{
    [SerializeField] private Transform interactionPoint;
    [SerializeField] private float playerActivateDistans = 5f;

    [SerializeField] private LayerMask interactTableMask;

    private readonly Collider[] colliders = new Collider[1];
    [SerializeField] private int numFound;

    [SerializeField]private int m_power = 0;
    public BuildType buíldType = BuildType.ePowerSolar;

    public int power {  get { return m_power; } set {  m_power = value; } }


    // Start is called before the first frame update
    void Start()
    {
        interactTableMask = LayerMask.GetMask("Player");
    }

    // Update is called once per frame
    void Update()
    {
        numFound = Physics.OverlapSphereNonAlloc(interactionPoint.position, playerActivateDistans, colliders, interactTableMask);

        if (numFound > 0)
        {
            //check if colliders is one of ore then mine 
            Debug.Log("PowerUp");

        }
    }
}
