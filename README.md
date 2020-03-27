# Disclaimer & Usage
Hey, this is designed for use with the [Baked modpack](https://thunderstore.io/package/blazingdrummer/BakedModpack/). I would really appreciate if you checked it out!

Using these edits without the associated modpack might give you some confusing results (mainly descriptions that don't match behavior and some weird tooltips), but you are welcome to use it as a template for personal use or other packs if you like. Do your best RedRiot impression and add funny names or pop-culture references, I don't care. Use it however you want!

## What Does It Do?
Item descriptions in-game are a lot more complete, equipment display their base cooldowns, and I generally did my best to make sure you never have to run to a wiki to figure out how something works. I've added in custom descriptions for the elite equipment based on the most accurate numbers I could find, done some sneaky highlighting to emphasize this game's really unique existing lore, and even added some of my own. Don't worry, I didn't give everything away, and there are still plenty of secrets hidden in logbook entries and the like.

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
  - waiting on Hopoo to add support for editing AffixYellow and give AffixHaunted a texture

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