using UnityEngine;

public class ShootingEnemy : MonoBehaviour
{
    [Header("�� ĳ���� �Ӽ�")]
    public float detectionRange = 10f; //�÷��̾� ���� ����
    public float shootingInterval = 2f; //�̻��� �߻� ����
    public GameObject missilePrefab;    //�̻��� ������

    [Header("���� ������Ʈ")]
    public Transform firePoint; //�̻��� �߻� ��ġ
    private Transform player;   //�÷��̾� ��ġ ����
    private float shootTimer;   //�̻��� �߻� Ÿ�̸� 
    private SpriteRenderer spriteRenderer; //��������Ʈ ���� ��ȯ��
    private Animator animator;  //�ִϸ��̼� ��Ʈ�ѷ�

    void Start()
    {
        //�ʿ��� ������Ʈ �ʱ�ȭ
        player = GameObject.FindGameObjectWithTag("Player").transform;
        spriteRenderer = GetComponent<SpriteRenderer>();
        shootTimer = shootingInterval; //Ÿ�̸� �ʱ�ȭ
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if(player == null) return; //�÷��̾ ������ ��������

        // v�÷��̾���� �Ÿ� ���
        float distanceToPlayer = Vector2.Distance(transform.position, player.position);

        if (distanceToPlayer <= detectionRange) 
        { 
            //�÷��̾� �������� ��������Ʈ ȸ��
            spriteRenderer.flipX = (player.position.x < transform.position.x);

            //�̻��� �߻� ����
            shootTimer -= Time.deltaTime;   // Ÿ�̸� ����
            if(shootTimer <= 0)
            {
                Shoot(); //�̻��� �߻�
                shootTimer = shootingInterval; //Ÿ�̸� �ʱ�ȭ
            }
        }

    }

    //�̻��� �߻� ����
    void Shoot()
    {
        //�̻��� ����
        GameObject missile = Instantiate(missilePrefab, firePoint.position, Quaternion.identity);

        //�÷��̾� �������� �߻� ���� ����
        Vector2 direction = (player.position - firePoint.position).normalized;
        missile.GetComponent<EnemyMissile>().SetDirection(direction);
    }

    //������ �����
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, detectionRange);
    }

    //�� ĳ���� ��� �ִϸ��̼�
    public void PlayDeathAnimation()
    {
        animator.SetBool("Death", true);
        //���û���: ��� �ִϸ��̼� ��� �� ������Ʈ ����
        Destroy(gameObject,animator.GetCurrentAnimatorStateInfo(0).length);
    }
}
