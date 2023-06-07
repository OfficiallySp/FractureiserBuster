# What is Fractureiser
Make the jump here for further and more up to date reading and research. Below is a short summary. correct as of 07/06/2023
https://github.com/fractureiser-investigation/fractureiser

The malware, named after the CurseForge account used to upload most of the malicious files, has been injected into copies of many popular plugins and mods via compromised Curseforge and dev.bukkit.org accounts. The malware appears to have been injected into popular modpacks, including Better Minecraft.

The malware operates in multiple stages, with infected mod files serving as a "Stage 0" to initiate the process. Stages 1, 2, and 3 follow, with Stage 3 being the primary component of the malware.

Stage 3 is known to propagate itself to all jar files on the filesystem, potentially infecting mods that were not downloaded from CurseForge or BukkitDev. It's also designed to steal cookies and login information for various web browsers, replace cryptocurrency addresses in the clipboard with alternates presumably owned by the attacker, and steal Discord, Microsoft, and Minecraft credentials.

Due to the malware's behavior, the authors believe it to be a targeted attack against the modded Minecraft ecosystem. It's a severe threat that is unlikely to be detected by standard anti-malware products.

Users should exercise extreme caution when downloading Minecraft mods, regardless of origin. While the control server for the malware is currently offline, any downloads from CurseForge or the Bukkit plugin repository in the last 2-3 weeks could potentially be malicious.

Even though the affected accounts had two-factor authentication enabled, the accounts were compromised, suggesting that this isn't a simple password compromise situation. The authors are also not confident that any hosting service is unaffected by this malware.

To check for infection, users can look for specific unusual paths where the malware attempts to save Stage 2. The malware is hardcoded for Windows and Linux only. If these files are found, all jar files on the system are potentially compromised, and all browser logins should be considered compromised as well. Passwords should be changed immediately.

Finally, a couple of scripts are provided to help identify if a jar file is infected with Stage 0. However, non-technical users are advised to check if their system was affected using the provided steps, take necessary action if needed, and refrain from downloading anything from CurseForge or dev.bukkit.org until further notice.

