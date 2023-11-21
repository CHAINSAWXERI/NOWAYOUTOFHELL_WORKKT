using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] TMP_Text Text;
    void Update()
    {
        Text.text = "Score: " + SpawnLevel._level;
    }
}
