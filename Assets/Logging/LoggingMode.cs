using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoggingMode : MonoBehaviour
{
    [SerializeField] bool _productMode;

    private void Update()
    {
        if (_productMode)
            ChangeState();
    }

    /// <summary>
    /// Oyun Product Mode olarak ayarlandiginda manuel olarak ayarlanan log lar gonderilmez.
    /// </summary>
    void ChangeState()
    {
        foreach (Transform child in transform)
        {
            child.gameObject.GetComponent<Logger>().showLogs = false;
        }
    }
}
