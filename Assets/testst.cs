using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testst : MonoBehaviour
{

    int a, b;
    void Start()
    {
        a = 5;
        b = 12;
        
        
        Debug.Log($"OK,{mathTwo(a,b)}");
    }
    int mathTwo(int num,int num2)     
    {
        int answer = num * num2;
        return answer;
    }
   
}
