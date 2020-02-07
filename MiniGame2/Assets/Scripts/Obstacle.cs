using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public int ObstacleDamage = 1;
    public float Obstaclespeed;

    public GameObject effect;

    private void Update()
    {
        transform.Translate(Vector2.left * Obstaclespeed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player")) //collides wiht player
        {
            //player takes damage 
            Instantiate(effect, transform.position, Quaternion.identity);
            other.GetComponent<Player>().health -= ObstacleDamage;
            Debug.Log(other.GetComponent<Player>().health); //tells health
            Destroy(gameObject);
        }
    }
}
