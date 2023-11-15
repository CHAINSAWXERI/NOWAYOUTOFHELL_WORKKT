using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyedObject : MonoBehaviour
{
    [SerializeField] GameObject[] GO = new GameObject[7];
    [SerializeField] Collider2D collider;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            for (int i = 0; i < GO.Length; i++)
            {
                GO[i].GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                GO[i].GetComponent<Rigidbody2D>().gravityScale= 0.5f;
                GO[i].GetComponent<Rigidbody2D>().mass = 0.3f;
                collider.isTrigger = true;
            }
        }
    }
}
