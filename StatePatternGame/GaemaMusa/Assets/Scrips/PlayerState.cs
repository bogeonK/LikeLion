using UnityEngine;

public class PlayerState : MonoBehaviour
{
    protected PlayerStateMachine stateMachine;
    protected Player player;

    private string animBoolName;

    public PlayerState(Player _player, PlayerStateMachine _stateMachine, string _animBoolName)
    {
        player = _player;
        stateMachine = _stateMachine;
        animBoolName = _animBoolName;
    }

    public virtual void Enter()
    {
        Debug.Log("엔터 " + animBoolName);

    }

    public virtual void Update()
    {
        Debug.Log("업데이트 " + animBoolName);
    }

    public virtual void Exit()
    {
        Debug.Log("엑시트 " + animBoolName);
    }



}
