using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float Velocity;
    [SerializeField] float JumpForce;
    public bool OnGround;
    Rigidbody2D rb;
    float timer = 0;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(new Vector2(Velocity * Time.deltaTime, 0));
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(new Vector2(-Velocity * Time.deltaTime, 0));
        }
        if (Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.W))
        {
            timer = timer + Time.deltaTime;
            if (timer < 0.5f && OnGround)
            {
                rb.AddForce(new Vector2(0, JumpForce * Time.deltaTime));
            }
            else
            {
                OnGround = false;
                timer = 0;
            }
        }
        if (Input.GetKeyUp(KeyCode.Space) || Input.GetKeyUp(KeyCode.W))
        {
            OnGround = false;
            timer = 0;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "Ground")
        {
            OnGround = true;
        }
    }

   
}
