using UnityEngine;

public class ApplicationManager : MonoBehaviour
{
    [SerializeField]
    private Camera mainCamera;

    private void Start()
    {
        Initialize();
        mainCamera.useOcclusionCulling = false;
    }

    private void Initialize()
    {
        if (!mainCamera)
            mainCamera = Camera.main;
    }
}
