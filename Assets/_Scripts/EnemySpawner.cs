using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject enemy;
    [SerializeField] private GameObject[] enemies;
    [SerializeField] private int enemySpawnAmount;
    [SerializeField] private int enemyCount;
    [SerializeField] private float timeInbetweenSpawns;
    [SerializeField] private bool roomComplete;
    [SerializeField] private bool roomStarted;
    [SerializeField] private int enemiesAlive;
    [SerializeField] private GameObject[] doors;

    private void Awake()
    {
        OpenCloseDoors(false);
    }

    private void Update()
    {
        if (enemiesAlive <= 0 && roomStarted)
        {
            roomComplete = true;
            OpenCloseDoors(false);
        }
    }

    public void EnemyKilled()
    {
        enemiesAlive--;
    }

    public void OpenCloseDoors(bool state)
    {
        foreach (GameObject door in doors)
        {
            door.SetActive(state);
        }
    }

    public void StartRoom()
    {
        enemiesAlive = enemySpawnAmount;
        OpenCloseDoors(true);
        Invoke("SpawnEnemy", timeInbetweenSpawns);
        enemies = new GameObject[enemySpawnAmount];
    }

    public void SpawnEnemy()
    {
        if (enemyCount < enemySpawnAmount)
        {
            enemyCount++;
            GameObject ene = Instantiate(enemy, SpawnPos(), Quaternion.identity);
            ene.GetComponent<Health>().room = gameObject;
            enemies[enemyCount - 1] = ene;
            Invoke("SpawnEnemy", timeInbetweenSpawns);
        }
    }

    public Vector3 SpawnPos()
    {
        Vector3 pos = new Vector3(Random.Range(7, -8) + transform.position.x, 1.2f, Random.Range(7, -8) + transform.position.z);
        return pos;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (!roomComplete && !roomStarted)
            {
                roomStarted = true;
                StartRoom();
            }
        }
    }
}
