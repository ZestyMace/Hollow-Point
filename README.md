ORIGINAL AUTHOR: TTACO

PREVIOUS MAINTAINER: REDFROG6002

# HOLLOW POINT

**Please check the Issues section if you are having healing issues, thanks.**

A Hollow Knight mod that gives the Knight the ability to wield a modern day assault rifle.
Why did I make this? I wish I knew too.

While this mod is not to be taken seriously, It still aims to make a semi-serious fun ranged weapon mod to capitalize on Hollow Knight's movement system.  


**AUTHOR'S NOTE: Due to personal reasons like burnout and motivation, I might not be able to fix all the bugs so PLEASE READ THE ISSUES LIST BELOW BEFORE ASKING QUESTIONS ABOUT IT**

________________________________________________________________________________________________________________

## HOW TO BUILD

1. Clone the repository.
2. Create a text file called `LocalProperties.props` in the root of the cloned repository.
3. Create a `Project` node with `PropertyGroup` child and set `HKRefs` to the directory containing the **modded** dll files.
4. Set `HKModRefs` to the directory containing your mods, located in your managed folder.

After this, you should be able to compile the mod.
An example `LocalProperties.props` would look something like:
```xml
<Project>
    <PropertyGroup>
        <HKRefs>C:/Program Files (x86)/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/Managed</HKRefs>
        <HKModRefs>C:/Program Files (x86)/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/Managed/Mods</HKModRefs>
    </PropertyGroup>
</Project>
```

Many thanks to Ruttie for modernizing the code so I can actually work on it.
________________________________________________________________________________________________________________

## FEATURES:
-	Swap between the Nail or the Gun, allowing you range killing power and the ability to fire it at all 8 directions.
- Ability to set the firing direction, allowing you to stay on target when someones above you.
- New healing/spell resource: ADRENALINE. Consume ADRENALINE to allow you to use powerful skills. Filling your ADRENALINE completely gives you class specific buffs to help you cover their weakness. When your ADRENALINE meter is full, keep attacking and you will automatically heal, forcing you to play as aggressively as possible.
-	Replaces/modifies base spells that changes depending on what special weapon you carry, effectively creating a small class system for added flavor.
-	Passive soul regeneration, soul gained upon killing or damaging enemy, damage scaling, etc and more stats that differs from weapon to weapon.
-	Any damage you deal with your bullets will reset your dash/double jump, allowing you to stay on air as long as you keep hitting enemies.
- Firing below propels you! Use this to keep afloat above enemies while you pepper them, stay mobile during a fight or access areas you normally cant.
-	Heat and recoil mechanics, the longer you fire the more innacurate youll be, forcing you to fire at burst against farther targets.
-	80% of charms changed to mesh with the gun mechanics. These includes charms that gives you powerful buffs, weapon changing charms or defensive charms.
charms that were not changed much were either buffed, or found themselves being more effective tools for long range combat.
- Nail arts now have their own different abilities, giving them ranged power when you lack the ammunition to fight back.
-	Upgrading your nail also upgrades your gun, allowing them to scale through the game.
- **CONTAINS CHANGES TO THE PLAYER** so uninstalling on an existing save may not be safe or compatible, backup your saves!. Instructions of how to fix detailed below the Issues tab.

## What it does NOT do:
- Adds new bosses, sprites, music or modifies any of them.
- Change charm cost values.
- Care about lore. 
- No seriously who cares about the lore.
________________________________________________________________________________________________________________
## REQUIREMENTS:
NOTE: These can all be easily installed using the Official HK Discord's Modding Installer
- A legit copy of Hollow Knight on either GOG or Steam
- Make sure the Modding API correct installs itself when running the installer
- Install and Enable "ModCommon"
- Install QOL (Quality of Life Mod) by 56 (shoutouts)
- Install and Enable Hollow Point

## CONTROLS:
**CAST** = Swap between the Nail and the Gun.
**FOCUS** = Quick reload, consume adrenaline to reload your gun.
**QUICK CAST** = Use spells, you can now use spells while the gun is equipped.


## MECHANICS:
#### - *Ammo System*
The SOUL gauge is no longer related to spells, **the SOUL gauge is now the gun's pure ammo counter**


