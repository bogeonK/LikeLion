using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //�̱���
    //��𿡼��� ���� �� �� �ֵ��� statick(����)���� �ڱ��ڽ��� �����ؼ� �̱����̶�� ������ ������ ���
    public static GameManager instance;
    public Text scoreText;      // ������ ǥ���ϴ� Text��ü�� �����Ϳ��� �޾ƿ�
    public Text startText;
  
    public int score = 0;  //������ ����
   

    void Awake()
    {
        if(instance == null)    //�������� �ڽ��� üũ. null����
        {
            instance = this;    //�ڱ��ڽ��� ����
        }
    }

    void Start()
    {
        StartCoroutine("StartGame");
    }

    IEnumerator StartGame()
    {
        Time.timeScale = 0f;
        int i = 3;
        while (i > 0)
        {
            startText.text = i.ToString();

            yield return new WaitForSecondsRealtime(1);

            i--;

            if(i == 0)
            {
                startText.text = "Go!"; // ������ "Go!" �ؽ�Ʈ ǥ��
                yield return new WaitForSecondsRealtime(1);
                startText.gameObject.SetActive(false);  // UI���߱�
            }
        }
        Time.timeScale = 1f;
    }

    public void AddScore(int num)
    {
        score += num; // ������ ������
        scoreText.text = "Score : " + score; //�ؽ�Ʈ�� �ݿ��մϴ�.
        
    }

}
