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
        Debug.Log("���� " + animBoolName);

    }

    public virtual void Update()
    {
        Debug.Log("������Ʈ " + animBoolName);
    }

    public virtual void Exit()
    {
        Debug.Log("����Ʈ " + animBoolName);
    }



}
