﻿using UnityEngine;
using System.Collections;
using Abilities;
using Procs;


public class HeroTwoAbilityOne : HeroAbility {

    public DamageProc damageProc = new DamageProc();
    public EffectProc effectProc = new EffectProc();

    
    public HeroTwoAbilityOne() {

        abilityName = "Charge Blast";
        abilityType = AbilityType.Burst;
        targetScope = TargetScope.AllEnemies;
        primaryDamageType = DamageType.Magical;
        manaCost = 100;
        
        requiresTargeting = false;
        appliesCoreEffect = true;

        chargeDuration = 2;
        cooldownDuration = 10.0f;

        damageProc.damageType = DamageProc.DamageType.Magical;
        damageProc.procDamage = 150.0f;

        effectProc.stacksApplied = 10;
        
    } //end Constructor()


    public override void SetCoreEffectApplied() {
        effectProc.effectApplied = coreEffectApplied;
    }


    public override void AbilityMap() {
        
        targetBattleObjectList = targetingManager.TargetAllEnemies();
        DetermineHitOutcomeMultiple(abilityOwner, damageProc);
        effectProc.ApplyEffectMultiple(effectProc.effectApplied, targetBattleObjectList);
        ExitAbility();

    } //end AbilityMap()
    

} //end Ability