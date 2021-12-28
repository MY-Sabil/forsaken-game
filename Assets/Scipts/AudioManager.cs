using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Audio;
using TMPro;

public class AudioManager : MonoBehaviour
{

	public static AudioManager instance;

	public Sound[] sounds;

	[SerializeField]
	private TextMeshProUGUI subtitleText;

	void Awake()
	{
		foreach (Sound s in sounds)
		{
			s.source = gameObject.AddComponent<AudioSource>();
			s.source.clip = s.clip;
			s.source.loop = s.loop;
		}

		subtitleText.text = "";
	}

	public void Play(string sound)
	{
		Sound s = Array.Find(sounds, item => item.name == sound);
		if (s == null)
		{
			Debug.LogWarning("Sound: " + name + " not found!");
			return;
		}

		float waitLength = 2f;

		s.source.volume = s.volume;
		s.source.pitch = s.pitch;

		s.source.Play();

		//subtitles
		subtitleText.text = s.subtitle;
		waitLength = s.subWaitLength;
		StartCoroutine(FadeInText(subtitleText));
		StartCoroutine(FadeOutText(subtitleText, waitLength));
	}

	public IEnumerator FadeInText(TextMeshProUGUI i)
    {
        i.color = new Color(i.color.r, i.color.g, i.color.b, 0);
        while (i.color.a < 1.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a + (Time.deltaTime / 1f)); //1f is time
			yield return null;
        }
    }
 
    public IEnumerator FadeOutText(TextMeshProUGUI i, float waitLength)
    {
		yield return new WaitForSeconds(waitLength);

        i.color = new Color(i.color.r, i.color.g, i.color.b, 1);
        while (i.color.a > 0.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a - (Time.deltaTime / 1f)); //1f is time
            yield return null;
        }
    }

}
