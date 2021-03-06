﻿using UnityEngine;
using System.Collections;

public class ChangeStance : ChampionAbility {
    
    public ChangeStance() {

        abilityName = "Change Stance";
        abilityType = AbilityType.Toggle;
        targetScope = TargetScope.Untargeted;
        abilityDamageType = AbilityDamageType.None;

        requiresTargeting = false;
        costsMana = false;
        canBeDefault = false;

        chargeDuration = 1;
        cooldownDuration = 4;
       
        ownerChampion = (Champion)abilityOwner;
        
    } //end Constructor()


    public override void AbilityMap() {

        if (ownerChampion.currentStance == Champion.ChampionStance.Defensive) {
            ownerChampion.ChangeStanceToOffensive();
        }
        else {
            ownerChampion.ChangeStanceToDefensive();
        }
        ExitAbility();

    } //end AbilityMap()

    
} //end ChangeStance class