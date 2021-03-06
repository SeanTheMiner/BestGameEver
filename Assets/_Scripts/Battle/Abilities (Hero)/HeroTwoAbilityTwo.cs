﻿using UnityEngine;
using System.Collections;
using Abilities;
using Heroes;
using Procs;

public class HeroTwoAbilityTwo : HeroAbility {

    public HealProc healProc = new HealProc();

    public HeroTwoAbilityTwo() {

        abilityName = "Charge Heal";
        abilityType = AbilityType.Burst;
        targetScope = TargetScope.AllHeroes;
        abilityDamageType = AbilityDamageType.Healing;
        requiresTargeting = false;
        manaCost = 85;
        
        chargeDuration = 4.0f;
        cooldownDuration = 10.0f;

        healProc.procHeal = 150.0f;
        
    } //end constructor


    public override void AbilityMap() {
        
        healProc.HealProcMultiple(abilityOwner, targetingManager.TargetAllHeroes());
        ExitAbility();

    } //end AbilityMap()
    

} //end HeroTwoAbilityTwo class