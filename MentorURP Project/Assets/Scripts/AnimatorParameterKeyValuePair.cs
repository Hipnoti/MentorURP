using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class AnimatorParameterKeyValuePair
{
    public AnimatorControllerParameterType parameterType;
    public string parameterName;
    public int intValue;
    public string stringValue;
    public float floatValue;
    public bool boolValue;
}
