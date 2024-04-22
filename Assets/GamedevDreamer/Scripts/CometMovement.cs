using UnityEngine;

public class CometMovement : MonoBehaviour
{
    // Швидкість руху комети
    private float speed = 5f;

    // Метод встановлення швидкості руху комети
    public void SetSpeed(float newSpeed)
    {
        speed = newSpeed;
    }

    // Метод викликається кожен кадр
    private void Update()
    {
        // Рухаємо комету вниз з заданою швидкістю
        // transform.Translate(Vector3.down * speed * Time.deltaTime);

        // Перевіряємо, чи комета виходить за межі камери
        // if (!IsVisible())
        // {
        //     // Якщо комета виходить за межі камери, видаляємо її
        //     Debug.Log("destroy commet in movement");
        //     Destroy(gameObject);
        // }
    }

    // Метод для перевірки, чи комета знаходиться в межах камери
    private bool IsVisible()
    {
        // Отримуємо позицію комети у просторі світу
        Vector3 viewportPosition = Camera.main.WorldToViewportPoint(transform.position);

        // Перевіряємо, чи координати знаходяться в межах видимості камери
        return viewportPosition.y > 0 && viewportPosition.y < 1 && viewportPosition.z > 0;
    }
}