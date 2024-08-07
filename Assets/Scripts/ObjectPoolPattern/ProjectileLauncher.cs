using UnityEngine;

public class ProjectileLauncher : MonoBehaviour
{
    [SerializeField]
    private ObjectPool _projectilePool;

    [SerializeField] private int _initialSize;

    private void Start()
    {
        _projectilePool.Initialize(_initialSize);
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            FireProjectile();
        }
    }

    private void FireProjectile()
    {
        Projectile projectile = _projectilePool.Get() as Projectile;
        if (projectile != null)
        {
            projectile.transform.position = transform.position;
            projectile.transform.rotation = transform.rotation;
        }
    }
}
