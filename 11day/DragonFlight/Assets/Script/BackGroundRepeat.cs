using UnityEngine;

public class BackGroundRepeat : MonoBehaviour
{
    // ��ũ���� �ӵ��� ����� ������ ��
    public float scrollSpeed = 0.4f;

    //������ ���͸��� �����͸� �޾ƿ� ��ü�� ����
    private Material thisMaterial;

    void Start()
    {
        //��ü�� �����ɶ� ���� 1ȸ ȣ��Ǵ� �Լ�
        //���� ��ü�� component���� ������ Renderer��� ������Ʈ�� Material ������ �޾ƿ�

        thisMaterial = GetComponent<Renderer>().material;
    }

    void Update()
    {
        // ���Ӱ� �������� Offset ��ü�� ����
        Vector2 newOffset = thisMaterial.mainTextureOffset;
        // Y�κп� ���� y���� �ӵ��� ������ �����ؼ� ������
        newOffset.Set(0, newOffset.y + (scrollSpeed * Time.deltaTime));
        // ���������� offset���� ��������
        thisMaterial.mainTextureOffset = newOffset;
    }
}
