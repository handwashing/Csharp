using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //string userinput = "5";

        //int number = int.Parse(userinput);
        //if (number < 0) 
        //{ 
        //    Debug.Log("����"); 
        //}
        //else if(number > 0)
        //{ 
        //    Debug.Log("���");
        //}
        //else
        //{ 
        //    Debug.Log("0"); 
        //}
        //if (number % 2 == 0)
        //{ 
        //    Debug.Log("¦��");
        //}
        //else 
        //{ 
        //    Debug.Log("Ȧ��"); 
        //} 

        //int a = 20;
        //string result = (a % 2) == 0 ? "¦��" : "Ȧ��";
        //Debug.Log(result);

        //string userinput = "35";

        //int number = int.Parse(userinput);
        //if(number > 0)
        //{
        //    if(number%2 == 0)
        //    { 
        //        Debug.Log("0���� ū ¦��.");
        //    }
        //    else
        //    {
        //        Debug.Log("0���� ū Ȧ��.");
        //    }
        //}
        //else 
        //{
        //    Debug.Log("0���� �۰ų� ����");

        //}
        //int number = 5;
        //Debug.Log(number % 2 == 0 ? "¦":"Ȧ");

        //string day = "��";

        //switch (day)
        //{
        //    case "��":
        //        Debug.Log("sunday");
        //        break;
        //    case "��":
        //        Debug.Log("Monday");
        //        break;
        //    case "ȭ":
        //        Debug.Log("tuesday");
        //        break;
        //    case "��":
        //        Debug.Log("wednesday");
        //        break;
        //    case "��":
        //        Debug.Log("thursday");
        //        break;
        //    case "��":
        //        Debug.Log("friday");
        //        break;
        //    case "��":
        //        Debug.Log("saturday");
        //        break;
        //    default:
        //        Debug.Log($"{day}��(��) ���� �ƴ�");
        ////        break;

        //}

        //{
        //    int i = 10;

        //    while (i > 0) 
        //    {
        //        Debug.Log($"i:{i--}");
        //    }
        //}

        //int i = 3;

        //do
        //{
        //    Debug.Log($"a)i:{i--}");
        //}
        //while (i > 0);

        //do
        //{
        //    Debug.Log($"b)i:{i--}");
        //}
        //while (i > 0);

        //for (int i = 0; i < 5; ++i)
        //{
        //    Debug.Log(i);
        //}

        //int[] arr = new int[] { 0,1,2,3,4};

        //foreach(int a in arr)
        //{
        //    Debug.Log(a);
        //}

        //int i = 0;

        //while (i >= 0)
        //{
        //    if(i==10)
        //    {
        //        break;
        //    }
        //Debug.Log(i++);
        //}
        //Debug.Log("prison break");

        for(int i =0; i < 10; i++)
        {
            if(i % 2 == 0)
            { 
                continue;
            }
            Debug.Log($"{i} : Ȧ��");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
