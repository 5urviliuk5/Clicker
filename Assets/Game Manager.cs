using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static int clicks;
    public TMP_Text clicksText;

    private void Update()
    {
        clicksText.text = clicks.ToString();
    }
}
