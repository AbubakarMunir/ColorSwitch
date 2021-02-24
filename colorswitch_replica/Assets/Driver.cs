using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] GameObject[] Cs;
    [SerializeField] Transform bpos;
    [SerializeField] GameObject cchanger;
    [SerializeField] GameObject sliderref;
    [SerializeField] GameObject acircle;
    [SerializeField] GameObject achanger;
    [SerializeField] Transform arot;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void spawner()
    {
        int index = Random.Range(0, 5);
        Destroy(acircle);
        //makes  a copy of circle passed
        //Instantiate(Cs[index]);
        //gets ref of that copy of circle
        acircle = Instantiate(Cs[index]);
        acircle.transform.position = new Vector3((float)(-1.75), bpos.position.y + 6, 0);
        achanger = Instantiate(cchanger);
        achanger.transform.position = new Vector3(0, bpos.position.y + 12, 0);
        sliderref.transform.position = new Vector3(0, bpos.position.y, 0);
    }


    }
