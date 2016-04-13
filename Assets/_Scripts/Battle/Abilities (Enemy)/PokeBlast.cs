﻿using UnityEngine;
using System.Collections;
using EnemyAbilities;
using Procs;

public class PokeBlast : EnemyAbility {

    public DamageProc damageProc = new DamageProc();

    public PokeBlast() {

        abilityName = "Poke Blast";
        chargeDuration = 5.0f;
        enemyAbilityWeight = 30;

        primaryDamageType = DamageType.Magical;
        targetScope = TargetScope.AllHeroes;
        enemyAbilityType = EnemyAbilityType.Burst;

        damageProc.procDamage = 40.0f;
        damageProc.damageType = DamageProc.DamageType.Magical;

    } //end Constructor


    public override void EnemyAbilityMap() {

        targetingManager.EnemyTargetAllHeroes(this);
        DetermineHitOutcomeMultiple(abilityOwner, damageProc);
        ExitEnemyAbility();

    } //end AbilityMap()


} //end Charge Poke class