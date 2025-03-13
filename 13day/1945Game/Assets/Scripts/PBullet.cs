using UnityEngine;

public class PBullet : MonoBehaviour
{
    public float Speed = 4.0f;

    //���ݷ�
    //����Ʈ
    public GameObject effect;
    public GameObject item;


    void Start()
    {
            
    }

    void Update()
    {
        // �̻��� ���ʹ�������
        // ���� ���� * ���ǵ� * Time
        transform.Translate(Vector2.up * Speed * Time.deltaTime);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    //�浹ó��
    private void OnTriggerEnter2D(Collider2D collision)
    {
        int x = Random.Range(0, 100);
        if (collision.CompareTag("Monster"))
        {
            //����Ʈ����
            GameObject go = Instantiate(effect, transform.position, Quaternion.identity);

            //1�ʵڿ� �����
            Destroy(go, 1);

            //���� ����
            Destroy(collision.gameObject);

            //�̻��� ����
            Destroy(gameObject);
            if (x < 10)
            {
                GameObject it = Instantiate(item, transform.position, Quaternion.identity);
            }
        }
    }
}
