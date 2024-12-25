using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    protected float SpeedMovement = 3.5f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Walk();
        Run();
        SneakingAround();
        if (Input.GetAxisRaw("Vertical") > 0 || Input.GetAxisRaw("Vertical") < -2) Jump();
    }

    void Walk()
    {
        rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), 0) * SpeedMovement;
    }

    void Run() { }

    void SneakingAround() {}

    void Jump()
    {
        rb.velocity = new Vector2(0, Input.GetAxisRaw("Vertical")) * SpeedMovement;
    }
}