using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter5_ex1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //        //������� ������ �Է¹޾� 90�� �̻��� ��A��,
        //        80�� �̻��� ��B��, 70�� �̻��� ��C��,
        //69�� ���� ������ ��F�� �� ��µǴ� ���α׷���
        //����� �ּ���.

        string userinput = "70";
        int userScore = int.Parse(userinput);
        string score = "";

        if (userScore >= 90)
        {
            score = "a";
            //Debug.Log($"�Է� ���� {userScore}��(��)" + $"A ���� �Դϴ�.");
        }
        else if (userScore >= 80)
        {
            score = "b";
            //Debug.Log($"�Է� ���� {userScore}��(��)" + $"b ���� �Դϴ�.");
        }
        else if (userScore >= 70)
        {
            score = "c";
            //Debug.Log($"�Է� ���� {userScore}��(��)" + $"c ���� �Դϴ�.");
        }

        else
        {
            score = "f";
        }

        Debug.Log($"�Է��� ���� {userScore}��(��) {score} ���� �Դϴ�.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
