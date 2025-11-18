using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
/*
public class PortalTeleport : UdonSharpBehaviour
{
    public Transform receiver;

    private bool playerIsOverlapping;

    void Update()
    {
        if (!playerIsOverlapping)
            return;

        VRCPlayerApi localPlayer = Networking.LocalPlayer;
        if (localPlayer == null) return;

        Vector3 portalToPlayer = localPlayer.GetPosition() - transform.position;
        float dot = Vector3.Dot(transform.up, portalToPlayer);

        // When player crosses the plane of the portal
        if (dot < 0f)
        {
            float rotationDiff = -Quaternion.Angle(transform.rotation, receiver.rotation);
            rotationDiff += 180f;

            // New rotation
            Quaternion newRotation = Quaternion.Euler(
                0f,
                localPlayer.GetRotation().eulerAngles.y + rotationDiff,
                0f
            );

            // Keep player relative offset
            Vector3 positionOffset = Quaternion.Euler(0f, rotationDiff, 0f) * portalToPlayer;

            // Teleport the player
            localPlayer.TeleportTo(
                receiver.position + positionOffset,
                newRotation
            );

            playerIsOverlapping = false;
        }
    }

    public override void OnPlayerTriggerEnter(VRCPlayerApi player)
    {
        if (player.isLocal)
            playerIsOverlapping = true;
    }

    public override void OnPlayerTriggerExit(VRCPlayerApi player)
    {
        if (player.isLocal)
            playerIsOverlapping = false;
    }
}
*/