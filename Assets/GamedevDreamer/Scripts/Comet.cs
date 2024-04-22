using UnityEngine;

public class Comet : MonoBehaviour
{
    private void Update()
    {
        // Рухаємо комету вниз з заданою швидкістю
        transform.Translate(Vector3.down * 10 * Time.deltaTime);
    }
    // Додайте будь-які інші змінні або параметри, які вам потрібні для цього скрипту

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Перевіряємо, чи зіткнулася перешкода з вогнем
        if (other.gameObject.CompareTag("Bullet"))
        {
            Destroy(gameObject); // Знищуємо перешкоду
            Debug.Log("try to destroy obstacle");
        }
    }
}