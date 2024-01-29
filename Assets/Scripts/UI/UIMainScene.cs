using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMainScene : MonoBehaviour
{
    public static UIMainScene Instance {  get; private set; }

    private void Awake()
    {
        Instance = this;

    }

    private void OnDestroy()
    {
        Instance = null;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
