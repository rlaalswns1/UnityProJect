using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculator : MonoBehaviour
{
    int Add(int x, int y)
    {
        //매개변수란?
        //함수의 정의에서 전달받은 인수를 함수 내부로 전달하기 위해
        //사용하는 변수
        return x + y;
    }

    int Substract(int x, int y)
    {
        return x - y; 
    }

    int Multiple(int x, int y)
    {
        return x * y;
    }

    int Divide(int x, int y)
    {
        return x / y;
    }

    void Start()
    {
        //30값 반환 출력X
        Debug.Log(Add(10, 20));
    }
}