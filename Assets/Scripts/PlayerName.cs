using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerName : MonoBehaviour
{

    public Fungus.Flowchart myFlowchart;
    public InputField playerName;

    public void SetPlayerName() {
        myFlowchart.SetStringVariable("Name", playerName.GetComponent<InputField>().text);
    }
}
