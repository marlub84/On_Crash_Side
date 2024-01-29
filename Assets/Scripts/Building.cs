using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* 
 * Base class for building and resources
 * 
 */
public abstract class Building : MonoBehaviour
{
    private float points;
    private int type;

    public virtual string GetName()
    {
        return gameObject.name;
    }

    public virtual string GetData()
    {

        return "";
    }

  
}
