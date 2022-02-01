using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GridSpace : MonoBehaviour
{
    public Button button;
    public Text buttonText;
    
    private GameController gameController;

    public void SetSpace()
    {
        //buttonText.color = (buttonText.color == ("FF3636")) ? "FFFFFF" : "FF3636";
        
        buttonText.text = gameController.GetPlayerSide();
        button.interactable = false;
        gameController.EndTurn();
    }

    public void SetGameControllerReference(GameController controller)
    {
        gameController = controller;
    }

}
