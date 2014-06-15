// -----------------------------------------------------------------------
// <copyright file="BreakoutGame.cs" company="HelGames Company Identifier">
// Copyright 2014 HelGames Company Identifier. All rights reserved.
// </copyright>
// <author>Paul Schulze</author>
// -----------------------------------------------------------------------
namespace HelGames.Teaching.Breakout
{
    using System;
    using System.Collections.Generic;
    using HelGames.Teaching.ComponentSystem;
    using HelGames.Teaching.EventManager;
    using UnityEngine;

    /// <summary>
    /// Defines the BreakoutGame.
    /// </summary>
    public class BreakoutGame : UnityGame
    {
        /// <summary>
        /// Start the game.
        /// </summary>
        public override void Start()
        {
            base.Start();
            GameObject.DontDestroyOnLoad(this);
            this.EventManager.FireEvent(new HelGamesEvent(ComponentSystemEvents.UpdateComponentManagers, null));
            this.EventManager.QueueEvent(new HelGamesEvent(BreakoutEvents.GameStarted, null));
        }
    }
}