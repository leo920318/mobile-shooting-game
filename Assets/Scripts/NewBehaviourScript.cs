using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Transform player;
    public Vector3 a;
    public Vector3 b;
    public Vector3 c;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

       float dist = Vector3.Distance(transform.position, player.position);
        Debug.Log(dist);
        if(dist < 6)
        {
            transform.localScale = new Vector3(2, 2, 2);

        }
        else
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        
    }
}
