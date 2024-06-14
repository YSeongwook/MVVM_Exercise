using UnityEngine;

public class SkillButton : MonoBehaviour
{
    public void OnClick_LevelUpDouble()
    {
        GameLogicManager.Inst.RequestLevelUpDouble();
    }
}
