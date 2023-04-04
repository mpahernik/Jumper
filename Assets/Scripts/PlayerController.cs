using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed;
    public float jumppower;
    private Rigidbody2D rb;
    private bool facingright = true;
    private bool isgrounded;
    public Transform groundcheck;
    public float checkradius;
    public LayerMask whatisground;
    private int extrajumps;
    public GameObject snowball;
    public Transform shotposition;
    public KeyCode left;
    public KeyCode right;
    public KeyCode jump;
    public KeyCode shoot;
    static public int blueammo;
    static public int greenammo;
    float greenshottimer;
    float blueshottimer;
    void Start()
    {
        blueammo = 10;
        greenammo = 10;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        isgrounded = Physics2D.OverlapCircle(groundcheck.position, checkradius, whatisground);

        if (Input.GetKey(left))
        {
            rb.velocity = new Vector2(-speed, rb.velocity.y);
        }else if (Input.GetKey(right))
        {
            rb.velocity = new Vector2(speed, rb.velocity.y);
        }
        else
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }




        if (facingright == false && Input.GetKey(right))
        {
            Flip();
        }
        else if (facingright == true && Input.GetKey(left))
        {
            Flip();
        }
    }
    private void Update()
    {
        blueshottimer += Time.deltaTime;
        greenshottimer += Time.deltaTime;
        
        if (isgrounded == true)
        {
            extrajumps = 1;
            if (Input.GetKeyDown(jump))
            {
                rb.velocity = Vector2.up * jumppower;
            }
        }
        else if (Input.GetKeyDown(jump) && extrajumps > 0)
        {
            rb.velocity = Vector2.up * jumppower ;
            extrajumps--;
        }

        

            if (gameObject.tag == "BluePlayer")
            {
                if (Input.GetKeyDown(shoot) && blueammo > 0 && blueshottimer >0.5)
                {
                    blueammo--;
                    GameObject ballclone = (GameObject)Instantiate(snowball, shotposition.position, shotposition.rotation);
                    ballclone.transform.localScale = transform.localScale;
                blueshottimer = 0;
                }
            }
            if (gameObject.tag == "GreenPlayer")
            {
                if (Input.GetKeyDown(shoot) && greenammo > 0 && greenshottimer >0.5)
                {
                    greenammo--;
                    GameObject ballclone = (GameObject)Instantiate(snowball, shotposition.position, shotposition.rotation);
                    ballclone.transform.localScale = transform.localScale;
                greenshottimer = 0;
                }
            }
    }

    void Flip()
    {
        facingright = !facingright;
        Vector3 scaler = transform.localScale;
        scaler.x *= -1;
        transform.localScale = scaler;
    }
}
