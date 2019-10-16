using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{

    public float spawnRange_x1 = 0.0f;
    public float spawnRange_z1 = 0.0f;
    public float spawnRange_x2 = 0.0f;
    public float spawnRange_z2 = 0.0f;
    public float spawnY = 0.5f;

    public int numberOfMonsters = 10;

    public GameObject monsterPrefab;

    public GameObject monsterParent;

    // Start is called before the first frame update
    void Start()
    {
        // spawn range of monsters at radom positions in a rectangle
        for (int i = 0; i < numberOfMonsters; i++) {
            float coordX = Random.Range(spawnRange_x1, spawnRange_x2);
            float coordZ = Random.Range(spawnRange_z1, spawnRange_z2);
            Instantiate(monsterPrefab, new Vector3(coordX, spawnY, coordZ), Quaternion.identity, monsterParent.transform);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
