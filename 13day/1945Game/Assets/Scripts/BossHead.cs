using UnityEngine;

public class BossHead : MonoBehaviour
{
    [SerializeField]    //직렬화
    GameObject bossblullet; //보스미사일

    //애니메이션에서 함수사용하기

    public void RightDownLaunch()
    {
        GameObject go = Instantiate(bossblullet, transform.position, Quaternion.identity);

        go.GetComponent<BossBullet>().Move(new Vector2(1, -1));
    }

    public void LeftDownLaunch()
    {
        GameObject go = Instantiate(bossblullet, transform.position, Quaternion.identity);

        go.GetComponent<BossBullet>().Move(new Vector2(-1, -1));
    }

    public void DownLaunch()
    {
        GameObject go = Instantiate(bossblullet, transform.position, Quaternion.identity);

        go.GetComponent<BossBullet>().Move(new Vector2(0, -1));
    }




}
