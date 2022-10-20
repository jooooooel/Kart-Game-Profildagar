using KartGame.KartSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    public ArcadeKart playerKart;

    [SerializeField]
    public List<Transform> levelCheckpoints;
    [SerializeField]
    public List<Transform> finishLine;

    public float distanceToNextCheckpoint;
    public float distanceToGoal;
    public float totalDistance;
    public Vector3 CheckpointB;
    public float CX;
    public float CY;
    public float CZ;


    void Start()
    {
        CheckpointB = levelCheckpoints[0].transform.position;
        if (!playerKart)
        {
             playerKart = FindObjectOfType<ArcadeKart>();
            
        }
        for (int i = 0; i < 28; i++)
        {
         
            distanceToGoal = distanceToGoal + Mathf.Sqrt(Mathf.Pow(levelCheckpoints[i+1].transform.position.x - levelCheckpoints[i].transform.position.x, 2) + Mathf.Pow(levelCheckpoints[i+1].transform.position.y - levelCheckpoints[i].transform.position.y, 2) + Mathf.Pow(levelCheckpoints[i+1].transform.position.z - levelCheckpoints[i].transform.position.z, 2));
        }
    }

    public void Update()
    {
        CX = Mathf.Pow(CheckpointB.x - playerKart.transform.position.x, 2);
        CY = Mathf.Pow(CheckpointB.y - playerKart.transform.position.y, 2);
        CZ = Mathf.Pow(CheckpointB.z - playerKart.transform.position.z, 2);

        CheckpointChecker();
        
    }
    public void CheckpointChecker()
    {
        distanceToNextCheckpoint = Mathf.Sqrt((CX) + (CY) + (CZ));
    }

    public void GoalDistance()
    {

    }

}
