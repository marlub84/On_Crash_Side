using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OreResources : OreBase
{




    // Start is called before the first frame update
    void Start()
    {
        OreTypes oreTypes = OreTypes.iron;
        amount = 53;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void RemoveOre()
    {
        Destroy(gameObject);
    }
}
