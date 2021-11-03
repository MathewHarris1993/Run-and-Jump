using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject fencePrefab;
    private Vector3 spawnPos = new Vector3(35, 0, 0);

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(fencePrefab, spawnPos, fencePrefab.transform.rotation);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
