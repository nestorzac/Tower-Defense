using UnityEngine;


[CreateAssetMenu(fileName = "EnemyData", menuName = "Scriptable Objects/EnemyData")]

public class EnemyData : ScriptableObject
{
    public float attackRange = 1f;
    public float attackDamage = 10f;
    public float runSpeed = 2f;
    public float attackDuration = 1f;
    public float attackCooldown = 1f;
    public string attackSoundName = "AttackCaballero";
    public string primaryTargetTag = "Tower";
    public string runAnimationName = "CaballeroRun";
    public string attckAnimationName = "CaballeroAttack";

    public string dieAnimationName = "CaballeroDie";
    public string winAnimationName = "CaballeroWin";
    
    
    

}
