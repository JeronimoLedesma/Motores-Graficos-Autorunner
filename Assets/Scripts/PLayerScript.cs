using UnityEngine;

public class PLayerScript : MonoBehaviour
{
    [SerializeField] float lane1;
    [SerializeField] float lane2;
    [SerializeField] float lane3;
    [SerializeField] float jumpForce;
    public GameObject self;
    Vector3 pos;
    Rigidbody rb;
    bool canJump;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       pos = self.transform.position;
       rb = GetComponent<Rigidbody>();
       canJump = true;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.A) && pos.x != lane1)
        {
            if (pos.x == lane2)
            {
                pos.x = lane1;
                self.transform.position = pos;
            }
            else
            {
                pos.x = lane2;
                self.transform.position = pos;
            }
        }

        if (Input.GetKeyDown(KeyCode.D) && pos.x != lane3)
        {
            if (pos.x == lane2)
            {
                pos.x = lane3;
                self.transform.position = pos;
            }
            else
            {
                pos.x = lane2;
                self.transform.position = pos;
            }
        }

        if (Input.GetKeyDown(KeyCode.Space) && canJump)
        {
            rb.AddForce(0f, jumpForce, 0f, ForceMode.Impulse);
            canJump = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            //lose
            Debug.Log("Hit an obstacle");
        }
        if (collision.gameObject.CompareTag("Floor"))
        {
            canJump = true;
            Debug.Log("HitFloor");
        }
    }
}
