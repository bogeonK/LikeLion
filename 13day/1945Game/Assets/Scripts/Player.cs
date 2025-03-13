using UnityEngine;
using static UnityEditor.PlayerSettings;

public class Player : MonoBehaviour
{
    //���ǵ�
    public float moveSpeed = 5f;

    Animator ani; //�ִϸ����͸� ������ ����

    public GameObject bullet;  //�Ѿ� ���� 4�� �迭�� ���鿹��
    public GameObject bullet1;  //�Ѿ� ���� 4�� �迭�� ���鿹��
    public Transform pos = null;

    public int ItemCount = 0;

    //������

    //������

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
        if (Input.GetKeyDown(KeyCode.Space) && ItemCount == 0)
        {
            //������ ��ġ ���� �ְ� ����
            Instantiate(bullet, pos.position, Quaternion.identity);
        }

        if (Input.GetKeyDown(KeyCode.Space) && ItemCount >= 1)
        {
            //������ ��ġ ���� �ְ� ����
            Instantiate(bullet1, pos.position, Quaternion.identity);
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
            Destroy(collision.gameObject);
            ItemCount += 1;

        }
    }
}
