using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopAfter : MonoBehaviour
{
    MeshRenderer renderer;

    public float popAfter;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        renderer.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        if(timer > popAfter )
        {
            if (!renderer.enabled) renderer.enabled = true;
        }
            else
        {
            timer += Time.deltaTime;
        }
    }
}
