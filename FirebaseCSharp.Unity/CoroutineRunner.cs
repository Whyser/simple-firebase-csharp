using UnityEngine;
using System.Collections;

internal static class CoroutineRunner
{
    private static MonoBehaviour _instance = null;
    public static void StartCoroutine(IEnumerator routine)
    {
        if (_instance != null)
            _instance.StartCoroutine(routine);
        else
            (_instance = new GameObject("CoroutineRunner").AddComponent<MonoBehaviour>()).StartCoroutine(routine);
    }
}