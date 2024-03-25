using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GooglePlayGamesAuth", menuName = "JoshKart/Authentication/GooglePlayGamesAuth")]
public class GPGAuthStrategy : AuthStrategy {
    private void OnValidate() {
        AuthName = "Google Play Games";
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
