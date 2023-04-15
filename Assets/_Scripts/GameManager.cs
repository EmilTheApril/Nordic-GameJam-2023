using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] private CounterScript counterScript;
    private float time = 10;
    private GameObject player;

    [SerializeField] private int playersNeededToStart;
    private int playerCount;
    private bool gameStarted;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else Destroy(gameObject);
    }

    private void Start()
    {
        
    }

    private void Update()
    {
        if (gameStarted)
        {
            counterScript.SetText(time);
            time -= Time.deltaTime;
        }

        StartGame();

        GameEnd();
    }

    public void TagPlayer(GameObject player)
    {
        player.GetComponent<PlayerTimer>().SetGameManagerTime();
        player.GetComponent<PlayerMovement>().SetIsMonster();
    }

    public void GameEnd()
    {
        if (player != null && time <= 0)
        {
            counterScript.SetText($"{player.name} lost");
        }
    }

    public void SetTime(float time, GameObject player)
    {
        if (this.player != null)
        {
            player.GetComponent<PlayerTimer>().SetTime(this.time);
        }

        this.time = time;
        this.player = player;
    }

    public void StartGame()
    {
        GameObject[] players = GameObject.FindGameObjectsWithTag("Player");

        if (!gameStarted)
        {
            foreach (GameObject player in players)
            {
                player.GetComponent<PlayerMovement>().SendDisableAttackCommand();
            }
        }

        if (playerCount < playersNeededToStart && !gameStarted)
        {
            playerCount = GameObject.FindGameObjectsWithTag("Player").Length;
            counterScript.SetText($"Players needed to start {playerCount}/{playersNeededToStart}");
            return;
        }

        if (playerCount >= playersNeededToStart && !gameStarted && time >= 0)
        {
            time -= Time.deltaTime;
            counterScript.SetText($"Starting in {time.ToString("0")}...");
            return;
        }

        if (!gameStarted)
        {
            Debug.Log("Ups");
            gameStarted = true;
            int rnd = Random.Range(0, players.Length);

            players[rnd].GetComponent<PlayerTimer>().SetGameManagerTime();
            players[rnd].GetComponent<PlayerMovement>().SetIsMonster();
        }
    }
}
