using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "AppleAuth", menuName = "JoshKart/Authentication/AppleAuth")]
public class AppleAuthStrategy : AuthStrategy
{
    private void OnValidate() {
        
        AuthName = "Sign in with Apple";    
    }

    public override void Initialize(Action<bool> onInitialized) {
        throw new NotImplementedException();
    }

    public override void SignIn(Action<bool> onComplete) {
        throw new NotImplementedException();
    }

    public override void SignOut() {
        throw new NotImplementedException();
    }
}
