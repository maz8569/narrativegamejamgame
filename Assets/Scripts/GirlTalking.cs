using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirlTalking : MonoBehaviour
{
    [SerializeField] TextAsset inkJSON;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("g"))
        {
            DialogueManager.GetInstance().StartDialogue(inkJSON);
        }
    }
}
