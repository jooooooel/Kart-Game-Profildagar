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
    public float totalDistance;

    void Start()
    {
        if(!playerKart)
        {
             playerKart = FindObjectOfType<ArcadeKart>();
            
        }
    }

    public void Update()
    {
        CheckpointChecker();
    }
    public void CheckpointChecker()
    {
        for (int i = 0; i < i; i++)
        {
            
        }
        Vector3 CheckpointB = levelCheckpoints[0].transform.position;
        distanceToNextCheckpoint = Mathf.Sqrt(Mathf.Pow(CheckpointB.x - playerKart.transform.position.x, 2) + Mathf.Pow(CheckpointB.y - playerKart.transform.position.y, 2) + Mathf.Pow(CheckpointB.z - playerKart.transform.position.z, 2));
    }


}
