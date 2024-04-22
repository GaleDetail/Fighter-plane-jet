using UnityEngine;

public class CometSpawner : MonoBehaviour
{
    // Префаб комети
    public GameObject cometPrefab;

    // Швидкість руху комети
    public float cometSpeed = 5f;

    // Інтервал між створенням комет
    public float spawnInterval = 2f;

    // Час до наступного створення комети
    private float nextSpawnTime;

    // Метод викликається кожен кадр
    private void Update()
    {
        // Перевіряємо, чи настав час створення комети
        if (Time.time >= nextSpawnTime && cometPrefab != null) 
        {
            // Знаходимо випадкову позицію по горизонталі спереду до камери
            var spawnPosition = new Vector3(Random.Range(-10f, 10f), Camera.main.transform.position.y * 1.7f,
                Camera.main.transform.position.z);

            // Створюємо комету у випадковій позиції
            var comet = Instantiate(cometPrefab, spawnPosition, Quaternion.identity);

            // Налаштовуємо рух комети
            // var cometMovement = comet.GetComponent<CometMovement>();
            // if (cometMovement != null) cometMovement.SetSpeed(cometSpeed);

            // Оновлюємо час до наступного створення комети
            nextSpawnTime = Time.time + spawnInterval;
        }
    }
}