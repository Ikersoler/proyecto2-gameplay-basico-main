using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30f; // Límite superior
    private float bottomBound = -5f; // Límite inferior
    private uiManager uiManager;
    private gameManager gameManager;
    private void Update()
    {
        // La comida sale por la parte superior
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }

        // Los animales salen por la parte inferior
        if (transform.position.z < bottomBound)
        {
            Destroy(gameObject);
            gameManager.fedAnimalstext();
            Time.timeScale = 0; // Congelamos el tiempo
        }
    }


    private void Awake()
    {
        uiManager = FindObjectOfType<uiManager>();
        gameManager = FindObjectOfType<gameManager>();
       
    }
}
