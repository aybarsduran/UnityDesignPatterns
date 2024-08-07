using UnityEngine;

public class Projectile : PoolableObject
{
    public float speed = 10f;

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    void OnBecameInvisible()
    {
        ReturnToPool();
    }
}
