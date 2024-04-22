using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f; // Швидкість руху літака
    public float rotationSpeed = 100f; // Швидкість обертання літака
    void Update()
    {
        // Рухаємо літак вперед та взад по осі Y
        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * verticalInput * moveSpeed * Time.deltaTime);

        // Обертаємо літак вліво та вправо по осі Z
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.forward * -horizontalInput * rotationSpeed * Time.deltaTime);
        
    }


}