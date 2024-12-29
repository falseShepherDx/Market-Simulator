using Unity.VisualScripting;
using UnityEngine;

public class RayCaster : MonoBehaviour
{
    public KeyCode rayCastKey;
    [SerializeField] LayerMask targetLayer;
    Camera mainCam;

    [SerializeField] float range;
   

    private void Awake()
    {
        mainCam = GetComponent<Camera>();
    }
    void Update()
    {
        if (Input.GetKeyDown(rayCastKey))
        {
            Raycaster();
        }

    }

    void Raycaster()
    {
        Ray ray = mainCam.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0));
        RaycastHit hit; 
        if(Physics.Raycast(ray, out hit,range,targetLayer))
        {
           
            
        }
    }
}
