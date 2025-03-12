using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Bullet : MonoBehaviour
{
    public float moveSpeed = 0.45f;
    public GameObject exposion;
    public GameObject exposionBoss;
    public Text win;
 

    void Start()
    {
        SoundManager.instance.PlayBulletSound();
    }

    void Update()
    {
        //y축 이동
        transform.Translate(0, moveSpeed * Time.deltaTime,0);
    }

    private void OnBecameInvisible()
    {
        //미사일이 화면밖으로 나가면 미사일 지우기
        Destroy(gameObject);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // 미사일과 적이 부딪힘
        //if(collision.gameObject.tag == "Enemy")

        if(collision.gameObject.CompareTag("Enemy"))
        {
            SoundManager.instance.SoundDie();

            //폭발 이펙트 생성
            Instantiate(exposion, transform.position, Quaternion.identity);

            //점수올리기
            GameManager.instance.AddScore(10);

            //적지우기
            Destroy(collision.gameObject);

            //총알 지우기 자기자신
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("boss"))
        {

            //폭발 이펙트 생성
            Instantiate(exposion, transform.position, Quaternion.identity);

            //점수올리기
            Boss.instance.SubHp(10);
            //총알 지우기 자기자신
            Destroy(gameObject);

            if(Boss.instance.hp <= 0)
            {
                //적지우기
                Destroy(collision.gameObject);
                //폭발 이펙트 생성
                Instantiate(exposionBoss, transform.position, Quaternion.identity);

            }
        }
    }

}
