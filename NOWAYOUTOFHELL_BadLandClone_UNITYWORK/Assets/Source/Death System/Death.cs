using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    [SerializeField] GameObject deathpanel;
    public void Update()
    {
        if (Time.timeScale == 0f)
        {
            deathpanel.SetActive(true);
        }
        else
        {
            deathpanel.SetActive(false);
        }
    }
}
