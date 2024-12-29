using UnityEngine;
using Unity.Cinemachine;


[RequireComponent (typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] GameObject fpsCamera;

    CinemachinePanTilt panTilt;
    float horizontal,vertical;

    //Speed values
    [SerializeField] float currentSpeed;
    [SerializeField] float walkSpeed, runSpeed;

    public bool rbOn;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        panTilt = fpsCamera.GetComponent<CinemachinePanTilt>();
    }
    void FixedUpdate()
    {
        RigidBodyMovement();
    }

    private void Update()
    {    
        SpeedHandler();
        DirectionController();  
    }
    void RigidBodyMovement()
    {
        horizontal = Input.GetAxisRaw("Horizontal") ;
        vertical = Input.GetAxisRaw("Vertical");

        Vector3 movement = (transform.forward * vertical + transform.right * horizontal).normalized;
        rb.linearVelocity = movement * currentSpeed;

    }

    void DirectionController()
    {
        transform.rotation = Quaternion.Euler(0,panTilt.PanAxis.Value,0);
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
