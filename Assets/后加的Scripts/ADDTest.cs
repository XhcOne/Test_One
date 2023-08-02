using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ADDTest : MonoBehaviour
{


    private void Start()
    {
 
        gameObject.name = "";
        gameObject.name = "";

        gameObject.name = "123";
        gameObject.name = "456";


    }

    

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(5f);
        gameObject.name = "123";
        gameObject.name = "456";

        Debug.Log(9);

    }
    IEnumerator Delay2()
    {
        yield return new WaitForSeconds(5f);

        int a = 2;
        
        int c = a + 1;
        Debug.Log(c);

    }

}
