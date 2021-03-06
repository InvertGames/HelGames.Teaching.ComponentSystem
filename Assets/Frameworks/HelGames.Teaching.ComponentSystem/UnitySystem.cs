// -----------------------------------------------------------------------
// <copyright file="UnitySystem.cs" company="Paul Schulze (HelGames)">
// Copyright 2014 Paul Schulze (HelGames). All rights reserved.
// </copyright>
// <author>Paul Schulze</author>
// -----------------------------------------------------------------------
namespace HelGames.Teaching.ComponentSystem
{
    using UnityEngine;

    /// <summary>
    /// Defines the UnitySystem.
    /// </summary>
    public class UnitySystem : MonoBehaviour, ISystem
    {
        /// <summary>
        /// Gets the game, this system is running in.
        /// </summary>
        public IGame Game { get; private set; }

        /// <summary>
        /// Initialize the system to a working state. This is called by the game as soon as
        /// the system is added to it and before the system is updated for the first time,
        /// using its <see cref="ISystem.Update"/> method.
        /// </summary>
        /// <param name="game">
        /// The <see cref="IGame"/> game, that requested the initialization. That is the game,
        /// the system will be running in.
        /// </param>
        public virtual void Initialize(IGame game)
        {
            this.Game = game;
            Debug.Log("Starting " + this.GetType().Name);
        }

        /// <summary>
        /// Destroy the system, freeing all its resources. After this call, any call to
        /// <see cref="ISystem.Initialize"/> must create a valid game state again.
        /// </summary>
        public virtual void Destroy()
        {
            this.Game = null;
        }

        /// <summary>
        /// Update this system. This method will be called by the game in appropriate
        /// intervals to give the system a chance to do continuous work. The system is
        /// responsible for deciding, whether it actually has work to do.
        /// </summary>
        public virtual void Update()
        {
        }
    }
}