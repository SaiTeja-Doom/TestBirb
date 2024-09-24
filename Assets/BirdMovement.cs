using UnityEngine;

public class BirdMovement : MonoBehaviour
{
    private Rigidbody2D rigidBody;
    public float jumpPower = 1f;

    private bool checkGameOver = false;

    public float maxVelocity = 20f;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        checkGameOver = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(rigidBody && checkGameOver){
            float maxy =GetComponent<SpriteRenderer>().bounds.max.y;
            float miny =GetComponent<SpriteRenderer>().bounds.min.y;
            if(miny>7 ||  maxy<-7){
                GameManager gameManager = FindObjectOfType<GameManager>();
                if(gameManager){
                    checkGameOver = false;
                    gameManager.GameOver();
                }
            }

        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidBody.AddForce(Vector3.up * jumpPower, ForceMode2D.Impulse);
        }
        
        if(rigidBody.velocity.y > 0f) {
            rigidBody.velocity = Vector2.ClampMagnitude(rigidBody.velocity,maxVelocity);
        }
    }
}
