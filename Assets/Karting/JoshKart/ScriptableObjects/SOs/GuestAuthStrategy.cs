using System;
using System.Threading.Tasks;
using UnityEngine;
using Unity.Services.Core;
using Unity.Services.Authentication;

[CreateAssetMenu(fileName = "GuestAuth", menuName = "JoshKart/Authentication/GuestAuth")]
public class GuestAuthStrategy : AuthStrategy {
    private void OnValidate() {
        AuthName = "Login as Guest";
    }

    public override async void Initialize(Action<bool> onInitialized) {
        await this._InitializeAsync(onInitialized);
    }

    private async Task _InitializeAsync(Action<bool> onInitialized) {
        await UnityServices.InitializeAsync();

        onInitialized?.Invoke(UnityServices.State == ServicesInitializationState.Initialized);
    }

    public override async void SignIn(Action<bool> onComplete) {
        await this._SignIn(onComplete);
    }

    private async Task _SignIn(Action<bool> onComplete) {
        try {
            await AuthenticationService.Instance.SignInAnonymouslyAsync();

            onComplete?.Invoke(AuthenticationService.Instance.IsSignedIn);

            PlayerID = AuthenticationService.Instance.PlayerId;
            AccessToken = AuthenticationService.Instance.AccessToken;
        } catch {
            onComplete?.Invoke(false);
        }


    }

    public override void SignOut() {
        throw new NotImplementedException();
    }
}
