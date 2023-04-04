using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{

    public float movespeed;
    public float range;
    int direction= 1;
    float Initialpos;
    public GameObject goaleffect;

    public int pointstogiveblue;
    public int pointstogivegreen;
    public static int pointsblue;
    public static int pointsgreen;
    public AudioClip scoresound;
    private AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        pointsblue = 0;
        pointsgreen = 0;
        Initialpos = transform.position.y;
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        float movement = movespeed * direction * Time.deltaTime;
        float newmovement = transform.position.y + movement;
        if(Mathf.Abs(newmovement - Initialpos) > range)
        {
            direction *= -1;
        }
        else
        {
            transform.position += new Vector3(0, movement, 0);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
      if(other.gameObject.tag == "Ball")
        {
            Instantiate(goaleffect, transform.position, transform.rotation); 
            pointsblue += pointstogiveblue;
            pointsgreen += pointstogivegreen;
            source.PlayOneShot(scoresound);
        }
    }
}
