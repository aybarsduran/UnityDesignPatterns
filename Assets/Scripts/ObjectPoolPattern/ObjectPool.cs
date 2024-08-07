using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField]
    private PoolableObject _prefab;

    [SerializeField]

    private readonly Queue<PoolableObject> _objects = new Queue<PoolableObject>();

    public void Initialize(int initialSize)
    {
        for (int i = 0; i < initialSize; i++)
        {
            PoolableObject obj = Instantiate(_prefab);
            obj.gameObject.SetActive(false);
            obj.SetPool(this); 
            _objects.Enqueue(obj);

            Debug.Log($"Object created and added to pool: {obj.name}");
        }
    }

    public PoolableObject Get()
    {
        if (_objects.Count > 0)
        {
            PoolableObject obj = _objects.Dequeue();
            obj.gameObject.SetActive(true);
            Debug.Log($"Object retrieved from pool: {obj.name}");
            return obj;
        }
        else
        {
            PoolableObject obj = Instantiate(_prefab);
            obj.SetPool(this); 
            Debug.Log($"Object created and returned: {obj.name}");
            return obj;
        }
    }

    public void ReturnToPool(PoolableObject obj)
    {
        obj.gameObject.SetActive(false);
        _objects.Enqueue(obj);
        Debug.Log($"Object returned to pool: {obj.name}");
    }
}
