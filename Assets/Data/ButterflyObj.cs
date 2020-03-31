using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ButterflyF
{
    [CreateAssetMenu(fileName= "RotationSpeed", menuName= "CreateScriptableObject/RotationSpeed", order=1)]
    public sealed class RotationSpeed : ScriptableObject
    {
        // Start is called before the first frame update

        [Range(0.0f, 1.0f)]
        public float Speed;

      

    }
}