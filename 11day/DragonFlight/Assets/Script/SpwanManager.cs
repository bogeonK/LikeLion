using System.Collections;
using UnityEngine;

public class SpwanManager : MonoBehaviour
{
    public GameObject enemy;
    bool bossCreate;
    public GameObject boss;
    Transform bossSpwan;


    // 적 생성 함수
    void SpwanEnemy()
    {
        float randomX = Random.Range(-2f, 2f);  //적이 나타날 x좌표를 랜덤으로 생성

        // 적을 생성한다. randomX : 랜덤한 x값
        Instantiate(enemy, new Vector3(randomX, transform.position.y, 0f), Quaternion.identity);
    }
    
    void SpwanBoss()
    {

        if (boss == null) // 보스가 없으면 생성
        {
            boss = Instantiate(boss, bossSpwan.position, Quaternion.identity);
        }

        boss.transform.position = Vector3.MoveTowards(boss.transform.position, bossSpwan.position, Time.deltaTime * 2f);
        if(boss.transform.position == bossSpwan.position)
        {
            bossCreate = true;
        }
    }


    void Start()
    {
        bossSpwan = GameObject.Find("bossSpwan").GetComponent<Transform>();
        //SpawnEnemy 1 0.5f
        InvokeRepeating("SpwanEnemy", 1, 0.5f);

        bossCreate = false;
    }


    void Update()
    {
        if (GameManager.instance.score >= 100 && bossCreate == false) 
        {
            CancelInvoke("SpwanEnemy");
            SpwanBoss();
        }
    }
}
