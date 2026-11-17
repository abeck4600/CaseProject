using UnityEngine;
using TMPro;

public class PlayerCounter : MonoBehaviour
{
    [SerializeField] TMP_Text countText;
    [SerializeField] int min = 1;
    [SerializeField] int max = 4;

    void OnEnable() => Refresh();

    public void Change(int amount)
    {
        ScreenManager.Players = Mathf.Clamp(ScreenManager.Players + amount, min, max);
        Refresh();
    }

    void Refresh() => countText.text = ScreenManager.Players.ToString();
}