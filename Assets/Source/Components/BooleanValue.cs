using UnityEngine;

namespace Source.Components
{
    [CreateAssetMenu]
    public class BooleanValue : ScriptableObject
    {
        public bool value = true;
        
        public static implicit operator bool(BooleanValue boolValue) 
        {
            return boolValue.value;
        }

    }
}