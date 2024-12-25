using UnityEngine;

public class CollectableObjcets : MonoBehaviour,IRaycast
{
    Rigidbody rb;
    BoxCollider mc;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        mc = rb.GetComponent<BoxCollider>();
    }
    public void HitRayCast(Transform targetTransform,GameObject parent)
    {
        transform.parent = parent.transform;
        rb.isKinematic = true;
        mc.enabled = false;
        transform.position = targetTransform.position;
        /*transform.position = Vector3.Lerp(transform.position, targetTransform.position, 0.2f);
        if ((transform.position - targetTransform.position).magnitude < 0.2f)
        {
            transform.position = targetTransform.position;
        }*/
    }
}
