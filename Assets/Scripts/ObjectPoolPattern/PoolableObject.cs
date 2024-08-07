using UnityEngine;

public class PoolableObject : MonoBehaviour
{
    private ObjectPool _pool;

    public void SetPool(ObjectPool pool)
    {
        _pool = pool;
    }

    public void ReturnToPool()
    {
        if (_pool != null)
        {
            Debug.Log($"Returning {gameObject.name} to pool");
            _pool.ReturnToPool(this);
        }
        else
        {
            Debug.Log($"No pool set for {gameObject.name}. Destroying object.");
            Destroy(gameObject);
        }
    }
}
