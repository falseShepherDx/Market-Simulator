using UnityEngine;

public interface ICollectable
{
    public void HitRayCast(Transform transform,GameObject gameObject);
    public void CollectChanges(GameObject parent);
}
