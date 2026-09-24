using UnityEngine;

public class PeopleMove : MonoBehaviour
{
    public float speed = 1f;
    public Transform targetPos;
    private Vector3 startPosition;
    private Vector3 targetPosition;
    private bool movingToTarget = true;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        if (movingToTarget == true)
        {
            targetPosition = targetPos.position;
        }
        else
        {
            targetPosition = startPosition;
        }

        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        //once resident reach target position, go back to start position
        if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
        {
            if (movingToTarget == true)
            {
                movingToTarget = false;
            }
            else
            {
                movingToTarget = true;
            }
        }
    }
}
    