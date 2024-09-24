using UnityEngine;

public class CreatePipes : MonoBehaviour
{
    public GameObject pipe;
    public float spawnInterval = 2f;
    public float pipeSpeed = 5f;
    public float maxDisplacement = 5f;
    public float pipeRemoveX=-100f;
    private float timer = 0f;
    // Start is called before the first frame update
    void Start()
    {
        spawnNewPipe();
    }

    // Update is called once per frame
    void Update()
    {
        // Increment the timer
        timer += Time.deltaTime;

        // Check if it's time to spawn a new object
        if (timer >= spawnInterval)
        {
            spawnNewPipe();
        }
    }

    void spawnNewPipe() {
        // Reset the timer
            timer = 0f;

            // Spawn a new object at the spawn point
            float positionY = transform.position.y + Random.Range(-maxDisplacement, maxDisplacement);
            Vector3 pipePosition = new(transform.position.x,positionY , transform.position.z);
            GameObject newPipe = Instantiate(pipe, pipePosition, transform.rotation);

            if (newPipe.TryGetComponent<MovePipe>(out var movePipe))
            {
                // Set the speed pipe
                movePipe.velocity = pipeSpeed;
                movePipe.removeWhenx = pipeRemoveX;
            }
    }
}
