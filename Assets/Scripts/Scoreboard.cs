using UnityEngine;

// Счётчик очков. Выводится простым текстом через OnGUI, без настройки Canvas.
public class ScoreBoard : MonoBehaviour
{
    public static ScoreBoard Instance { get; private set; }

    private int totalPoints;

    private void Awake()
    {
        Instance = this;
    }

    public void AddPoints(int amount)
    {
        totalPoints += amount;
        Debug.Log("Очки: " + totalPoints);
    }

    private void OnGUI()
    {
        GUIStyle style = new GUIStyle(GUI.skin.label) { fontSize = 28 };
        style.normal.textColor = Color.white;
        GUI.Label(new Rect(20, 20, 400, 50), "Очки: " + totalPoints, style);
    }
}