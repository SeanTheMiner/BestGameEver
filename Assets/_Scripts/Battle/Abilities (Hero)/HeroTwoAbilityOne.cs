﻿using UnityEngine;
using System.Collections;
using Abilities;
using Procs;


public class HeroTwoAbilityOne : HeroAbility {

    public DamageProc damageProc = new DamageProc();

    public HeroTwoAbilityOne() {

        abilityName = "Charge Blast";
        abilityType = AbilityType.Burst;
        targetScope = TargetScope.AllEnemies;
        primaryDamageType = DamageType.Magical;
        manaCost = 100;
        
        requiresTargeting = false;

        chargeDuration = 5.0f;
        cooldownDuration = 10.0f;

        damageProc.damageType = DamageProc.DamageType.Magical;
        damageProc.procDamage = 150.0f;
       
    } //end Constructor()

    public override void AbilityMap() {

        targetingManager.TargetAllEnemies(this);
        DetermineHitOutcomeMultiple(abilityOwner, damageProc);
        ExitAbility();

    } //end AbilityMap()
    

} //end Ability