using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Remover : MonoBehaviour {
    void OnTriggerEnter2D(Collider2D other)
    {
        other.gameObject.SetActive(false);
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        other.gameObject.SetActive(false);
    }
}
