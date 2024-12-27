using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MainMenuController : MonoBehaviour
{
    public TextMeshProUGUI uiWinner;
    void Start()
    {
        saveController.Instance.Reset();
        string lastWinner = saveController.Instance.GetLastWinner();

        if (lastWinner != "")
            uiWinner.text = "Último vencedor: " + lastWinner;
        else
        {
            uiWinner.text = "";
        }
    }
}
