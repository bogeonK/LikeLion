using UnityEngine;

public class PBullet : MonoBehaviour
{
    public float Speed = 4.0f;

    //공격력
    //이펙트
    public GameObject effect;
    public GameObject item;


    void Start()
    {
            
    }

    void Update()
    {
        // 미사일 위쪽방향으로
        // 위의 방향 * 스피드 * Time
        transform.Translate(Vector2.up * Speed * Time.deltaTime);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    //충돌처리
    private void OnTriggerEnter2D(Collider2D collision)
    {
        int x = Random.Range(0, 100);
        if (collision.CompareTag("Monster"))
        {
            //이펙트생성
            GameObject go = Instantiate(effect, transform.position, Quaternion.identity);

            //1초뒤에 지우기
            Destroy(go, 1);

            //몬스터 삭제
            Destroy(collision.gameObject);

            //미사일 삭제
            Destroy(gameObject);
            if (x < 10)
            {
                GameObject it = Instantiate(item, transform.position, Quaternion.identity);
            }
        }
    }
}
