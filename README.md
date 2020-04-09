# Disclaimer & Usage
Hey, this is designed for use with the [Baked modpack](https://thunderstore.io/package/blazingdrummer/BakedModpack/). I would really appreciate if you checked it out!

Using these edits without the associated modpack might give you some confusing results (mainly descriptions that don't match behavior and some weird tooltips), but you are welcome to use it as a template for personal use or other packs if you'd like. Do your best RedRiot impression and add funny names or pop-culture references, I don't care. Use it however you want!

## What Does It Do?
BLE (BakedLanguageEdits) makes changes to the in-game text to support changes made by the modpack and to give users more information while they are playing.

Pinging & picking up an item gives you more exact stats as to what it does, where in vanilla, this would simply say something like "increases attack speed". Normally, this information is only available in a wiki while you are playing, or in the logbook. It could be argued that this is a skill aspect of the game, and I agree that memorizing what items do is important, but personally I think that it's an unnecessary step. If you have to read every description, you'll be keeping a slower pace than if you already have an item's function memorized. And having this resource allows you to potentially theorycraft build options on the fly (eg figuring out if your current build will support infinite tonic).

![ItemPingDescription](https://github.com/blazingdrummer/BakedLanguageEdits/blob/master/Images/ItemPingDescription.png)

Hovering over an item in the Tab menu gives you a similar description.

![ItemHoverDescription](https://github.com/blazingdrummer/BakedLanguageEdits/blob/master/Images/ItemHoverDescription.png)

Equipment also shows more exact numbers, as well as the base cooldown.

![EquipmentPingDescription](https://github.com/blazingdrummer/BakedLanguageEdits/blob/master/Images/EquipmentPingDescription.png)

And supports hovering.

![EquipmentHoverDescription](https://github.com/blazingdrummer/BakedLanguageEdits/blob/master/Images/EquipmentHoverDescription.png)

This become particularly useful with something like Tonic, which has a lot of effects. Items like this I've done a large amount of formatting and editing on longer description like this in order to ensure they don't run offscreen. This might have problems on different resolutions, which I could consider looking into potential solutions for.

![SpinelTonic](https://github.com/blazingdrummer/BakedLanguageEdits/blob/master/Images/SpinelTonic.png)

I also moved the negative effects onto the description for Tonic Affliction, and various other small tweaks like this.

![TonicAffliction](https://github.com/blazingdrummer/BakedLanguageEdits/blob/master/Images/TonicAffliction.png)

Where this all really shines is with an item like Gesture that is affected by a mod (in this case, GeneralFixes or at least it will be soon). Gesture's default description does not mention it having a break chance, but with BakedLanguageEdits, it does now.

![GestureOfTheDrowned_Modded](https://github.com/blazingdrummer/BakedLanguageEdits/blob/master/Images/GestureOfTheDrowned_Modded.png)

There's also some custom additions I did to the game's lore. I tried to keep these as subtle as possible, and not tread on any toes, while also respecting the original game's lore. Because it's not truly canon, I tried to focus on highlighting the existing known lore as much as possible instead of going crazy with my own ideas.

![SPOILER](https://github.com/blazingdrummer/BakedLanguageEdits/blob/master/Images/SPOILER.png)

## How Do You Make Something Like This?
This might be a useful example for how to use AssetPlus to replace the game's language files in a non-destructive way. Feel free to mess around with this mod without having to worry about messing up your game.

I've also included a file named "styles.txt" that I used as my personal notes when creating this that contains all of the formatting syntax I (and orignally Hopoo) used. If you are interested in doing any language edits yourself, I hope you will find that useful.

# Contact Info
Join the [Baked Discord](https://discord.gg/QRtdUbV), or DM on Discord or Twitter [@blazingdrummer](https://twitter.com/blazingdrummer).
**Please don't bug other devs with issues or feedback. I'd be happy to help you and can pass on any information that they will need. Thanks!**

## Credits
  - Harb for creating and helping me figure out the AssetPlusRequester
  - ontrigger's ItemStatsMod for the original inspiration that I expanded upon

### TODO
  - considering making a mod specific to this pack that would allow me handle the cases that AssetPlus can't, such as editing the tooltips of modded items at runtime or calculating the current proc chance of items (ie replicating the function of ItemStatsMod)
  - waiting on Hopoo to add support for editing AffixYellow

## Changelog
`v1.0.0`

  - initial release

`v1.0.1`

  - changed example armor values on Rose Buckler from 1, 10, 50 to 100, 200, 300
    - the old values weren't that useful when Rose Buckler gives 30 armor per stack

`v1.0.2`

  - changed Fuel Array explosion condition to "health bar" rather than "maximum health"

`v1.1.0`

  - corrected "logarithmic" stacking to "hyperbolic"
  - removed exact drop rates from bandolier due to its custom formula
  - added "(+0% per stack)" to Harvester's Scythe, Wicked Ring, and Predatory Instincts
  - added the 5% crit chance to Predatory's descriptions
  - added base cooldowns to equipment
  - changed Acrid poison description from "maximum health" to "current health"
    - plus additional highlighting

`v1.2.0`

  - changed Acrid poison description from "based on current health" to "5% of their maximum health"
    - removed the stacking behavior to match the switch to using AcridPoisonBuffs instead of AlternativeAcrid
  - clarified that Commando's grenades explode "on impact"
  - added a note about "pinging enemies" to Engineer's turret tips

`v1.2.1`

  - removed the reference to SkipWelcomeScreen from the welcome screen due to distribution changes (can't automatically disable mods)
  - removed the notes on the character select screen about "mutators" due to transferring those to BakedMutators
  - removed the wrenches from the multiplayer button

`v1.2.2`

  - added AssetPlusRequester as a dependency :facepalm:
  - README: updated formatting

`v2.0.2`

  - Artifact 2.0 update
    - gave all of the new items and descriptions the same treatment (more complete in-game descriptions, cleaned up a couple typos, equipment cooldowns, etc)
  - updated for new GeneralFixes changes, removal of AcridM1Heal, poison nerfs from AcridPoisonBuffs, removal of VanillaTweaks, and removal of MakeMonsterToothGreatAgain

`v2.0.3`

  - fixed README images