using UnityEngine;

public class StreamerFlag : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    [SerializeField] private PlayerLogoManager logoManager;
    [SerializeField] private MeshRenderer flagRenderer;

    private float flagUpdateTimer = 0;
    private float flagUpdateInterval = 30f; // every 30s

    private Material flagMaterial;
    //[SerializeField] private Image flagImage;
    // Start is called before the first frame update
    void Start()
    {
        if (!logoManager)
        {
            logoManager = FindObjectOfType<PlayerLogoManager>();
        }

        if (!gameManager)
        {
            gameManager = FindObjectOfType<GameManager>();
        }

        flagMaterial = flagRenderer.material;

    }

    private void Update()
    {
        if (!gameManager)
        {
            return;
        }

        if (gameManager.RavenNest == null)
        {
            return;
        }

        if (!gameManager.RavenNest.Authenticated)
        {
            return;
        }

        flagUpdateTimer -= Time.deltaTime;
        if (flagUpdateTimer <= 0)
        {
            if (string.IsNullOrEmpty(gameManager.RavenNest.TwitchUserId))
            {
                return;
            }

            flagUpdateTimer = flagUpdateInterval;
            logoManager.GetLogo(gameManager.RavenNest.TwitchUserId, logo =>
            {
                if (logo != null)
                {
                    flagMaterial.mainTexture = logo.texture;
                }
            });
        }
    }
}
