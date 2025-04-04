using System.Collections.Generic;
using Unity.Cinemachine;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [Header("�÷��̾� �Ӽ�")]
    public float speed = 5;
    public float jumpUp = 1;
    public float power = 5;
    public Vector3 direction;
    public GameObject slash;

    //�׸���
    public GameObject Shadow1;
    List<GameObject> sh = new List<GameObject>();

    //������
    public GameObject hit_lazer;

    bool bJump = false;
    Animator pAnimator;
    Rigidbody2D pRig2D;
    SpriteRenderer sp;

    public GameObject Jdust;

    //�ٴڸ���
    public GameObject Dust;

    //��������
    public GameObject walldust;

    //������
    public Transform wallChk;
    public float wallchkDistance;
    public LayerMask wLayer;
    bool isWall;
    public float slidingSpeed;
    public float wallJumpPower;
    public bool isWallJump;
    float isRight = 1;


    void Start()
    {
        pAnimator = GetComponent<Animator>();
        pRig2D = GetComponent<Rigidbody2D>();
        direction = Vector2.zero;
        sp = GetComponent<SpriteRenderer>();

    }


    void KeyInput()
    {
        direction.x = Input.GetAxisRaw("Horizontal"); //������ -1   0   1

        if (direction.x < 0)
        {
            //left
            sp.flipX = true;
            pAnimator.SetBool("Run", true);

            //��������� ����
            isRight = -1;

            //Shadowflip
            for (int i = 0; i < sh.Count; i++)
            {
                sh[i].GetComponent<SpriteRenderer>().flipX = sp.flipX;
            }

        }
        else if (direction.x > 0)
        {
            //right
            sp.flipX = false;
            pAnimator.SetBool("Run", true);

            isRight = 1;

            //Shadowflip
            for (int i = 0; i < sh.Count; i++)
            {
                sh[i].GetComponent<SpriteRenderer>().flipX = sp.flipX;
            }


        }
        else if (direction.x == 0)
        {
            pAnimator.SetBool("Run", false);


            for (int i = 0; i < sh.Count; i++)
            {
                Destroy(sh[i]); //���ӿ�����Ʈ�����
                sh.RemoveAt(i); //���ӿ�����Ʈ �����ϴ� ����Ʈ�����
            }


        }


        if (Input.GetMouseButtonDown(0)) //0�� ���ʸ��콺
        {
            pAnimator.SetTrigger("Attack");
            Instantiate(hit_lazer, transform.position, Quaternion.identity);
        }


    }


    void Update()
    {
        //�ð� ���� �Է� üũ (���� ����Ʈ Ű�� ������ ���ο� ��� ����)
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            //����Ʈ���μ��� ȭ�� ȿ��
            TimeController.Instance.SetSlowMotion(true);
        }


        if (!isWallJump)
        {
            KeyInput();
            Move();
        }



        //������ üũ
        isWall = Physics2D.Raycast(wallChk.position, Vector2.right * isRight, wallchkDistance, wLayer);
        pAnimator.SetBool("Grab", isWall);





        if (Input.GetKeyDown(KeyCode.W))
        {
            if (pAnimator.GetBool("Jump") == false)
            {
                Jump();
                pAnimator.SetBool("Jump", true);
                JumpDust();
            }

        }



        if (isWall)
        {
            isWallJump = false;
            //����������
            pRig2D.linearVelocity = new Vector2(pRig2D.linearVelocityX, pRig2D.linearVelocityY * slidingSpeed);
            //���� ����ִ� ���¿��� ����
            if (Input.GetKeyDown(KeyCode.W))
            {
                isWallJump = true;
                //������ ����
                GameObject go = Instantiate(walldust, transform.position + new Vector3(0.8f * isRight, 0, 0), Quaternion.identity);
                go.GetComponent<SpriteRenderer>().flipX = sp.flipX;

                Invoke("FreezeX", 0.3f);
                //����
                pRig2D.linearVelocity = new Vector2(-isRight * wallJumpPower, 0.9f * wallJumpPower);

                sp.flipX = sp.flipX == false ? true : false;
                isRight = -isRight;

            }

        }

    }

    void FreezeX()
    {
        isWallJump = false;
    }


    private float GROUND_CHECK_DISTANCE = 0.7f;

    private void FixedUpdate()
    {
        Debug.DrawRay(pRig2D.position, Vector3.down, new Color(0, GROUND_CHECK_DISTANCE, 0));

        //����ĳ��Ʈ�� ��üũ 
        RaycastHit2D rayHit = Physics2D.Raycast(pRig2D.position, Vector3.down, GROUND_CHECK_DISTANCE, LayerMask.GetMask("Ground"));

        CheckGroundedState(rayHit);
    }


    void CheckGroundedState(RaycastHit2D rayHit)
    {

        bool isGrounded = rayHit.collider != null && rayHit.distance < GROUND_CHECK_DISTANCE;

        if (isGrounded)
        {
            pAnimator.SetBool("Jump", false);
        }
        else
        {
            //�������� �ִ�
            if (!isWall)
            {
                //�׳� ����������
                pAnimator.SetBool("Jump", true);
            }
            else
            {
                //��Ÿ��
                pAnimator.SetBool("Grab", true);
            }
        }

    }


    public void Jump()
    {
        pRig2D.linearVelocity = Vector2.zero;

        pRig2D.AddForce(new Vector2(0, jumpUp), ForceMode2D.Impulse);
    }


    public void Move()
    {
        transform.position += direction * speed * Time.deltaTime;
    }


    public void AttSlash()
    {
        //�÷��̾� ������
        if (sp.flipX == false)
        {
            pRig2D.AddForce(Vector2.right * power, ForceMode2D.Impulse);
            //�÷��̾� ������
            GameObject go = Instantiate(slash, transform.position, Quaternion.identity);
            go.GetComponent<SpriteRenderer>().flipX = sp.flipX;
        }
        else
        {

            pRig2D.AddForce(Vector2.left * power, ForceMode2D.Impulse);
            //����
            GameObject go = Instantiate(slash, transform.position, Quaternion.identity);
            go.GetComponent<SpriteRenderer>().flipX = sp.flipX;
        }

    }

    //�׸���
    public void RunShadow()
    {
        if (sh.Count < 6)
        {
            GameObject go = Instantiate(Shadow1, transform.position, Quaternion.identity);
            go.GetComponent<Shadow>().TwSpeed = 10 - sh.Count;
            sh.Add(go);
        }
    }

    
    //�����
    public void LandDust(GameObject dust)
    {
        Instantiate(dust, transform.position + new Vector3(-0.114f, -0.467f, 0), Quaternion.identity);
    }

    //��������
    public void JumpDust()
    {
        if (!isWall)
        {
            Instantiate(Jdust, transform.position, Quaternion.identity);
            Debug.Log("�������� �������̾�");
        }
        else
        {
            //������
            //Instantiate(walldust, transform.position, Quaternion.identity);
            //Debug.Log("�������� �������̾�");
        }



    }

    //������
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawRay(wallChk.position, Vector2.right * isRight * wallchkDistance);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag( "Boss"))
        {
            SceneManager.LoadScene("Boss");
        }
    }
}

