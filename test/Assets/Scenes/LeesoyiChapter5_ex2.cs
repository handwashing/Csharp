using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeesoyiChapter5_ex2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string userinput = "56";

        int number = int.Parse(userinput);
        if(number >= 50)
        {
            Debug.Log("50 �̻��� ��");
        }

        else
        {
            Debug.Log("50 �̸��� ��");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
