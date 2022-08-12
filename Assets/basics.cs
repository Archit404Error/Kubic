using UnityEngine;

public class basics : MonoBehaviour
{

    public Rigidbody playerMove;
    public float forwardForce = 2000f;
    public float jumpForce = 1000f;

    [System.Obsolete]
    void createObstacle() {
        var player = GameObject.Find("Player");

        for (int i = 0; i < 5; i++)
        {
            var obstacle = GameObject.CreatePrimitive(PrimitiveType.Cube);
            obstacle.name = "obstacle";

            obstacle.GetComponent<Renderer>().material.color = Color.black;
            
            Vector3 newPos = new Vector3(Random.Range(-15.0f, 15.0f), 1, player.GetComponent<Transform>().position.z + 50);
            obstacle.GetComponent<Transform>().position = newPos;
            obstacle.GetComponent<Transform>().localScale = new Vector3(Random.RandomRange(1.0f,1.5f), 1, Random.RandomRange(1.0f, 2.0f));
        }
    }

    void Start(){
        InvokeRepeating("createObstacle", 0.0f, 0.5f);    
    }

    // Update is called once per frame
    void FixedUpdate() {
        playerMove.AddForce(0, 0, forwardForce * Time.deltaTime);
        if (Input.GetKey("a"))
        {
            playerMove.AddForce(-forwardForce * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey("d"))
        {
            playerMove.AddForce(forwardForce * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey("r"))
        {
            FindObjectOfType<GameManager>().die();
        }
        var player = GameObject.Find("Player");
        if (player.GetComponent<Transform>().position.y <= -2) {
            FindObjectOfType<GameManager>().die();
        }
    }
}
