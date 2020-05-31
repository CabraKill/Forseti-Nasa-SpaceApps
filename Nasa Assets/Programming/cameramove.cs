using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramove : MonoBehaviour
{
    public float speed = 6.0f;

    public float timeUntil;
    float timer = 0;

    public Vector3 moveTo;
    public Vector3 rotation;

    bool moved = false;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += speed * transform.forward * Time.deltaTime;

        timer += Time.deltaTime;
        if(timer > timeUntil && !moved)
        {
            transform.position = moveTo;
            transform.eulerAngles = rotation;
            moved = true;
        }
    }
}
