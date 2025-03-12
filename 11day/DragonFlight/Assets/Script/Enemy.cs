using UnityEngine;

public class Enemy : MonoBehaviour
{
    // ������ �ӵ�
    public float moveSpeed = 1.3f;

    void Start()
    {
        
    }

    void Update()
    {
        //������ �Ÿ� ���
        float distanceY = moveSpeed * Time.deltaTime;

        //������ �ݿ�
        transform.Translate(0, -distanceY, 0);
        
    }

    // ȭ�� ������ ���� ī�޶󿡼� ������ ������ ȣ��
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
