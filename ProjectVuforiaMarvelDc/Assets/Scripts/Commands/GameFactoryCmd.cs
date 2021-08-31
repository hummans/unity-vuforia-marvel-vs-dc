using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ViewModel;

namespace Commands
{
    [CreateAssetMenu(fileName = "GameCommandFactory", menuName = "Scriptable/Command Factory/Game Command Factory")]
    public class GameFactoryCmd : ScriptableObject
    {
        public PerfomAttackCmd PerfomAttack(CharacterData characterData, CharacterFight characterFight, CharacterDamage characterAttackedDamage)
        {
            return new PerfomAttackCmd(characterData, characterFight, characterAttackedDamage);
        }
    }
}

