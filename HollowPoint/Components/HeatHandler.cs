﻿using UnityEngine;
using System.Collections;

namespace HollowPoint.Components;

internal sealed class HeatHandler : MonoBehaviour
{
    public static float currentHeat;
    public static float currentEnergy = 100;
    public static float heatPauseTimer = 0.27f;//This is so whenever the player fires, theres a short pause before the heat goes down
    public const int MAX_HEAT = 100;
    public bool overheat = false;

    public bool fastCooldown = true;
    public static float fastCooldownTimer = 30f;

    public void Start()
    {
        StartCoroutine(InitializeHeatMeter());
    }

    IEnumerator InitializeHeatMeter()
    {
        while (HeroController.instance == null || PlayerData.instance == null)
        {
            yield return null;
        }
    }

    public void FixedUpdate()
    {
        currentEnergy += Time.deltaTime * 30f;

        if (currentEnergy > 100) currentEnergy = 100;

        //Modding.Logger.Log(fastCooldownTimer);
        //Heat

        if (fastCooldownTimer > 0)
        {
            fastCooldownTimer -= Time.deltaTime * 20f;
        }

        if (heatPauseTimer > 0)
        {
            heatPauseTimer -= Time.deltaTime * 1f;
            return;
        }

        if (currentHeat > 0)
        {
            currentHeat -= Time.deltaTime * 180f; //Speed heat dissipates
            if (currentHeat < 0)
            {
                currentHeat = 0;
            }
        }
    }

    public static void IncreaseHeat(float increaseAmount)
    {
        currentHeat = currentHeat + increaseAmount > 100 ? 100 : currentHeat + increaseAmount;
        fastCooldownTimer = 10f;
        heatPauseTimer = 0.27f;

        return;
    }
}
