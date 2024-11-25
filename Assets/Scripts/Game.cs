using UnityEngine;

public class Game : MonoBehaviour
{
    string gameName;
    Sprite gameIcon;
    Character[] characters;

    public Game(string gameName, Sprite gameIcon, Character[] characters)
    {
        this.gameName = gameName;
        this.gameIcon = gameIcon;
        this.characters = characters;
    }
}
