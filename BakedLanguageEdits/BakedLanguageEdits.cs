using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
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
	//[BepInDependency("com.bepis.r2api")]
	[R2APISubmoduleDependency(nameof(LanguageAPI))]
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
	}
}
