// APC = Attack Proc Coefficient

# Personal Formatting Conventions
- general rule: keep highlighting limited to preserve impact when used
- general rule: begin sentences with verbs when possible to maximize conciseness
- general rule: numerical highlights should include both the number and descriptive word, followed by the stacking characteristics (if they exist)
- general rule: order behaviors from most to least important to enable more rapid digestion of concepts
- tags should not be nested for the sake of readability
- health highlights include the entire phrase (eg `25% of maximum health`), followed by the stacking characteristics
  - always clarify between `maximum` and `current` health (eg don't use `above 90% health`, use `above 90% maximum health`)
- damage highlights include the words `damage` and `TOTAL`, followed by the stacking characteristics //this is not vanilla's style, but is more readable imo
- utility highlights typically include entire sentences and the punctuation (unlike normal)
- distance values AND their describing term (eg radius) are highlighted as utility
- time values (eg durations) should not be highlighted
  - an exception to this is in the case of DPS descriptions like Frost Relic, where the time period (but not the duration) should be included in the damage highlight
- keep everything in `present simple` tense

# Syntax Templates
<style=c></style> //useful for copying around and then completing with desired style

<style=cIsDamage> = yellow-orange
<style=cIsUtility> = blue
<style=cIsHealth> = red-orange
<style=cIsHealing> = green
<style=cStack> = grey, smaller font size

<color=#FF7F7F> = light red (use death instead)
//<color=#9912ED> = dark purple (too dark)
<color=#007fff> = azure (`luck`, chance-based values affected by luck)
<color=#ccd3e0> = chat message for achievement (very light grey)
<color=#BDE151> = achievement name (yellow-green)

<style=cSub> = very light grey, used for sub-section in character descriptions, used for lore text in descriptions
<style=cEvent>
<style=cDeath> = red
<style=cWorldEvent>
<color=#f37aff>Time Crystals</color> (prismatic-specific, light purple/pink)
<color=#ad41f1> = N'kuhana
<color=#9912ED> = N'kuhana (use for dark backgrounds, like the red bar on N'kuhana's Opinion)
<sprite name=\"TP\" tint=1>
<sprite name=\"WIP\">
<sprite name=\"Skull\">

<i><\/i>
<b><\/b>
<u><\/u>

# Color Converter
https://www.colorhexa.com/
