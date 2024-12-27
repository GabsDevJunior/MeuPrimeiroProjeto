using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class saveController : MonoBehaviour
{
    public Color colorPlayer = Color.white;
    public Color colorEnemy = Color.white;

    public string namePlayer;
    public string nameEnemy;

    private static saveController iinstance;

    public string SaveWinnerKey = "SavedWinner";
    // Propriedade est�tica para acessar a inst�ncia
    public static saveController Instance
    {
        get
        {
            if (iinstance == null)
            {
                // Procure a inst�ncia na cena
                iinstance = FindObjectOfType<saveController>();




                // Se n�o encontrar, crie uma nova inst�ncia
                if (iinstance == null)
                {
                    GameObject singletonObject = new GameObject(typeof(saveController).Name);
                    iinstance = singletonObject.AddComponent<saveController>();
                }
            }
            return iinstance;
        }

    }

    private void Awake()
    {
        // Garanta que apenas uma inst�ncia do Singleton exista
        if (iinstance != null && iinstance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        // Mantenha o Singleton vivo entre as cenas
        DontDestroyOnLoad(this.gameObject);
    }
    public string GetName(bool isPlayer)
    {
        return isPlayer ? namePlayer : nameEnemy;
    }
    public void Reset()
    {
        nameEnemy = "";
        namePlayer = "";
        colorEnemy = Color.white;
        colorPlayer = Color.white;
    }
    public void SaveWinner(string winner)
    {
        PlayerPrefs.SetString(SaveWinnerKey, winner);
    }

    public string GetLastWinner()
    {
        return PlayerPrefs.GetString(SaveWinnerKey);
    }
    public void ClearSave()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
