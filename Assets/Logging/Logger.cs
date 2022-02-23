using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("My Tools/Logging")]
public class Logger : MonoBehaviour
{
    [Header("Settings")]
    public bool showLogs;
    [SerializeField] string _prefix;
    [SerializeField] Color _prefixColor;

    string _hexColor;

    void OnValidate()
    {
        _hexColor = "#" + ColorUtility.ToHtmlStringRGB(_prefixColor);
    }

    public void Log(object message, UnityEngine.Object sender)
    {
        if (!showLogs) return;
        message = message + "-->" + sender.name;
        Debug.Log($"<color={_hexColor}>{_prefix}: {message}</color>", sender);
    }
}  
