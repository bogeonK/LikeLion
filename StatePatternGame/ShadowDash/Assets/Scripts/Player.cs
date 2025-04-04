using UnityEditorInternal;
using UnityEngine;

public class Player : Entity
{

    [SerializeField] private float moveSpeed;
    [SerializeField] private float jumpForce;

    [Header("대쉬 정보")]
    [SerializeField] private float dashSpeed;
    [SerializeField] private float dashDuration;
    [SerializeField] private float dashTime;

    [SerializeField] private float dashCoolDown;
    [SerializeField] private float dashCoolDownTimer;

    [Header("공격 정보")]
    [SerializeField] private float comboTime = 0.3f;
    private float comboTimeWindow;
    private bool isAttacking;
    private int comboCounter;


    private float xInput;

    protected override void Start()
    {
        base.Start();

    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();

        xInput = Input.GetAxis("Horizontal");

        Movement();
        CheckInput();


        dashTime -= Time.deltaTime;
        dashCoolDownTimer -= Time.deltaTime;
        comboTimeWindow -= Time.deltaTime;

        FlipController();
        AnimatorController();
    }

    private void DashAbility()
    {
        if (dashCoolDownTimer < 0 && !isAttacking)
        {
            dashCoolDownTimer = dashCoolDown;
            dashTime = dashDuration;
        }
    }

    public void AttackOver()
    {
        isAttacking = false;

        comboCounter++;

        if(comboCounter > 2)
        {
            comboCounter = 0;
        }
    }

    private void CheckInput()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            StartAttackEvent();
        }


        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            Jump();
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            DashAbility();
        }

    }

    private void StartAttackEvent()
    {
        if(!isGrounded)
        {
            return;
        }

        if (comboTimeWindow < 0)
            comboCounter = 0;

        isAttacking = true;
        comboTimeWindow = comboTime;
    }

    private void Movement()
    {
        if(isAttacking)
        {
            rb.linearVelocity = new Vector2(0, 0);
        }

        else if (dashTime > 0)
        {
            rb.linearVelocity = new Vector2(facingDir * dashSpeed, 0);
        }
        else
        {
            rb.linearVelocity = new Vector2(xInput * moveSpeed, rb.linearVelocity.y);
        }
    }

    private void Jump()
    {
        if (isGrounded)
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
    }

    private void AnimatorController()
    {
        bool IsMoving = rb.linearVelocity.x != 0;

        anim.SetFloat("yVelocity", rb.linearVelocityY);
        anim.SetBool("IsMoving", IsMoving);
        anim.SetBool("IsGrounded", isGrounded);
        anim.SetBool("IsDashing", dashTime > 0);
        anim.SetBool("IsAttacking", isAttacking);
        anim.SetInteger("comboCounter", comboCounter);
    }


    private void FlipController()
    {
        if (rb.linearVelocityX > 0 && !facingRight)
        {
            Flip();
        }
        else if(rb.linearVelocityX < 0 && facingRight)
        {
            Flip();
        }

    }

    protected override void CollisionChecks()
    {
        base.CollisionChecks();
    }

}
