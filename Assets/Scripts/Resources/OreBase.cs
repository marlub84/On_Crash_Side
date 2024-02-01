using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class OreBase : MonoBehaviour 
{
    OreTypes oreTypes;
    [SerializeField] protected int amount;

    protected int mineRate;

    public virtual float Mining()
    {
        // TODO Implement mining tools
        mineRate = 2;
        amount -= mineRate;

        if (amount < 0)
        {
            RemoveOre();
            return 0;
        }

        return mineRate;
    }

    public abstract void RemoveOre();

}

public enum OreTypes
{
    iron,
    copper,
    silicon,
    coal
}
