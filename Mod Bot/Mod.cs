﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
namespace ModLibrary
{
    /// <summary>
    /// Base class for all mods, contains virtual implementations for diffrent events in the game.
    /// </summary>
    public class Mod
    {
        /// <summary>
        /// Called when the game scene is changed
        /// </summary>
        /// <param name="gamemode"></param>
        public virtual void OnSceneChanged(GameMode gamemode)
        {

        }
        /// <summary>
        /// Called in FirstPersonMover Start()
        /// </summary>
        /// <param name="me"></param>
        public virtual void OnFirstPersonMoverSpawned(GameObject me)
        {

        }
        /// <summary>
        /// Called in FirstPersonMover Update()
        /// </summary>
        /// <param name="me"></param>
        public virtual void OnFirstPersonMoverUpdate(GameObject me)
        {

        }
        /// <summary>
        /// Called when F3 + R is pressed.
        /// </summary>
        public virtual void OnModRefreshed()
        {

        }
        /// <summary>
        /// Called when the level editor is started.
        /// </summary>
        public virtual void OnLevelEditorStarted()
        {

        }
        /// <summary>
        /// Called when a level editor object is placed or spawned (gets called when any object gets spawed).
        /// </summary>
        public virtual void OnObjectPlacedInLevelEditor(GameObject _object)
        {

        }
        /// <summary>
        /// Called when you run a command in the console (mostly for debuging).
        /// </summary>
        /// <param name="command"></param>
        public virtual void OnCommandRan(string command)
        {

        }
    }
}
