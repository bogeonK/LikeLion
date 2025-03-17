using UnityEngine;

public class Monster : MonoBehaviour
{
    public float Hp = 100;
    public float Speed = 3.0f;
    public float Delay = 1.0f;
    public Transform ms1;
    public Transform ms2;
    public GameObject bullet;

    // ������ ��������
    public GameObject Item;

    void Start()
    {
        //�Լ� �� �� ȣ��
        Invoke("CreateBullet", Delay);
        
    }

    void CreateBullet()
    {
        Instantiate(bullet, ms1.position, Quaternion.identity);
        Instantiate(bullet, ms2.position, Quaternion.identity);

        //���ȣ��
        Invoke("CreateBullet", Delay);
    }

    void Update()
    {
        //�Ʒ���������
        transform.Translate(Vector2.down * Speed * Time.deltaTime);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    //�̻��Ͽ� ���� ������ �Լ�
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
        //������ ����
        Instantiate(Item, transform.position, Quaternion.identity);
    }






}
