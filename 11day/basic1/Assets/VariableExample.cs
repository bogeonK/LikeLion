using UnityEngine;

public class VariableExample : MonoBehaviour
{
    // ���� ����
    public int playerScore = 0;
    public float speed = 5.5f;
    public string playerName = "Hero";
    public bool isGameOver = false;


    void Start()
    {
        // ���� ���
        Debug.Log("�÷��̾� �̸� : " + playerName);
        Debug.Log("�÷��̾� ���� : " + playerScore);
        Debug.Log("�ӵ� : " + speed);
        Debug.Log("���� ��? : " + isGameOver);
        
    }

    void Update()
    {
        
    }
}
