using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{

    private GameController _gameController;

    void Awake()
    {
        _gameController = FindObjectOfType<GameController>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            _gameController.ScoreUp();
        }
    }
}
