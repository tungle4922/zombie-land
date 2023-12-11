using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Init : MonoBehaviour
{

    void Start()
    {
        GameObject selectedCharacter = CharacterSelect.selectedCharacter;
        Instantiate(selectedCharacter, transform.position, Quaternion.identity);
    }



}
