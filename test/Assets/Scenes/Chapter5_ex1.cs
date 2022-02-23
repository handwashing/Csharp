using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter5_ex1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //        //사용자의 점수를 입력받아 90점 이상은 “A”,
        //        80점 이상은 “B”, 70점 이상은 “C”,
        //69점 이하 점수는 “F” 가 출력되는 프로그램을
        //만들어 주세요.

        string userinput = "70";
        int userScore = int.Parse(userinput);
        string score = "";

        if (userScore >= 90)
        {
            score = "a";
            //Debug.Log($"입력 점수 {userScore}는(은)" + $"A 학점 입니다.");
        }
        else if (userScore >= 80)
        {
            score = "b";
            //Debug.Log($"입력 점수 {userScore}는(은)" + $"b 학점 입니다.");
        }
        else if (userScore >= 70)
        {
            score = "c";
            //Debug.Log($"입력 점수 {userScore}는(은)" + $"c 학점 입니다.");
        }

        else
        {
            score = "f";
        }

        Debug.Log($"입력한 점수 {userScore}는(은) {score} 학점 입니다.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
