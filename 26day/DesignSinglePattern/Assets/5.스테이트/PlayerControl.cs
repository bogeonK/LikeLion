using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private StateMachine stateMachin;

    void Start()
    {
        stateMachin = new StateMachine();
        stateMachin.ChangeState(new IdleState()); // 초기 상태로 IdleState
    }

    void Update()
    {
        stateMachin.Update();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            stateMachin.ChangeState(new JumpState());   //스페이스바를 누르면 점프상태로 변경
        }
        else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow))
        {
            stateMachin.ChangeState(new RunState());    //방향키를 누르면 달리기 상태로 변경
        }
        else if (!Input.anyKey)
        {
            stateMachin.ChangeState(new IdleState());   //아무 키도 누르지 않으면 IdleState로 변경
        }
    }
}
