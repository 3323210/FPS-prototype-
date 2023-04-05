using System.Collections;
using System;
using UnityEngine;
using UnityEngine.Events;

public static class InvokeMetod
{
    public static Coroutine InvokeTime(this MonoBehaviour mono,Action action, float delay)
    {
       return mono.StartCoroutine(InvokeTimeteAction(action, delay));
    }
    private static IEnumerator InvokeTimeteAction(Action action,float timeInvoke)
    {
        yield return new WaitForSecondsRealtime(timeInvoke);
        action?.Invoke();
        yield break;
    }
}



