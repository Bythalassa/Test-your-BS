using UnityEngine;

public class w3CameraFollow : MonoBehaviour
{
    private float Speed = 6;
    public GameObject player;

    private float radiusMovement = 1.7f;

    void Update()
    {
        FollowTarget(player);
    }

    public void FollowTarget(GameObject Target)
    {
        Vector3 targetPos = Target.transform.position;
        Vector3 myPos = transform.position;

        if (Vector3.Distance(targetPos, myPos) > radiusMovement)
        {
            Vector3 direction = (targetPos - myPos).normalized;
            transform.position += direction * Speed * Time.deltaTime;
        }
    }
}
