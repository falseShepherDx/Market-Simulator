using UnityEngine;

public class CollectableObjcets : MonoBehaviour,ICollectable
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
        CollectChanges(parent);
        transform.position = targetTransform.position;
        /*transform.position = Vector3.Lerp(transform.position, targetTransform.position, 0.2f);
        if ((transform.position - targetTransform.position).magnitude < 0.2f)
        {
            transform.position = targetTransform.position;
        }*/
    }

    public void CollectChanges(GameObject parent)
    {
        rb.isKinematic = !rb.isKinematic;
        mc.enabled = !mc.enabled;
        if(rb.isKinematic)
        {
            transform.parent = parent.transform;
        }
        else
        {
            transform.parent = null;
        }
    }
}
