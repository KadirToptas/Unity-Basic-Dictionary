using System;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionController : MonoBehaviour
{
    public Dictionary<string, ParticleSystem> explosionList = new Dictionary<string, ParticleSystem>();


    [SerializeField] private ParticleSystem redExplosion;
    
    [SerializeField] private ParticleSystem blueExplosion;

    [SerializeField] private ParticleSystem greenExplosion;


    private void Start()
    {
        AddToList();
    }


    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            explosionList[ExplosionTag.RED].Play();
        }
    }

    private void AddToList()
    {
        explosionList.Add(ExplosionTag.RED, redExplosion);
        explosionList.Add(ExplosionTag.BLUE, blueExplosion);
        explosionList.Add(ExplosionTag.GREEN, greenExplosion);
    }
}


struct ExplosionTag
{
    public const string RED = "Red";
    public const string BLUE = "Blue";
    public const string GREEN = "Green";

}
