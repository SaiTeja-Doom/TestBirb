using UnityEngine;

public class BirdCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager gameManager = FindObjectOfType<GameManager>();
        if(gameManager){
            gameManager.GameOver();
        }
    }
}
