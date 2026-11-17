using UnityEngine;
using UnityEngine.UI;
using TMPro;

[System.Serializable]
public class CharacterSprite
{
    public string name;
    public Sprite sprite;
}

public class CharacterView : MonoBehaviour
{
    [SerializeField] CharacterSprite[] characters;
    [SerializeField] Image image;
    [SerializeField] TMP_Text nameText;                       // "Leo needs your help!"
    [SerializeField] string textFormat = "{0} needs your help!";

    [Header("Mission-tekster (lad tomme felter være tomme)")]
    [SerializeField] TMP_Text missionText;    // Speechboble on MissionScreen
    [SerializeField] TMP_Text doneText;       // lower title on ReflectionScreen
    [SerializeField] TMP_Text questionText;   // speechboble ReflectionScreen

    [SerializeField] string missionHint = "Press the button when you're done!";

    void OnEnable()
    {
        if (image == null) image = GetComponent<Image>();
        string who = ScreenManager.Character;

        foreach (var c in characters)
        {
            if (c.name == who)
            {
                image.sprite = c.sprite;
                if (nameText) nameText.text = string.Format(textFormat, c.name);
                break;
            }
        }

        if (who != null && CharacterData.Missions.TryGetValue(who, out var m))
        {
            if (missionText)
                missionText.text = m.task + "\n<size=80%>" + missionHint + "</size>";
            if (doneText)     doneText.text     = m.done;
            if (questionText) questionText.text = m.question;
        }
    }
}