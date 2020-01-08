using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class CoinEvent : MonoBehaviour
{
    public ParticleSystem coinSpark;
    public Health health;



    public void OnTriggerEnter2D(Collider2D col)
    {

        if (col.tag == "Player")
        {
            Instantiate(coinSpark, this.transform.position, Quaternion.identity);
            //Debug.Log("This is triggering on player");
            ScoreText.scoreValue += 10;
            FindObjectOfType<AudioManager>().Play("Bell");
            Destroy(gameObject);
            Health.health += 2;
    
        }
        else
        {
            if (Health.health <= 0)
            {
                FindObjectOfType<GameManager>().EndGame();
            }
            FindObjectOfType<AudioManager>().Play("Drop");
            Destroy(gameObject);
            Health.health -= 20;
        }
         
    }

}
