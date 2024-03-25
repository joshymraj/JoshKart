using System;
using UnityEngine;
using UnityEngine.UI;

public enum Platform {
    All,
    Android,
    Apple,
    Windows
}

public abstract class AuthStrategy : ScriptableObject
{
    public string PlayerID;
    public string AccessToken;
    public string AuthName;
    public Sprite Icon;
    public Platform TargetPlatform;
    public abstract void Initialize(Action<bool> onInitialized);
    public abstract void SignIn(Action<bool> onComplete);
    public abstract void SignOut();
}
