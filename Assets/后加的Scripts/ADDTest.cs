using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ADDTest : MonoBehaviour
{


    private void Start()
    {



        gameObject.name = "123";
        gameObject.name = "456";


    }

    

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(5f);

      
        Debug.Log(9);

    }
    IEnumerator Delay2()
    {
        yield return new WaitForSeconds(5f);

        int a = 2;
        int b = 3;
        int c = a + b;
        Debug.Log(c);

    }

}
