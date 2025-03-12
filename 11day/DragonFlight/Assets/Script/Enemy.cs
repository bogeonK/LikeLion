using UnityEngine;

public class Enemy : MonoBehaviour
{
    // 움직일 속도
    public float moveSpeed = 1.3f;

    void Start()
    {
        
    }

    void Update()
    {
        //움직일 거리 계산
        float distanceY = moveSpeed * Time.deltaTime;

        //움직임 반영
        transform.Translate(0, -distanceY, 0);
        
    }

    // 화면 밖으로 나가 카메라에서 보이지 않으면 호출
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
