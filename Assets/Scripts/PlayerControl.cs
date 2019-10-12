using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{
    public GameConfigScriptableObject config;
    public Camera movingCamera;
    public PlayerCollide playerCollide;

    void Update()
    {
        if (playerCollide.hasCollided)
        {
            if (Input.GetMouseButtonDown(0) || HasTouched())
            {
                var scene = SceneManager.GetActiveScene();
                SceneManager.LoadScene(scene.name);
            }
            return;
        }
        var isPressed = Input.GetMouseButton(0) || Input.touchCount > 0;
        transform.eulerAngles = new Vector3(0, 0, transform.eulerAngles.z + (isPressed ? -config.playerRotateSpeed : config.playerRotateSpeed));
        Vector3 delta = new Vector3(0, config.playerMoveSpeed, 0);
        transform.position += delta;
        movingCamera.transform.position += delta;
    }

    private static bool HasTouched()
    {
        var touches = Input.touches;
        for (int i = 0; i < touches.Length; i++)
        {
            if (touches[i].phase == TouchPhase.Began)
            {
                return true;
            }
        }

        return false;
    }
}
