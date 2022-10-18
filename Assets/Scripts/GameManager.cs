using KartGame.KartSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    ArcadeKart playerKart;

    [SerializeField]
    List<Transform> levelCheckpoints;

    void Start()
    {
        if(!playerKart)
        {
            playerKart = FindObjectOfType<ArcadeKart>();
        }
    }

    void Update()
    {
        
    }
}
