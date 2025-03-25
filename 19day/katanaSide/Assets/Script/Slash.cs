using UnityEngine;

public class Slash : MonoBehaviour
{
    private GameObject p;
    Vector2 MousePos;
    Vector3 dir;

    float angle;
    Vector3 dirNo;

    public Vector3 direction = Vector3.right;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        p = GameObject.FindGameObjectWithTag("Player");

        Transform tr = p.GetComponent<Transform>();
        MousePos = Input.mousePosition;
        MousePos = Camera.main.ScreenToWorldPoint(MousePos);
        Vector3 Pos = new Vector3(MousePos.x, MousePos.y, 0);
        dir = Pos - tr.position;

        //바라보는 각도 구하기
        angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
    }

    // Update is called once per frame
    void Update()
    {
        //회전 적용
        transform.rotation = Quaternion.Euler(0, 0, angle);
        transform.position = p.transform.position;
    }

    public void Des()
    {
        Destroy(gameObject);
    }

}