#### - *Adrenaline, Healing and Infusion*
To promote more aggression, the healing system is changed along with the spells. you instead have an ADRENALINE bar, denoted by 3 dots on your HUD.
To gain adrenaline, simply keep attacking the enemy, **getting hit by enemies also makes you lose them**, so watch out.

You have a maximum of 3 Adrenaline points, and using spells will always consume all of it. The more Adrenaline consumed, the stronger your spell would be (for example, an OBSERVER class will call 3 extra artillery barrages for every point spent)

To heal, you need to charge up your adrenaline to max (3 points), while at its maximum, your adrenaline can still charge albeit at a slower rate. During this, damaging and charging while at full power will grant you 1 mask instead, **that means you can heal yourself back from 1 mask to full as long as you keep doing damage at max adrenaline charge.**

In addition, staying on 3 adrenaline points gives you a small buff depending on the charm or class you currently have.


#### - *Fire Mode*
Tapping cast when it would normally use fireball will now **swap your fire mode**, there are 2 fire mode types
1. Omnidirectional = Denoted by an 8 pointed arrow, this means you will fire at all 8 directions.
2. Cardinal = Denoted by a 4 pointed arrow, you will only fire at 4 directions, useful for accurate firing on the move.
NOTE: You do not need Vengeful Spirit/Fireball to change this.


#### - *Nail Arts/Dagger Arts*
You will notice a dagger icon at the top, this just means you can use Dagger Arts. Using Nail/Dagger arts will cause to start a cooldown, the cooldown depends on the art itself.


#### - *Weapon Conversion Kits and Class Transfers*
Some special charms are capable of giving you an entirely different gun with its own properties. These guns are capable of changing your currently class.
**You may only carry one of these conversion kits, equipping more than one will prevent you from firing**. 
You can also transfer the current class by a specific charm, that allows you for example, to use an SMG with the Observer abilities, if you equip the Observer transfer charm.
Note however equipping more than one of these will set you back to the gun's original class.

## CLASSES
These classes changes the abilities that fits their appropriate guns. 

**Passive** - Automatically actives when you have 3 points in your adrenaline bar. 

**Down Spell** - Modifies the dive attack (Desolate Dive/Descending Dark), used for defensive means.

**Up Spell** - Modifies the scream attack (Howling Wraiths/Abyss Shriek), used for offensive means.

**BREACHER:** Focuses on close range combat, using high damaging but slow charging weapons.
Weapons: SMG and Shotgun.
Passive: Increases SOUL generation.
Down Spell: Eject several shrapnel that can tear apart close enemies.
Up Spell: Loads you up with terrain piercing ammunition, automatically firing and shooting at nearby enemies that gets close.

**SABOTEUR** Uses a balanced approach to combat, carrying gas abilities that helps with prolonged fights.
Weapons: Rifle (Default Gun), Carbine and Light Machine Gun.
Passive: Improve the chemical components of your gun, slightly increasing your bullet's velocity and damage.
Down Spell: Release a gas pulse useful for enemies that get too close.
Up Spell: Call in a storm of sulphur, scattering the entire screen with dung bombs.

**OBSERVER:** Uses hard hitting long range weapons, together with powerful airstrikes.
Weapons: Designated Marksman's Rifle and Sniper Rifle.
Passive: Slightly increases firerate.
Down Spell: Call in several small yield exploding projectiles on your location.
Up Spell: Call in a slow sweeping air burst barrage that slowly walks forward to the area the knight is facing. Can harm the player.

________________________________________________________________________________________________________________

## Known Issues (EXTREMELY IMPORTANT TO READ)
MAJOR ISSUES:
- **Backing up your save is highly recommended**, due to some code changes left over modifications stay on the save file and I dont have the time anymore to fix it in the near future. This is mostly related to the focusing cost so please, please, please backup your saves first before installing it in an existing save so you wont end up needing to modifying your save just to fix it. **If you have the focus bug on your save file with the mod uninstalled, you'll need to manually edit your save file to the default values.** 

