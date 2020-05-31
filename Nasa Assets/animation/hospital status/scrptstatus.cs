using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrptstatus : MonoBehaviour
{
    private Animator animator;
    private bool isAnimating = true;
    private float time = 0;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        Debug.Log("Has started!");
        change();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isAnimating && time >= 200f)
            change();
        else
            time += 1 * Time.deltaTime;
        
    }

    void stop()
    {
        isAnimating = false;
        animator.SetBool("isAnimating", false);
        Debug.Log("stop");
    }

    void change()
    {
        time = 0;
        isAnimating = true;
        int rand = Random.Range(1, 4);
        animator.SetInteger("state", rand);
        animator.SetBool("isAnimating", true);
        
    }
}
