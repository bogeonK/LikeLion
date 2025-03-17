using UnityEngine;

public class Lazer : MonoBehaviour
{
    public GameObject effect;
    Transform pos;  //플레이어 이동 값
    int Attack = 10;



    void Start()
    {
        pos = GameObject.FindWithTag("Player").GetComponent<Player>().pos;    
    }

    void Update()
    {
        transform.position = pos.position;  // 레이저가 플레이어의 pos를 계속 따라감
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Monster"))
        {
            collision.gameObject.GetComponent<Monster>().Damage(Attack++);
            CreateEffect(collision.transform.position);
        }

        if (collision.CompareTag("Boss"))
        {
            CreateEffect(collision.transform.position);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)          // 레이저는 계속 맞으니까
    {
        if (collision.CompareTag("Monster"))
        {
            collision.gameObject.GetComponent<Monster>().Damage(Attack++);
            CreateEffect(collision.transform.position);
        }

        if (collision.CompareTag("Boss"))
        {
            CreateEffect(collision.transform.position);
        }
    }


    void CreateEffect(Vector3 position)
    {
        GameObject go = Instantiate(effect, position, Quaternion.identity);
        Destroy(go, 1);
    }

}
