using UnityEngine;

public class PlayerAnimEvents : MonoBehaviour
{
    private Player player;  

    void Start()
    {
        player = GetComponentInParent<Player>();
    }

    // Update is called once per frame
    public void AnimationTrigger()
    {
        player.AttackOver();
    }
}
