﻿using UnityEngine;
using System.Collections;
using Procs;

public class HealBarrage : HeroAbility {

    public HealProc healProc = new HealProc();

    //private float rampDown;
    //first few heals do more, if you want, to encourage using it a bit but not constantly

    public HealBarrage() {

        abilityName = "Heal Barrage";

        abilityType = AbilityType.InfBarrage;
        targetScope = TargetScope.Untargeted;
        abilityDamageType = AbilityDamageType.Healing;

        costsMana = false;
        requiresTargeting = false;
        hasCooldown = false;

        chargeDuration = 3;
       
        healProc.procHeal = 40;
        healProc.procSpacing = 0.85f;

    } //end Constructor()


    public override void AbilityMap() {

        UpdateInfBarrageMask(healProc.nextProcTimer, healProc.procSpacing);

        if (healProc.nextProcTimer <= Time.time) {
            CheckTarget();
            healProc.HealProcSingle(abilityOwner, targetingManager.TargetRandomHero());
            healProc.nextProcTimer = ApplySpacing(healProc.procSpacing);
        }

    } //end AbilityMap()
    

} //end HealBarrage class