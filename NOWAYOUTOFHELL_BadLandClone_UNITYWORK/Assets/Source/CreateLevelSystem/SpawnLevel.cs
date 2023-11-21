using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLevel : MonoBehaviour
{
    [SerializeField] GameObject[] blocks = new GameObject[15];
    [SerializeField] GameObject finish;
    public static int _level = 0;
    private int _formula = _level * 5 + 2;

    void Start()
    {
        float a = 20;

        for (int i = 0; i < _formula; i++)
        {
            int R = Random.Range(0, blocks.Length - 1);
            Instantiate(blocks[R], new Vector2(a, 0), Quaternion.identity);
            a += 20;
        }

        Instantiate(finish, new Vector2(a, 0), Quaternion.identity);
    }
}
