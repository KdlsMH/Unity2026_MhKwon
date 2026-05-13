using UnityEngine;

public class TargetPosition : MonoBehaviour
{
    private void OnDrawGizmos()
    {
        Gizmos.color(red);
        Gizmos.DrawSphere(transform.position, 1f);
    }
}