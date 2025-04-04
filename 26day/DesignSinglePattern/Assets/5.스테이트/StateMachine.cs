using UnityEngine;

public class StateMachine 
{
    private IState currentState;

    public void ChangeState(IState newState)
    {
        currentState?.Exit(); // ���� ������ Exit() ȣ��
        currentState = newState;    //�� ���·� ����
        currentState.Enter(); // �� ������ Enter() ȣ��
    }

    public void Update()
    {
        currentState?.Update(); // ���� ������ Update() ȣ��
    }
}
