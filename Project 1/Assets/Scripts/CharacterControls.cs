
using UnityEngine;

public class CharacterControls : MonoBehaviour
{
    public CharacterController controller;
    private Vector3 positionDirection;
    public float speed = 5f;
    public float gravity = -3f;
    public float jumpForce = 6f;
    void Start()
    {
        
    }
    void Update()
    {
        positionDirection.x = Input.GetAxis("Horizontal")*speed;
        positionDirection.z = Input.GetAxis("Vertical") * speed;
        if (Input.GetButtonDown("Jump") && controller.isGrounded)
        {
            positionDirection.y = jumpForce;
            
        }
        positionDirection.y += gravity;
        controller.Move(positionDirection*Time.deltaTime);
    }
}
