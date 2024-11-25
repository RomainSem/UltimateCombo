using UnityEngine;

public class Character : MonoBehaviour
{
    string characterName;
    Sprite characterIcon;
    Combo[] combos;

    public Character(string characterName, Sprite characterIcon, Combo[] combos)
    {
        this.characterName = characterName;
        this.characterIcon = characterIcon;
        this.combos = combos;
    }
}
