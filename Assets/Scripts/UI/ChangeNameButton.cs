using UnityEngine;

public class ChangeNameButton : MonoBehaviour
{
    public void OnClick_ChangeName()
    {
        GameLogicManager.Inst.RequestChangeName();
    }
}
