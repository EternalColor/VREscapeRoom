using Unity.Netcode.Components;

namespace VREscapeRoom.Logic
{
    /// <summary>
    /// Networked client authoritative transform for players.
    /// </summary>
    public class PlayerNetworkTransform : NetworkTransform
    {
        public override void OnNetworkSpawn()
        {
            base.OnNetworkSpawn();
            CanCommitToTransform = IsOwner;
        }

        protected override void Update()
        {
            CanCommitToTransform = IsOwner;
            base.Update();
            if (NetworkManager != null && (NetworkManager.IsConnectedClient || NetworkManager.IsListening))
            {
                if (CanCommitToTransform)
                {
                    TryCommitTransformToServer(transform, NetworkManager.LocalTime.Time);
                }
            }
        }
        
        protected override bool OnIsServerAuthoritatitive()
        {
            return false;
        }
    }
}