using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ViewModel;

namespace Commands
{
    public class PerfomAttackCmd : MonoBehaviour, ICommand
    {
        private CharacterData characterData;
        private readonly CharacterFight characterFight;
        private CharacterDamage characterAttackedDamage;

        public PerfomAttackCmd(CharacterData characterData, CharacterFight characterFight, CharacterDamage characterAttackedDamage)
        {
            this.characterData = characterData;
            this.characterFight = characterFight;
            this.characterAttackedDamage = characterAttackedDamage;
        }
        public void Execute()
        {
            Debug.Log("Player " + characterData.characterName + " is attack to " + characterAttackedDamage.currentLife);
        }
    }
}
