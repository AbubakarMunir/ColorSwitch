using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class BallHandler2 : MonoBehaviour
{
    public Rigidbody2D rb;
    public float force;
    public SpriteRenderer sr;
    public Color blue, yellow, pink, purple;
    int score = 0;
    string playercolor;
    public Driver d ;
    public Text textref;
    public static int scene = 0;
    // Start is called before the first frame update
    void Start()
    {
        textref.text = "SCORE: " + score.ToString();
        chooseRandomColor();
        rb.gravityScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.gravityScale = 1;
            push();
        }
    }
    void push()
    {
        rb.velocity = new Vector2(0, 1 * force);
    }


    void chooseRandomColor()
    {
        int index = Random.Range(0, 4);
        switch (index)
        {
            case 0:
                sr.color = blue;
                playercolor = "blue";
                break;
            case 1:
                sr.color = yellow;
                playercolor = "yellow";
                break;
            case 2:
                sr.color = pink;
                playercolor = "pink";
                break;
            case 3:
                sr.color = purple;
                playercolor = "purple";
                break;
        }
    }
        

        private void OnTriggerEnter2D(Collider2D collission)   //onject which hits this object(ball) is passed to this func
        {
            if (collission.tag == "colorchanger")
            {
                chooseRandomColor();
                if (score < 5)
                {
                    
                    score++;
                    
                    if (score == 5)
                    {
                        scene=2;
                        Destroy(collission.gameObject);
                        SceneManager.LoadScene(scene);
                        return;
                    }
                    d.spawner();
                    textref.text = "SCORE: " + score.ToString();
                    Destroy(collission.gameObject);
                return;
                }
                if (score > 2)
                {
                    d.spawner();
                    textref.text = "SCORE: " + score.ToString();
                    Destroy(collission.gameObject);
                    return;
                }
                



            }
            if (collission.tag == "star")
            {
                score++;
                textref.text = "SCORE: " + score.ToString();
                Destroy(collission.gameObject);
                return;
            }
            if (collission.tag == "slider")
            {
                push();
                return;
            }
            if (playercolor != collission.tag)
            {
                SceneManager.LoadScene(scene++);
            }

        }
    }



