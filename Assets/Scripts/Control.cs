using UnityEngine;

public class Control : MonoBehaviour
{
    private float distance = 5f;
    private Vector3 startPosition;

    private void Start()
    {
        startPosition = transform.position;
    }

    private void FixedUpdate()
    {
        if (Input.GetAxis("Fire1") > 0)
        {
            transform.position = new Vector3(
                transform.position.x + Input.GetAxis("Mouse X") * Time.deltaTime,
                transform.position.y + Input.GetAxis("Mouse Y") * Time.deltaTime,
                transform.position.z);
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, startPosition, distance);
        }
    }
}