using UnityEngine;

public class RunState : IState
{
    public void Enter()
    {
        Debug.Log("Run상태 시작");
    }

    public void Update()
    {
        Debug.Log("Run상태 시작");
    }

    public void Exit()
    {
        Debug.Log("Run상태 종료");
    }

}
