using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogTest : MonoBehaviour
{
    [SerializeField] Logger _logger;

    private void Update()
    {
        Log("some logs");
    }

    void Log(object message)
    {
        if (_logger)
            _logger.Log(message, this);
    }
}
