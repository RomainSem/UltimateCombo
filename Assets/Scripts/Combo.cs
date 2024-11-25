using UnityEngine;

public class Combo : MonoBehaviour
{
    int damage;
    string comboName;
    Sprite[] comboContent;

    public Combo(int damage, string comboName, Sprite[] comboContent)
    {
        this.damage = damage;
        this.comboName = comboName;
        this.comboContent = comboContent;
    }
}
