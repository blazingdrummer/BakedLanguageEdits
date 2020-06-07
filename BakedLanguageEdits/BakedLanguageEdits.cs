//TODO: remove unneeded "usings"
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using BepInEx;
using BepInEx.Bootstrap;
using IL.RoR2;
using Mono.Cecil.Cil;
using MonoMod.Cil;
using On.RoR2;
using R2API;
using R2API.AssetPlus;
using R2API.Utils;
using RoR2;
using UnityEngine;

namespace blazingdrummer.BakedLanguageEdits
{
	[BepInDependency("com.bepis.r2api")]
	[R2APISubmoduleDependency(nameof(LanguageAPI))]

	[BepInDependency("com.harbingerofme.Diluvian", BepInDependency.DependencyFlags.SoftDependency)]

	[BepInPlugin("com.blazingdrummer.BakedLanguageEdits", "BakedLanguageEdits", "1.0.0")]
	public sealed class BakedLanguageEdits : BaseUnityPlugin
	{
		private BakedLanguageEdits()
		{
			//taken from DiluvianDifficulty
			this.DefaultLanguage = new Dictionary<string, string>();
		}

		private void Awake() //Called when loaded by BepInEx.
		{
			RoR2.Run.onRunStartGlobal += this.Run_onRunStartGlobal; //need this to handle Diluvian's difficulty-based edits
		}

		private void Start() //Called at the first frame of the game.
		{

		}

		//taken from DiluvianDifficulty and adapted to use LanguageAPI
		private void ReplaceString(string token, string newText)
		{
			this.DefaultLanguage[token] = RoR2.Language.GetString(token);
			LanguageAPI.Add(token, newText);
		}

		private readonly Dictionary<string, string> DefaultLanguage;

		#region DiluvianEdits
		private void Run_onRunStartGlobal(RoR2.Run run)
		{
			if (run.selectedDifficulty > DifficultyIndex.Hard)
			{
				this.ReplaceString("ITEM_BEAR_PICKUP", "Chance to <style=cIsHealing>block</style> incoming damage. <color=#ad41f1>Her curses rain upon this and find it unlucky. Roll with disadvantage.</color> <style=cIsUtility>Unaffected by other sources of luck.</style> <style=cStack>Stacks hyperbolically.\n(1 = 13%, 10 = 60%, 50 = 88%)</style>");
			}
		}
		#endregion
	}
}
