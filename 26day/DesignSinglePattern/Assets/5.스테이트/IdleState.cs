using UnityEngine;

public class IdleState : IState
{
    public void Enter()
    {
        Debug.Log("Idle상태 시작");
    }

    public void Update()
    {
        Debug.Log("Idle상태 시작");
    }

    public void Exit()
    {
        Debug.Log("Idle상태 종료");
    }

}
