using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using ViewModel;
using TMPro;
using UnityEngine.UI;

namespace Components
{
    public class CharacterDataDisplay : MonoBehaviour
    {
        public RawImage characterImage;
        public TextMeshProUGUI hitsLabel;
        public CharacterData characterData;

        void Start()
        {
            characterData.currentHits
                .Subscribe(UpdateHits)
                .AddTo(this);
            
            characterImage.texture = characterData.characterImage;
        }

        void UpdateHits(int hits)
        {
            hitsLabel.text = "Hits: " + hits.ToString();
        }
    }
}
