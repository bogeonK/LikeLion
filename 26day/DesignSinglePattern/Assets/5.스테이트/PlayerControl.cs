using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private StateMachine stateMachin;

    void Start()
    {
        stateMachin = new StateMachine();
        stateMachin.ChangeState(new IdleState()); // �ʱ� ���·� IdleState
    }

    void Update()
    {
        stateMachin.Update();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            stateMachin.ChangeState(new JumpState());   //�����̽��ٸ� ������ �������·� ����
        }
        else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow))
        {
            stateMachin.ChangeState(new RunState());    //����Ű�� ������ �޸��� ���·� ����
        }
        else if (!Input.anyKey)
        {
            stateMachin.ChangeState(new IdleState());   //�ƹ� Ű�� ������ ������ IdleState�� ����
        }
    }
}
