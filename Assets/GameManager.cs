using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManeger : MonoBehaviour
{
    public Transform PlayerPadle;
    public Transform EnemyPadle;

    public int playerScore = 0;
    public int enemyScore = 0;
    public TextMeshProUGUI textPointsPlayer;
    public TextMeshProUGUI textPointsEnemy;

    public BallControler ballController;

    public EnemyPaddleControl EnemyPaddle;

    public GameObject screenEndGame;

    public int winPoints;



    public TextMeshProUGUI textEndGame;

    // Start is called before the first frame update
    void Start()
    {
        ResetGame();
    }

    public void ScorePlayer()
    {
        playerScore++;
        textPointsPlayer.text = playerScore.ToString();
        CheckWin();
    }

    public void ScoreEnemy()
    {
        enemyScore++;
        textPointsEnemy.text = enemyScore.ToString();
        CheckWin();
    }

    // Update is called once per frame
    public void ResetGame()
    {
        PlayerPadle.position = new Vector3(7, 0, 0);
        EnemyPadle.position = new Vector3(-7, 0, 0);

        ballController.ResetBall();

        playerScore = 0;
        enemyScore = 0;
        textPointsEnemy.text = enemyScore.ToString();
        textPointsPlayer.text = playerScore.ToString();
    }

    public void CheckWin()
    {
        if (enemyScore >= winPoints || playerScore >= winPoints)
        {
            //ResetGame();
            EndGame();
        }
    }
    public void EndGame()
    {
        screenEndGame.SetActive(true);
        string winner = saveController.Instance.GetName(playerScore > enemyScore);
        textEndGame.text = "Vitória " + winner;
        saveController.Instance.SaveWinner(winner);
        Invoke("LoadMenu", 2f);
    }
    private void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
