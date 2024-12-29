using UnityEngine;

public class GameManager : MonoBehaviour
{
    private void Awake()
    {
        LockCursor();
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void LockCursor()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void UnlockCursor()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
    }
}
