using UnityEngine;
using Random = UnityEngine.Random;
public class PlayerController : MonoBehaviour
{
    private float speed = 10f;
    private float horizontalInput;
    private float xRange = 15f;
    public int disparo;
    [SerializeField] private GameObject foodPrefab;
    
    private void Update()
    {
        // Movimiento
        Movement();
        
        // Disparo
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ShootFood();
        }
        
    }

    private void Movement()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);
        
        PlayerInBounds();
    }

    private void PlayerInBounds()
    {
        Vector3 pos = transform.position;

        // Límite por la izquierda
        if (pos.x < -xRange)
        {
            transform.position = new Vector3(-xRange, pos.y, pos.z);
        }
        
        // Límite por la derecha
        if (pos.x > xRange)
        {
            transform.position = new Vector3(xRange, pos.y, pos.z);
        }
        
    }

    private void ShootFood()
    {
        
        if (disparo == 1)
        {
            Instantiate(foodPrefab, transform.position, Quaternion.identity);
        }
        else
        {

            float RandomDirection= Random.Range(-45, 45);
            Instantiate(foodPrefab, transform.position, Quaternion.Euler(0, RandomDirection, 0));
        }
    }
}
