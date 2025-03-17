using UnityEngine;

public class Monster : MonoBehaviour
{
    public float Hp = 100;
    public float Speed = 3.0f;
    public float Delay = 1.0f;
    public Transform ms1;
    public Transform ms2;
    public GameObject bullet;

    // 아이템 가져오기
    public GameObject Item;

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

    //미사일에 따른 데미지 함수
    public void Damage(int attack)
    {
        Hp -= attack;
        if(Hp <= 0)
        {
            ItemDrop();
            Destroy(gameObject);
            //PoolManager.Instance.Return(gameObject);
        } 

    }

    public void ItemDrop()
    {
        //아이템 생성
        Instantiate(Item, transform.position, Quaternion.identity);
    }






}
