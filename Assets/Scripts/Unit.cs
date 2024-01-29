using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


/* 
 * Base class for all unit.
 */
public abstract class Unit : MonoBehaviour
{
    protected float speed = 1f;

    protected abstract void Move();

    public virtual string GetName()
    {
        return gameObject.name;
    }

    public virtual string GetData()
    {

        return "";
    }
}
