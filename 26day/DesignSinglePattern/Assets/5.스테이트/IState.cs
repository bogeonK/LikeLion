using UnityEngine;

public interface IState
{
    void Enter();     // 상태 진입 시 실행
    void Update();    // 상태 진입 시 실핼
    void Exit();      // 상태 진입 시 실행
}
