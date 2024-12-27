using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InputName : MonoBehaviour
{
    public bool isPlayer;
    public TMP_InputField inputField;
    private void Start()
    {
        inputField.onValueChanged.AddListener(UpdateName);
    }
    public void UpdateName(string name)
    {
        if (isPlayer)
            saveController.Instance.namePlayer = name;
        else
            saveController.Instance.nameEnemy = name;
    }
}