using UnityEngine;

[RequireComponent (typeof(Rigidbody))]
public class CharacterController : MonoBehaviour
{
    Rigidbody rb;
    float horizontal,vertical;

    //Speed values
    [SerializeField] float currentSpeed;
    [SerializeField] float walkSpeed, runSpeed;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        
    }
    void FixedUpdate()
    {
        Movement();
    }

    private void Update()
    {
        SpeedHandler();
    }

    void Movement()
    {
        horizontal = Input.GetAxis("Horizontal") * currentSpeed;
        vertical = Input.GetAxis("Vertical")* currentSpeed;

        Vector3 movement = (transform.forward * vertical + transform.right * horizontal) ;

        rb.linearVelocity = movement;
    }

    void SpeedHandler()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            currentSpeed = Mathf.Lerp(currentSpeed,runSpeed,0.15f);
            if (currentSpeed > runSpeed - 0.1f)
            {
                currentSpeed = runSpeed;
            }
        }
        else
        {
            currentSpeed = Mathf.Lerp(currentSpeed, walkSpeed, 0.15f);
            if (currentSpeed -0.1f < walkSpeed)
            {
                currentSpeed = walkSpeed;
            }
        }
    }
}
