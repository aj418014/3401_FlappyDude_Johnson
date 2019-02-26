using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerBehavior : MonoBehaviour
{
    public AudioSource birdDeath;
    public AudioSource wingFlap;
    public AudioSource pointSound;
    bool inputIsEnabled = true;
    int count = 0;
    public Rigidbody2D birdRB;
    public float jump = 3.0f;
    public GameObject gameOverCanvas;
    public Text scoreText; 
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, -35*Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.Space) && inputIsEnabled == true)
        {
            transform.Rotate(0, 0, 30);
            Debug.Log("Space");
            birdRB.velocity = new Vector2(birdRB.velocity.x, jump);
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            wingFlap.Play();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        inputIsEnabled = false;
        gameOverCanvas.SetActive(true);
        birdDeath.Play();
        Debug.Log("You Lose!!!!!!!");
        Debug.Log(count);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        count++;
        pointSound.Play();
        scoreText.text = "Score: " + count.ToString();
    }
}
