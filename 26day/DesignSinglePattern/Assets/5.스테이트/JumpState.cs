using UnityEngine;

public class JumpState : IState
{
    public void Enter()
    {
        Debug.Log("Jump상태 시작");
    }

    public void Update()
    {
        Debug.Log("Jump상태 시작");
    }

    public void Exit()
    {
        Debug.Log("Jump상태 종료");
    }

}
