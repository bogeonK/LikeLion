using UnityEngine;

public class FunctionExample : MonoBehaviour
{
    // 함수 정의
    void SayHello()
    {
        Debug.Log("Hello Unity");
    }

    int AdDNumber(int a, int b)
    {
        return a + b;
    }


    void Start()
    {
        SayHello();
        int total = AdDNumber(3, 5);
        Debug.Log("Total " + total);
    }

    void Update()
    {
        
    }
}
