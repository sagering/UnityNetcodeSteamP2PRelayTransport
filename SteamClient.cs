using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteamClient : MonoBehaviour
{
    /// <summary>
    /// The steam app id. The default value of 480 is a public app id for development.
    /// </summary>
    public uint steamAppId = 480;

    void Start()
    {
        Steamworks.SteamClient.Init(steamAppId);
    }

    void OnApplicationExit()
    {
        Steamworks.SteamClient.Shutdown();
    }

    void Update()
    {
        Steamworks.SteamClient.RunCallbacks();
    }
}
