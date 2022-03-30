using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterClass : MonoBehaviour
{
    [SerializeField]
    GameManager GM;

    private void OnTriggerEnter(Collider other)
    {
        GM.EnterClass();
    }
}
