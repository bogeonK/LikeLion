using UnityEditorInternal;
using UnityEngine;

public class MoveWithGravity : MonoBehaviour
{
    public Rigidbody rb;

    public float jumpForce = 5.0f; // 점프힘

    void Start()
    {
        
    }

    void Update()
    {
        // Space 키를 누르면 점프
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Rigidbody : 물리효과를 추가해 중력을 적용
            //AddForce : 점프를 위해 오브젝트에 히믈 줌
            //ForceMode.Impulse : 순간적으로 힘을 가하는 옵션
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
