using UnityEngine;

namespace Components
{
    public interface IObject
    {
        public int idObject{get; set;}
        public ObjectType typeObject{get; set;}
    }
    public enum ObjectType
    {
        player,
        obstacle,
        nonplayer
    }
}

