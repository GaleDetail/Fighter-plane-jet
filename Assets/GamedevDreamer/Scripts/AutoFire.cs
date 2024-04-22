using UnityEngine;

public class AutoFire : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float fireRate = 0.5f;
    private float nextFireTime = 0f;
    [SerializeField] private float _bulletSpeed = 5f;

    void Update()
    {
        if (Time.time >= nextFireTime)
        {
            Shoot();
            nextFireTime = Time.time + fireRate / 2;
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.gravityScale = 0f;
        rb.velocity = bullet.transform.right * _bulletSpeed;
        Destroy(bullet, 2f);
    }

    // void OnCollisionEnter2D(Collider2D other)
    // {
    //     // Перевіряємо, чи зіткнувся снаряд з перешкодою
    //     if (other.CompareTag("Obstacle"))
    //     {
    //         Destroy(gameObject); // Знищуємо перешкоду
    //     }
    // }
}