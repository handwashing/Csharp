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
        //    Debug.Log("À½¼ö"); 
        //}
        //else if(number > 0)
        //{ 
        //    Debug.Log("¾ç¼ö");
        //}
        //else
        //{ 
        //    Debug.Log("0"); 
        //}
        //if (number % 2 == 0)
        //{ 
        //    Debug.Log("Â¦¼ö");
        //}
        //else 
        //{ 
        //    Debug.Log("È¦¼ö"); 
        //} 

        //int a = 20;
        //string result = (a % 2) == 0 ? "Â¦¼ö" : "È¦¼ö";
        //Debug.Log(result);

        //string userinput = "35";

        //int number = int.Parse(userinput);
        //if(number > 0)
        //{
        //    if(number%2 == 0)
        //    { 
        //        Debug.Log("0º¸´Ù Å« Â¦¼ö.");
        //    }
        //    else
        //    {
        //        Debug.Log("0º¸´Ù Å« È¦¼ö.");
        //    }
        //}
        //else 
        //{
        //    Debug.Log("0º¸´Ù ÀÛ°Å³ª °°À½");

        //}
        //int number = 5;
        //Debug.Log(number % 2 == 0 ? "Â¦":"È¦");

        //string day = "±Ý";

        //switch (day)
        //{
        //    case "ÀÏ":
        //        Debug.Log("sunday");
        //        break;
        //    case "¿ù":
        //        Debug.Log("Monday");
        //        break;
        //    case "È­":
        //        Debug.Log("tuesday");
        //        break;
        //    case "¼ö":
        //        Debug.Log("wednesday");
        //        break;
        //    case "¸ñ":
        //        Debug.Log("thursday");
        //        break;
        //    case "±Ý":
        //        Debug.Log("friday");
        //        break;
        //    case "Åä":
        //        Debug.Log("saturday");
        //        break;
        //    default:
        //        Debug.Log($"{day}´Â(Àº) ¿äÀÏ ¾Æ´Ô");
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
            Debug.Log($"{i} : È¦¼ö");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
