using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public float speed = 5.0f;  //�̵��ӵ�
    void Start()
    {
        
    }

    void Update()
    {
        //Vector3 A = Vector3.right;

        ////Ű �Է¿� ���� �̵�
        //float move = Input.GetAxis("Horizontal");
        //transform.Translate(Vector3.right * move * speed * Time.deltaTime); 

        //Vector3 move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);

        //transform.position += move * speed * Time.deltaTime;

        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        transform.Translate(move * speed * Time.deltaTime);
    }
}
