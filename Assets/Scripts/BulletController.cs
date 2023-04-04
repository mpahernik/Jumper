using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    public GameObject effect;
    int getammo = PlayerController.blueammo;
    int getamo = PlayerController.greenammo;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();   
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(speed * transform.localScale.x, 0); 
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "BluePlayer" && getammo < 10)
        {
            PlayerController.blueammo += 1;
            Debug.Log("green ammo" + getammo);

        }
        if (other.gameObject.tag == "GreenPlayer" && getamo <10)
        {
            PlayerController.greenammo += 1;

        }
        Instantiate(effect, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
