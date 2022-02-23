using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter3 : MonoBehaviour
{
    enum DialogResult { YES, NO, CANCEL, CONFIRM, OK }
    // Start is called before the first frame update
    void Start()
    {
        
    //int a = 123;
    //string b = a.ToString();
    //Debug.Log(b);

    // float c = 3.14f;
    //string d = c.ToString();
    //Debug.Log(d);

    // string e = "123456";
    // int f = int.Parse(e);
    //Debug.Log(f);

    //string g = "1.2345";
    // float h = float.Parse(g);
    //Debug.Log(h);

        Debug.Log((int)DialogResult.YES);
        Debug.Log((int)DialogResult.NO);
        Debug.Log((int)DialogResult.CANCEL);
        Debug.Log((int)DialogResult.CONFIRM);
        Debug.Log((int)DialogResult.OK);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
