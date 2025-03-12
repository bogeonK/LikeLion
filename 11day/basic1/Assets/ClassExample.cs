using UnityEngine;





public class Player
{
    public string name;
    public int score;

    public Player(string PlayerName, int PlayerScore)
    {
        name = PlayerName;
        score = PlayerScore;
    }

    public void ShowInfo()
    {
        Debug.Log("Player : " + name + "Score : " + score);
    }
}

public class ClassExample : MonoBehaviour
{
    void Start()
    {
        Player player1 = new Player("Hero", 10);
        player1.ShowInfo();
    }

    void Update()
    {
        
    }
}
