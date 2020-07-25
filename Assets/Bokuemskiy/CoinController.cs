using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;
namespace Bokuemskiy{
public class CoinController : MonoBehaviour
{
    
    public VRTK_InteractableObject VRTKobject;
    public void AutoSnap (bool snap) {
        if (snap) 
        VRTKobject.validDrop = VRTK_InteractableObject.ValidDropTypes.DropValidSnapDropZone;
        else
        VRTKobject.validDrop = VRTK_InteractableObject.ValidDropTypes.DropAnywhere;
    }
}
}
