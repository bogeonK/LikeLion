using UnityEngine;

public class PBullet : MonoBehaviour
{
    public float Speed = 4.0f;

    //���ݷ�
    public int Attack = 10;

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
        //PoolManager.Instance.Return(gameObject);
    }

    //�浹ó��
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Monster"))
        {
            //����Ʈ����
            GameObject go = Instantiate(effect, transform.position, Quaternion.identity);

            //1�ʵڿ� �����
            Destroy(go, 1);

            //���� ����
            collision.gameObject.GetComponent<Monster>().Damage(Attack);
            //PoolManager.Instance.Return(collision.gameObject);

            //�̻��� ����
            Destroy(gameObject);
        }

        if (collision.CompareTag("Boss"))
        {
            //����Ʈ����
            GameObject go = Instantiate(effect, transform.position, Quaternion.identity);

            //1�ʵڿ� �����
            Destroy(go, 1);

            //�̻��� ����
            Destroy(gameObject);
        }
    }
}
