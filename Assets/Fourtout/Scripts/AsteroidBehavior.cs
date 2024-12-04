using UnityEngine;

public class AsteroidBehavior : MonoBehaviour
{
    public float speed = 10f;

    
    void Update()
    {
        transform.Translate(Vector3.back * speed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("AstDest"))
        {
            Debug.Log("Collision Detected 🧱");
            Destroy(gameObject);
            Debug.Log("Asteroid Destroyed 💥");
        }
    }
}   
