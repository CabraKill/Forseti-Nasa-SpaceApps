using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class airplanerotating : MonoBehaviour
{
    public float turnSpeed = 25f;

    // Update is called once per frame
    void Update() => transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
}
