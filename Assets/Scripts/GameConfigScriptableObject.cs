using UnityEngine;

[CreateAssetMenu(fileName = "GameConfig", menuName = "ScriptableObjects/GameConfigScriptableObject", order = 1)]
public class GameConfigScriptableObject : ScriptableObject
{
    public float playerRotateSpeed;
    public float playerMoveSpeed;
}