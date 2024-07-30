using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;

    private static readonly object lockObject = new object();

    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                lock (lockObject) 
                {
                    if (instance == null)
                    {
                        instance = FindObjectOfType<GameManager>();

                        if (instance == null)
                        {
                            GameObject obj = new GameObject("GameManager");
                            instance = obj.AddComponent<GameManager>();
                        }
                    }
                }
            }
            return instance;
        }
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); 
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void PrintMessage()
    {
        Debug.Log("GameManager is working!");
    }

  
}
