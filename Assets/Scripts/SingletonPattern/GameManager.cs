using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public override void Awake()
    {
        base.Awake();
        Debug.Log("GameManager Awake!");
    }
    public void PrintMessage()
    {
        Debug.Log("GameManager is working!");
    }

  
}
