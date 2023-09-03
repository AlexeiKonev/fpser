using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeHelper : MonoBehaviour
{
    [SerializeField] private float AppleSpawnTime = 3f;
    [SerializeField] private Transform AppleSpawnPoint ;
    void Start()
    {
        InvokeRepeating("SpawnApple", 0, AppleSpawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void SpawnApple()
    {
        Debug.Log("spawn");
    }
}
