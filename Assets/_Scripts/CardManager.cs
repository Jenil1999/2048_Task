using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CardManager : MonoBehaviour
{
    // CardManager

    public List<Color> CardColor;

    [SerializeField] TextMeshProUGUI _carryUpperText;

    [SerializeField] TextMeshProUGUI _carryLowerText;

    [SerializeField] RawImage _carryRawImage;

    int _carryCardNumber;

    int _suffleCardNumber;


    private void Start()
    {
        //SetData();  
    }

    public void SetData(int id)
    {

        //Set Data For Carry Card.........................................

        _carryCardNumber = SufflingCards.Instance.Deck[id];

        _carryUpperText.text = _carryCardNumber.ToString();
        _carryUpperText.text = _carryCardNumber.ToString();

        _carryRawImage.color = CardColor[id];

        //Set Data For Suffle Card.........................................
        _suffleCardNumber = SufflingCards.Instance.Deck[id];

        _carryUpperText.text = _suffleCardNumber.ToString();
        _carryLowerText.text = _suffleCardNumber.ToString();

        _carryRawImage.color = CardColor[id];

    }
}
