using Unity.Mathematics;
using UnityEditor;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class Player : MonoBehaviour
{
    //���ǵ�
    public float moveSpeed = 5f;

    Animator ani; //�ִϸ����͸� ������ ����

    public GameObject[] bullet;  //�Ѿ� ���� 4�� �迭�� ���鿹��
    public Transform pos = null;

    public int ItemCount = 0;

    [SerializeField]
    private GameObject powerUp;     //private �ν����Ϳ��� ����ϴ� ���

    //������
    public GameObject lazer;
    public float gValue = 0;

    void Start()
    {
        ani = GetComponent<Animator>();
        
    }

    void Update()
    {
        //����Ű�� ���� ������
        float moveX = moveSpeed * Time.deltaTime * Input.GetAxis("Horizontal");
        float moveY = moveSpeed * Time.deltaTime * Input.GetAxis("Vertical");

        // -1     0     1
        if (Input.GetAxis("Horizontal") <= -0.5f)
            ani.SetBool("left", true);
        else
            ani.SetBool("left", false);

        if (Input.GetAxis("Horizontal") >= 0.5f)
            ani.SetBool("right", true);
        else
            ani.SetBool("right", false);

        if (Input.GetAxis("Vertical") >= 0.5f)
            ani.SetBool("up", true);
        else
            ani.SetBool("up", false);

        //�����̽�
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //������ ��ġ ���� �ְ� ����
            Instantiate(bullet[ItemCount], pos.position, Quaternion.identity);
        }

        if (Input.GetKey(KeyCode.R))
        {
            gValue += Time.deltaTime;

            if(gValue >= 1)
            {
                GameObject go = Instantiate(lazer, pos.position, quaternion.identity);
                Destroy(go,3);
                gValue = 0;
            }
            
        }
        else
        {
            gValue -= Time.deltaTime;
            if(gValue <= 0)
            {
                gValue = 0;
            }
        }

        transform.Translate(moveX, moveY, 0);

        //ĳ������ ���� ��ǥ�� ����Ʈ ��ǥ��� ��ȯ���ش�.
        Vector3 viewPos = Camera.main.WorldToViewportPoint(transform.position);
        viewPos.x = Mathf.Clamp01(viewPos.x); //x���� 0�̻�, 1���Ϸ� �����Ѵ�.
        viewPos.y = Mathf.Clamp01(viewPos.y); //y���� 0�̻�, 1���Ϸ� �����Ѵ�.
        Vector3 worldPos = Camera.main.ViewportToWorldPoint(viewPos);//�ٽÿ�����ǥ�� ��ȯ
        transform.position = worldPos; //��ǥ�� �����Ѵ�.
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Item"))
        {
 
            ItemCount += 1;

            if (ItemCount >= 3)
                ItemCount = 3;
            else
            {
                //�Ŀ���
                GameObject go = Instantiate(powerUp, transform.position, Quaternion.identity);
                Destroy(go,1);

            }

            Destroy(collision.gameObject);

        }
    }
}
