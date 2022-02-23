using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeesoyiChapter5_ex9 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int sum = 0;
        for (int i=1; i<11; i++)
        {
            if (1 % 3 == 0)
                continue;
            
                sum += i;
                Debug.Log(i);
            
        }
            Debug.Log($"¼öÀÇ ÇÕ :{sum} ");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
