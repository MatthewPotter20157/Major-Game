using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject[] trees;
    public float treeLeftBound;
    public float treeRightBound;
    public float treeUpBound;
    public float treeDownBound;
    public float treeNumber;
    public float treeSpawnX;
    public float treeSpawnY;
    // Click the "Instantiate!" button and a new `prefab` will be instantiated
    // somewhere within -10.0 and 10.0 (inclusive) on the x-z plane
    void Start()
    {
        for(int i = 0; i < treeNumber; i++)
        {
            int treeIndex = Random.Range(0, trees.Length);
            Vector3 treeSpawn = new Vector3(Random.Range(treeUpBound, treeDownBound), treeSpawnY, Random.Range(treeLeftBound, treeRightBound));
            Instantiate(trees[treeIndex], treeSpawn, trees[treeIndex].transform.rotation, GameObject.Find("TREES").transform);
        }
    }
}