using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ADDTest : MonoBehaviour
{


    private void Start()
    {
        //gameObject.name = "";
        //gameObject.name = "";
        gameObject.name = "demo";

    }

    void XinHanCheng()
    {
        int a;
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(5f);

        int a =2;
        int b = 3;
        int c = a + b;
        Debug.Log(c);

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
