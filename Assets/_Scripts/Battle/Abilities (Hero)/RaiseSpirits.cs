﻿using UnityEngine;
using System.Collections;

public class RaiseSpirits : HeroAbility {

 
    public RaiseSpirits() {
        
        abilityName = "Raise Spirits";
        abilityType = AbilityType.Burst;
        targetScope = TargetScope.AllHeroes;
        primaryDamageType = DamageType.Healing;
        manaCost = 250;

        requiresTargeting = false;

        chargeDuration = 2.0f;
        cooldownDuration = 20;
        procHeal = 100;

        effectApplied = new RaiseSpiritsEff();


    } //end Constructor()

    

    public override void AbilityMap() {

        targetingManager.TargetAllHeroes(this);
        ApplyEffectMultiple(effectApplied);
        HealProcMultiple(abilityOwner);
        ExitAbility();

    } //end AbilityMap()


} //end Ability