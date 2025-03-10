using UnityEngine;

public class VariableExample : MonoBehaviour
{
    // 변수 선언
    public int playerScore = 0;
    public float speed = 5.5f;
    public string playerName = "Hero";
    public bool isGameOver = false;


    void Start()
    {
        // 변수 출력
        Debug.Log("플레이어 이름 : " + playerName);
        Debug.Log("플레이어 점수 : " + playerScore);
        Debug.Log("속도 : " + speed);
        Debug.Log("게임 끝? : " + isGameOver);
        
    }

    void Update()
    {
        
    }
}
