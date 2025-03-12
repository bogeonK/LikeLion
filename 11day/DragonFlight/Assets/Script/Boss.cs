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
        if (instance == null)    //정적으로 자신을 체크. null인지
        {
            instance = this;    //자기자신을 저장
        }
    }

    void Start()
    {
       
    }

    public void SubHp(int num)
    {
        hp -= num; // 데미지
        bossHp.text = "Boss : " + hp; //텍스트에 반영합니다.
    }
    
}
