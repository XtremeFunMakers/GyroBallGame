using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour

{
    public Sound[] sounds;

    public static AudioManager instance;


    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);
        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }

    public void PlaySound(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.Name == name);
        if (s == null)
        {
            return;
            Debug.LogWarning("Sound:" + name + "NotFound");
        }
           
        s.source.Play();
    }

    public void StopSound(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.Name == name);
        if (s == null)
        {
            return;
            Debug.LogWarning("Sound:" + name + "NotFound");
        }

        s.source.Stop();
    }
    public void PauseSound(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.Name == name);
        if (s == null)
        {
            return;
            Debug.LogWarning("Sound:" + name + "NotFound");
        }

        s.source.Pause();
    }
}
