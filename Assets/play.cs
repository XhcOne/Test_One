using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class play : MonoBehaviour
{

    public Animator anim;


    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            anim.Play("fs");
        }
    }

}
