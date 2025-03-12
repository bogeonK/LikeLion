using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //싱글톤
    //어디에서나 접근 할 수 있도록 statick(정적)으로 자기자신을 저장해서 싱글톤이라는 디자인 패턴을 사용
    public static GameManager instance;
    public Text scoreText;      // 점수를 표시하는 Text객체를 에디터에서 받아옴
    public Text startText;
  
    public int score = 0;  //점수를 관리
   

    void Awake()
    {
        if(instance == null)    //정적으로 자신을 체크. null인지
        {
            instance = this;    //자기자신을 저장
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
                startText.text = "Go!"; // 마지막 "Go!" 텍스트 표시
                yield return new WaitForSecondsRealtime(1);
                startText.gameObject.SetActive(false);  // UI감추기
            }
        }
        Time.timeScale = 1f;
    }

    public void AddScore(int num)
    {
        score += num; // 점수를 더해줌
        scoreText.text = "Score : " + score; //텍스트에 반영합니다.
        
    }

}
