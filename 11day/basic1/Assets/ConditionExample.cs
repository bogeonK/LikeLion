using UnityEngine;

public class ConditionExample : MonoBehaviour
{
    public int health = 100;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        health -= 1; //체력 감소
        Debug.Log("Health: " + health);

        //조건문
        if (health <= 0)
        {
            Debug.Log("Game Over!");
        }
    }
}
