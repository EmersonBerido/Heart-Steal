using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    private float maxHeight = 0;
    private float minHeight = -4;
    public float speed = 1.5f;
    public bool moveUp = true;
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y == maxHeight)
        {
            moveUp = false;
        } else if (transform.position.y == minHeight)
        {
            moveUp = true;
        }

        


        if (moveUp)
        {
            //Debug.Log("Moving up");
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, maxHeight, transform.position.z), speed * Time.deltaTime);
        } 
        else if (!moveUp)
        {
            //Debug.Log("Moving down");
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, minHeight, transform.position.z), speed * Time.deltaTime);
        }
    }

}
