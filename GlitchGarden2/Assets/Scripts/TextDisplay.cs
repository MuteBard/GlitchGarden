using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextDisplay : MonoBehaviour
{
    [SerializeField] int SortingLayer;
    [SerializeField] string type;
    [SerializeField] GameObject defender;
    [SerializeField] GameArea gameArea;
    TextMeshProUGUI textmeshPro;

    void Start(){
        textmeshPro = GetComponent<TextMeshProUGUI>();
        SetDefenderText();
        SetBankText();
    }

    void Update(){
        SetBankText();
    }

    private void SetBankText(){
        if(gameArea){
            textmeshPro.SetText(gameArea.GetText());
        }
    }
    private void SetDefenderText(){
        if(defender){
            var stats = defender.GetComponent<Stats>();
            textmeshPro.SetText(stats.GetCost().ToString());
        }
    }
}
