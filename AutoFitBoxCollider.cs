using UnityEngine;

public class AutoSetupWaterCollision : MonoBehaviour
{
    public GameObject wasserSimulation;
    public GameObject abtropfschalePlastik;

    void Start()
    {
        // Setze Layer "WasserZiel" auf Layer 8
        int wasserZielLayer = LayerMask.NameToLayer("WasserZiel");

        if (abtropfschalePlastik != null)
            abtropfschalePlastik.layer = wasserZielLayer;

        if (wasserSimulation != null)
        {
            var ps = wasserSimulation.GetComponent<ParticleSystem>();
            var collision = ps.collision;
            collision.enabled = true;
            collision.type = ParticleSystemCollisionType.World;
            collision.collidesWith = 1 << wasserZielLayer;
        }
    }
}
