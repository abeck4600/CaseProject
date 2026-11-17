using UnityEngine;

public class ScreenManager : MonoBehaviour
{
    [SerializeField] GameObject[] screens;   // træk de 5 skærme ind i rækkefølge

    public static int Players = 2;
    public static string Character;
    public static string Adventure;

    void Start() => Show(0);

    public void Show(int index)
    {
        for (int i = 0; i < screens.Length; i++)
            screens[i].SetActive(i == index);
    }

    public void PickCharacter(string name) { Character = name; Show(2); }
    public void PickAdventure(string name) { Adventure = name; Show(3); }
}