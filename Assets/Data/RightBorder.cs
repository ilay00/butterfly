using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ButterflyF
{
    [CreateAssetMenu(fileName = "Rotation RightBorder", menuName = "CreateScriptableObject/RotationRightBorder", order = 1)]
    public sealed class RotationRightBorder : ScriptableObject
    {
        // Start is called before the first frame update

        [Range(0.0f, 10.0f)]
     
        public float RightBorder;



    }
}