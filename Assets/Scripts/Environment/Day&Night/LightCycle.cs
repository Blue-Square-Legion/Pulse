using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "Day/Night", menuName = "LightPreset", order =1)]
public class LightCycle : ScriptableObject
{
    public Gradient ambiantColor;
    public Gradient directionColor;
    public Gradient fogColor;
}
