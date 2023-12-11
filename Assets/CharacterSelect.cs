using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CharacterSelect : MonoBehaviour
{
    // Start is called before the first frame update
    private int index;
    [SerializeField] GameObject[] characters;
    [SerializeField] TextMeshProUGUI characterName;
    [SerializeField] GameObject[] characterPrefabs;
    public static GameObject selectedCharacter;
    void Start()
    {
        index = 0;
        SelectCharacter();
    }

    public void OnPlayBtnClick()
    {
        Application.LoadLevel("SampleScene");
    }
    // Update is called once per frame
    public void OnPrevBtnClick()
    {
        if (index > 0)
        {
            index--;
        }
        SelectCharacter();
    }
    public void OnNextBtnClick()
    {
        if (index < characters.Length - 1)
        {
            index++;
        }
        SelectCharacter();
    }

    private void SelectCharacter()
    {
        for (int i = 0; i < characters.Length; i++)
        {
            if (i == index)
            {
                characters[i].GetComponent<SpriteRenderer>().color = Color.white;
                characters[i].GetComponent<Animator>().enabled = true;
                selectedCharacter = characterPrefabs[i];
                characterName.text = characterPrefabs[i].name;
            }
            else
            {
                characters[i].GetComponent<SpriteRenderer>().color = Color.black;
                characters[i].GetComponent<Animator>().enabled = false;
            }
        }
    }
}
