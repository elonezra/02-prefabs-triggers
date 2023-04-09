# 02-prefabs-triggers: homework

this repo is a modification for the 4th homworke.
I decided to work on the first section and add spawning for the shilde.

## Changes

* I modifide the "ShildeThePlayer" script to support letting the spawner object when the player is shilded, so the shilde icon won't spawn that time.
```
private IEnumerator ShieldTemporarily(DestroyOnTrigger2D destroyComponent) {   // co-routines
    // private async void ShieldTemporarily(DestroyOnTrigger2D destroyComponent) {      // async-await
        destroyComponent.enabled = false;
        *GameObject g = transform.parent.gameObject;*
        *g.GetComponent<spawn_shild>().shilded_flag = true;*
        for (float i = duration; i > 0; i--) {
            Debug.Log("Shield: " + i + " seconds remaining!");
            yield return new WaitForSeconds(1);       // co-routines
            // await Task.Delay(1000);                // async-await
        }
        Debug.Log("Shield gone!");
        *g.GetComponent<spawn_shild>().shilded_flag = false;*
        destroyComponent.enabled = true;
    }
```



## Credits

Programming:
* Maoz Grossman
* Erel Segal-Halevi

Online courses:
* [The Ultimate Guide to Game Development with Unity 2019](https://www.udemy.com/the-ultimate-guide-to-game-development-with-unity/), by Jonathan Weinberger

Graphics:
* [Matt Whitehead](https://ccsearch.creativecommons.org/photos/7fd4a37b-8d1a-4d4c-80a2-4ca4a3839941)
* [Kenney's space kit](https://kenney.nl/assets/space-kit)
* [Ductman's 2D Animated Spacehips](https://assetstore.unity.com/packages/2d/characters/2d-animated-spaceships-96852)
* [Franc from the Noun Project](https://commons.wikimedia.org/w/index.php?curid=64661575)
* [Greek-arrow-animated.gif by Andrikkos is licensed under CC BY-SA 3.0](https://search.creativecommons.org/photos/2db102af-80d0-4ec8-9171-1ac77d2565ce)
