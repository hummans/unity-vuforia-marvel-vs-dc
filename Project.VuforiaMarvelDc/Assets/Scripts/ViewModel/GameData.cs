using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

namespace ViewModel
{
    [CreateAssetMenu(fileName = "GameData", menuName = "Scriptable/Game Data")]
    public class GameData : ScriptableObject
    {
        public PlayerCharacter[] playerCharacters;
        public List<PlayerCharacter> currentCharacters { get; set;}
        public ISubject<string> OnFinish = new Subject<string>();
    }
}
