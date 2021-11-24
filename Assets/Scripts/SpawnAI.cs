using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAI : MonoBehaviour
{
    [Tooltip("Prefab des ennemis")]
    public Transform prefabEnemy;
    [Tooltip("Point de spawn des ennemis")]
    public Transform spawnPoint;


    // Start is called before the first frame update
    void Start()
    {
        Transform enemy = SpawnEnemy();
        AddPichenette(enemy, enemy.forward * 5);
    }

    Transform SpawnEnemy()
    {
        Transform enemy = GameObject.Instantiate<Transform>(prefabEnemy);
        enemy.position = spawnPoint.position;
        enemy.rotation = spawnPoint.rotation;
        return enemy;
    }

    void AddPichenette(Transform enemy, Vector3 pichenette)
    {
        Rigidbody rb = enemy.GetComponent<Rigidbody>();
        rb.AddForce(pichenette, ForceMode.Impulse);

    }

    private float time = 0;
    private float timeMax = 3;
    // Update is called once per frame
    void Update()
    {
        time = time + Time.deltaTime;

        if (time >= timeMax)
        {
            Transform enemy = SpawnEnemy();
            AddPichenette(enemy, enemy.forward * 5);
            time = 0;
        }
    }
}