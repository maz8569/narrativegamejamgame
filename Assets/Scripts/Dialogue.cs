using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue : ScriptableObject
{
    [SerializeField] Sprite image;
    [SerializeField] bool isChoice;
    [TextArea(10, 14)][SerializeField] string[] texts;
    [SerializeField] int[] affectionPoints;
    [SerializeField] Dialogue[] nextDialogue;
}
