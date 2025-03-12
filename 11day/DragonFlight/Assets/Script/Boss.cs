using System.Collections;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Boss : MonoBehaviour
{

    public static Boss instance;
    public Text bossHp;
    public Text win;

    public int hp = 100;

    void Awake()
    {
        if (instance == null)    //�������� �ڽ��� üũ. null����
        {
            instance = this;    //�ڱ��ڽ��� ����
        }
    }

    void Start()
    {
       
    }

    public void SubHp(int num)
    {
        hp -= num; // ������
        bossHp.text = "Boss : " + hp; //�ؽ�Ʈ�� �ݿ��մϴ�.
    }
    
}
