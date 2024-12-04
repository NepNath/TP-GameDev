using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEditor.Callbacks;
using UnityEngine;

public class PlayerKeyboardMovement : MonoBehaviour
{

    [Header("Player Movement details")]
    public float speed = 10f;
    public float JumpForce = 10f;
    public float DashForce = 10f;
    public Rigidbody Rigidbody;
    public float maxSpeed = 20f; // Limite de vitesse

    private bool isGrounded;


    void Start()
    {
        
    }

    void Update()
    {
        float HorizontalInput = Input.GetAxis("Horizontal"); // A = -1, D = 1
        
        transform.Translate(new Vector3(0, 0,HorizontalInput ) * speed * Time.deltaTime);

        if (HorizontalInput != 0 && Input.GetKeyDown(KeyCode.LeftShift))
        {
            Vector3 DashDirection = new Vector3(HorizontalInput, 0, 0).normalized;
            Rigidbody.AddForce(DashDirection * DashForce, ForceMode.Impulse);
            Rigidbody.linearVelocity = Vector3.zero;
            Debug.Log("Dash 💨");
            Rigidbody.linearVelocity = new Vector3(Rigidbody.linearVelocity.x * 0.9f, Rigidbody.linearVelocity.y, Rigidbody.linearVelocity.z * 0.9f);
        }
   }

   void FixedUpdate()
{
    if (Rigidbody.linearVelocity.magnitude > maxSpeed)
    {
        Rigidbody.linearVelocity = Rigidbody.linearVelocity.normalized * maxSpeed;
    }

    // Appliquer un freinage lorsque l'input horizontal est nul
    if (Mathf.Abs(Input.GetAxis("Horizontal")) < 0.1f)
    {
        Rigidbody.linearVelocity = new Vector3(Rigidbody.linearVelocity.x * 0.9f, Rigidbody.linearVelocity.y, Rigidbody.linearVelocity.z * 0.9f);
    }
}

}

