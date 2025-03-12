using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public float speed = 5.0f;  //이동속도
    void Start()
    {
        
    }

    void Update()
    {
        //Vector3 A = Vector3.right;

        ////키 입력에 따라 이동
        //float move = Input.GetAxis("Horizontal");
        //transform.Translate(Vector3.right * move * speed * Time.deltaTime); 

        //Vector3 move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);

        //transform.position += move * speed * Time.deltaTime;

        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        transform.Translate(move * speed * Time.deltaTime);
    }
}
