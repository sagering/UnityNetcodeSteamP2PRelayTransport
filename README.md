# UnityNetcodeSteamP2PRelayTransport
This is a sample implementation of the com.unity.netcode.gameobjects Transport interface for Steam's Steamworks peer to peer relay service.

# How to use this?

The implementation is based on the [Facepunch](https://github.com/Facepunch/Facepunch.Steamworks) library, a C# wrapper for [Steamworks](https://partner.steamgames.com/doc/home). Install Facepunch 2.3.2.

1. Add the SteamClient.cs and SteamP2PRelayTransport.cs to your Unity project.
1. Add the the SteamClient and SteamP2PRelayTransport Component to your Netcode for GameObjects NetworkManager.
1. Set the NetworkManager's Transport to SteamP2PRelayTransport Component you just added.
1. Enter a Steam app id (or use the default 480 for testing) on the SteamClient Component.
1. Enter a Steam id of the hosting side.

For testing, you will need two Steam clients running and logged in on two different Steam accounts and machines.
