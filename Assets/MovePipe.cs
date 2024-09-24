using UnityEngine;

public class MovePipe : MonoBehaviour
{
    public float velocity = 0f;
    public float removeWhenx = 0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(velocity > 0) {
        // Move the object to the right
        transform.Translate(velocity * Time.deltaTime * Vector3.left);
        }
        if(transform.position.x < removeWhenx) {
            Destroy(gameObject);
        }
    }
}
