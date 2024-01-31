using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class OreBase
{
    OreTypes oreTypes;
    public float amount;

    public float mineRate;

    public virtual float Mining()
    {
        // TODO Implement mining tools
        mineRate = 0.5f;
        amount -= mineRate;

        return mineRate;
    }

    public abstract void RemoveOre();

}

enum OreTypes
{
    iron,
    copper,
    silicon,

}
