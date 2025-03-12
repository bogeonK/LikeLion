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
        //y�� �̵�
        transform.Translate(0, moveSpeed * Time.deltaTime,0);
    }

    private void OnBecameInvisible()
    {
        //�̻����� ȭ������� ������ �̻��� �����
        Destroy(gameObject);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // �̻��ϰ� ���� �ε���
        //if(collision.gameObject.tag == "Enemy")

        if(collision.gameObject.CompareTag("Enemy"))
        {
            SoundManager.instance.SoundDie();

            //���� ����Ʈ ����
            Instantiate(exposion, transform.position, Quaternion.identity);

            //�����ø���
            GameManager.instance.AddScore(10);

            //�������
            Destroy(collision.gameObject);

            //�Ѿ� ����� �ڱ��ڽ�
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("boss"))
        {

            //���� ����Ʈ ����
            Instantiate(exposion, transform.position, Quaternion.identity);

            //�����ø���
            Boss.instance.SubHp(10);
            //�Ѿ� ����� �ڱ��ڽ�
            Destroy(gameObject);

            if(Boss.instance.hp <= 0)
            {
                //�������
                Destroy(collision.gameObject);
                //���� ����Ʈ ����
                Instantiate(exposionBoss, transform.position, Quaternion.identity);

            }
        }
    }

}
