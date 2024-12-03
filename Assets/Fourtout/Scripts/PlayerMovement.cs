//made by NepNath 
//Creation Date: 03/12/2024
//last edited: 03/12/2024

//this script has been made for keyboard input, which mean they have not been tested with a controller.
//another script shall be made for controller input.

using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEditor.Callbacks;
using UnityEngine;

public class PlayerKeyboardMovement : MonoBehaviour
{

    [Header("Player Movement details")]
    public float speed = 10f;
    public float JumpForce = 10;
    public Rigidbody Rigidbody;

    private bool isGrounded;


    void Start()
    {
        
    }

    void Update()
    {
        float HorizontalInput = Input.GetAxis("Horizontal");
        float VerticalInput = Input.GetAxis("Vertical");
        
        transform.Translate(new Vector3(VerticalInput, 0,HorizontalInput ) * speed * Time.deltaTime);

        
   }
    // outsite void update
}


