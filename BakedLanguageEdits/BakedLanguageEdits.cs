using System.Collections.Generic; //needed for dictionary creation
using BepInEx;
using R2API;
using R2API.Utils; //needed for submodule dependency
using RoR2;

namespace blazingdrummer.BakedLanguageEdits
{
	[BepInDependency("com.bepis.r2api")]
	[R2APISubmoduleDependency(nameof(LanguageAPI))]

	[BepInDependency("com.harbingerofme.Diluvian", BepInDependency.DependencyFlags.SoftDependency)]
	[BepInDependency("com.Rein.ReinWickedRing", BepInDependency.DependencyFlags.SoftDependency)]

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
			//? RoR2.Run.onRunStartGlobal += this.Run_onRunStartGlobal; //need this to handle Diluvian's difficulty-based edits

			#region DiluvianDescriptionEdits
			string text = "For those found wanting. <color=#ad41f1>N'Kuhana</color> watches with interest.<style=cStack>\n"; //the additional "/n" creates a space between the main body and the details
			text = string.Join("\n", new string[]
			{
				text,
				">Difficulty Scaling: +75%",
				">Player Health Regeneration: -60%",
				">Tougher Times: Rolls with -1 luck",
				">Monster Health Regeneration: +1.5% of MaxHP per second (out of danger)",
				">Oneshot Protection: Protects only 1% of max health",
				">Oneshot Protection: Also applies to monsters",
				">Elites: 20% cheaper",
				">Shrine of Blood: Cost hidden and random</style>"
			});

			this.ReplaceString("DIFFICULTY_DILUVIAN_DESCRIPTION", text);
			#endregion

			#region WickedRingEdits
			this.ReplaceString("WICKEDRING_PICKUP_DESC", "<style=cIsDamage>Critical strikes</style> <style=cIsUtility>reduce all cooldowns</style> by 1s <style=cStack>(+1s per stack)</style> multiplied by the attack's proc coefficient, but <style=cDeath>damage you</style> after <style=cIsHealing>on-hit healing</style> based on <style=cIsHealth>your current health</style> and <style=cIsHealing>shield</style>, <style=cIsDamage>the attack's damage</style>, and the number of stacks as a multiplier. This damage will never be <style=cDeath>lethal</style>. <style=cIsUtility>Removes base critical strike chance.</style>");
			this.ReplaceString("WICKEDRING_LOG_DESC", "<style=cIsDamage>Critical strikes</style> <style=cIsUtility>reduce all cooldowns</style> by 1s <style=cStack>(+1s per stack)</style> multiplied by the attack's proc coefficient, but <style=cDeath>damage you</style> after <style=cIsHealing>on-hit healing</style> based on <style=cIsHealth>your current health</style> and <style=cIsHealing>shield</style>, <style=cIsDamage>the attack's damage</style>, and the number of stacks as a multiplier. This damage will never be <style=cDeath>lethal</style>. <style=cIsUtility>Removes base critical strike chance.</style>");
			
			LanguageAPI.Add("ITEM_COOLDOWNONCRIT_LORE", "No pain, No gain...");
			#endregion
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

		#region DiluvianRunStartEdits
		private void Run_onRunStartGlobal(RoR2.Run run)
		{
			if (run.selectedDifficulty > DifficultyIndex.Hard)
			{
				//technically the use of nested color tags breaks my own conventions here, but I'm making an exception for the sake of readability
				this.ReplaceString("ITEM_BEAR_PICKUP", "<color=#ad41f1>A feeble attempt to thwart my challenge...\nN'kuhana's Curse: Rolls with -1 <color=#007fff>luck</color>, and remains unaffected by other sources.</color>\n\nChance to <style=cIsHealing>block</style> incoming damage. <style=cStack>Stacks hyperbolically.\n(1 = 13%, 10 = 60%, 50 = 88%)</style>");
			}
		}
		#endregion
	}
}
