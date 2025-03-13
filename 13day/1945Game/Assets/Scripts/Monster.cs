using UnityEngine;

public class Monster : MonoBehaviour
{
    public float Speed = 3.0f;
    public float Delay = 1.0f;
    public Transform ms1;
    public Transform ms2;
    public GameObject bullet;

    void Start()
    {
        //함수 한 번 호출
        Invoke("CreateBullet", Delay);
        
    }

    void CreateBullet()
    {
        Instantiate(bullet, ms1.position, Quaternion.identity);
        Instantiate(bullet, ms2.position, Quaternion.identity);

        //재귀호출
        Invoke("CreateBullet", Delay);
    }

    void Update()
    {
        //아래방향으로
        transform.Translate(Vector2.down * Speed * Time.deltaTime);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
