using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandler : MonoBehaviour
{
    private WallImage currentDisplay;
    void Start()
    {
        currentDisplay = GameObject.Find("Wall").GetComponent<WallImage>();

    }

   public void OnRightClick()
    {
        currentDisplay.CurrentWall = currentDisplay.CurrentWall + 1;

    }

    public void OnLeftClick()
    {
        currentDisplay.CurrentWall = currentDisplay.CurrentWall - 1;

    }


}