FIX: To fix your file all you have to is use a save editor (search for one, but most quick and convenient would be Bloodorca's online save editor), find the line **focusMP_amount: ##** and make sure its set to 33, so **"focusMP_amount:" 33**, this should fix your focusing upon uninstalling.

OR

Using QoL (Quality of Life) mod: - Go to your save files - Locate user#.json (with # being the save slot number) - CTRL+F "**focusMP_amount**" - Set the value to 33

- **This mod doesnt work on a new save**, To fix this you must first create the new save, quit to main menu, and load the save again. This will then make the mod work as intended, this applies to both Regular and Godmaster new saves.
 
- **This mod DOES work with Randomizer but be wary of the same issues above**, you first need create a Rando save with Hollow Point DISABLED, quit the game, ENABLE Hollow Point, start the game (with both Rando and Hollow Point enabled) and you can now load the Rando save with Hollow Point completely working. (Otherwise, creating a new Rando save with Hollow Point enabled tends to crash the game)

MINOR ISSUES:
- Due to the wonky nature of the game, some objects have issues with colliding such as the Pure Vessel and MMC examples below. To compensate for this, nail base damage is set to a lower value but the scaling is increased, meaning the nail is significantly weaker early game but gets a higher benefit per nail upgrade than in the vanilla game.
- Bullets sometimes destroys walls, sometimes they dont. The checks feels inconsistent and I have no idea how TC determines what surfaces should get broken or not. at best just use the nail for these.
- THK/Pure Vessel sometimes do not get damaged, your bullets will past them on specific attacks, unable to fix.
- Massive Moss Charger is not affected by bullets, unable to fix, just stab them. 
- Gas attacks dont affect mosskin enemies, doesnt work either on vanilla, im not sure if this is a vanilla bug or a feature due to lore reasons. 
- Some issues posted by users are sometimes very rare and something thats not easy to replicate, if you find an issue, make sure its not due to a vanilla bug or from incompatibility with other mods.

________________________________________________________________________________________________________________
## Possible Q&A:
##### Q: Why, just why?

A: The massive amount of fan art involving Hollow Knight characters with guns was asking for it and I just had to. Also while this mod did start out as my first modding joke, the reception of something as dumb as this was just too good of an opportunity to pass.

##### Q: Is this compatible with mod X or Y?

A: So far QOL, RANDOMIZER, HP Bars works without any weird oddities, but while it may TECHNICALLY work with other large overhaul mods such as Blackmoth/Redwing or Lightbringer, they change stuff that’ll conflict with my other changes too, so best to just use these major mods by themselves. Baseline would be that anything that alters the way charm behaves is out of the question. (Yes, this involves mods like Charm Overhaul or Exaltation, please)

##### Q: Is this safe to Install/Uninstall on an existing save?

A: Should be, this mod loads all of its stuff on the fly when you load/make a new save and it doesn’t do anything that would permanently affect the game. THAT SAID, you should ALWAYS backup your save when using mods. This applies to any mod really, better safe than sorry.

##### Q: Why did you change the resource system for the spells/healing?

A:  Due to some technical difficulty with the game's system, I found it easier to just make an entirely new resources meter. As for the healing system, I made it so because I wanted to promote the player to play as aggressively as they can, and to minimize the downtime of fights. If this ends up making the mod too hard to be unfun, then I am more than willing to do some adjustments.

##### Q: I think __________ can be improved/ and here’s my suggestion.

A:  I’m neither the most creative person nor do I have infinite free time so the charm ideas can be lame I know but if you do have inquires, just message me and I’ll see what I can do (depending on what the request is at least). 

##### Q: I think this charm is lackluster/I have suggestions on how it can be balanced/improved further. 

A: Please message me! I take suggestions with consideration. Just do note some charms I haven’t change as I dislike the idea of changing stuff for the sake of changing stuff.

##### Q: I found bugs (original joke haha).

A: If you find any, please message me of WHAT it is and HOW you got it, and I’ll try my best to address it.

##### Q: IS THE TITLE A GUNGEON REFERENCE??!!?111!?!?!.

A: No, a Hollow Point is an actual low penetration type bullet mostly used by law enforcement and I got from other games that incorporate that bullet type. But yes, I am aware of the Gungeon enemy and I have played Gungeon before. 

##### Q: Worst Boss?

A: Definitely Gatling Gull.



