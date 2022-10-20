using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerShowPos : GameManager
{
    public int i = 0;
    public bool looper = false;
    // Start is called before the first frame update
    void Start()
    {
        
        

        
    }


    // Update is called once per frame
    void Update()
    {
        while (looper==true)
        {
            distanceToGoal = distanceToGoal - distanceToNextCheckpoint;
            CheckpointB = levelCheckpoints[i].transform.position;

                looper = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("CheckB"))
        {
            looper = true;
            
        }
    }
}
