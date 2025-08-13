using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public Vector3 positionDelta = new Vector3(0, -2f, 0);
    public float speed = 5f;
    public float waitTime = 3f;

    private Vector3 closedPosition;
    private Vector3 openPosition;

    bool isOpen = false;
    float startTime = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        closedPosition = transform.position;
        openPosition = transform.position + positionDelta;
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isOpen)
        {


            if (Time.time > startTime + waitTime)
            {
                transform.position = Vector3.MoveTowards(transform.position, openPosition, speed * Time.deltaTime);
            }
            if (Vector3.Distance(transform.position, openPosition) < 0.1f)
            {

                isOpen = true;
                startTime = Time.time;
            }
        }
        else {

            if (Time.time > startTime + waitTime)
            {
                transform.position = Vector3.MoveTowards(transform.position, closedPosition, speed * Time.deltaTime);
            }
            if (Vector3.Distance(transform.position, closedPosition) < 0.1f)
            {

                isOpen = false;
                startTime = Time.time;
            }
        }
    }
        
    }

