using UnityEngine;

public class FunctionExample : MonoBehaviour
{
    // �Լ� ����
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
