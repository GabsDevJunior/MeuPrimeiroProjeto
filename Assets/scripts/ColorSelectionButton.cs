using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorSelectionButton : MonoBehaviour
{
    public Button uiButton;
    public Image paddleReference;

    public bool isColorPlayer = false;


  

    // Start is called before the first frame update
    public void OnButtonClick()
    {
        paddleReference.color = uiButton.colors.normalColor;

        if (isColorPlayer)
        {
            saveController.Instance.colorPlayer = paddleReference.color;
        }
        else
        {
            saveController.Instance.colorEnemy = paddleReference.color;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
