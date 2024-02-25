using UnityEngine;

// Para detectar colisiones, necesitamos Colliders y que al menos un Game Object implicado tenga Rigidbody
public class DetectCollisions : MonoBehaviour
{
    private gameManager managerGame;




    private void OnTriggerEnter(Collider other)
    {
    
        Destroy(gameObject);
        Destroy(other.gameObject);
        managerGame.animalsFedNum++;
        managerGame.animalscount();


    }


    private void Start()
    {
        managerGame = FindObjectOfType<gameManager>();

    }


}
