using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourController : MonoBehaviour
{
    public Material Luke;
    public Material Anakin;
    public Material Maul;

    public Light LukeLight;
    public Light AnakinLight;
    public Light MaulLightOne;
    public Light MaulLightTwo;

    public ParticleSystem LukeParticle;
    public ParticleSystem AnakinParticle;
    public ParticleSystem MaulParticle1;
    public ParticleSystem MaulParticle2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (PlayerController.colourOveride == true) {

            if (PlayerController.lightSaberSelect == 0) {

                Luke.color = PlayerController.lightSaberColour;
                Luke.SetColor("_EmissionColor", PlayerController.lightSaberColour);
                LukeLight.color = PlayerController.lightSaberColour;

                Gradient grad = new Gradient();
                grad.SetKeys(new GradientColorKey[] { new GradientColorKey(PlayerController.lightSaberColour, 0.0f), new GradientColorKey(Color.white
                    , 1.0f) }, new GradientAlphaKey[] { new GradientAlphaKey(0.54f, 1.0f), new GradientAlphaKey(1.0f, 1.0f) });
                var gradient = LukeParticle.colorOverLifetime;
                gradient.color = grad;

                var main = LukeParticle.main;
                main.startColor = PlayerController.lightSaberColour;

                var trails = LukeParticle.GetComponent<ParticleSystem>().trails;
                trails.colorOverLifetime = grad;

            }
            else if (PlayerController.lightSaberSelect == 1) {

                Anakin.color = PlayerController.lightSaberColour;
                Anakin.SetColor("_EmissionColor", PlayerController.lightSaberColour);
                AnakinLight.color = PlayerController.lightSaberColour;

                Gradient grad = new Gradient();
                grad.SetKeys(new GradientColorKey[] { new GradientColorKey(PlayerController.lightSaberColour, 0.0f), new GradientColorKey(Color.white
                    , 1.0f) }, new GradientAlphaKey[] { new GradientAlphaKey(0.54f, 1.0f), new GradientAlphaKey(1.0f, 1.0f) });
                var gradient = AnakinParticle.colorOverLifetime;
                gradient.color = grad;

                var main = AnakinParticle.main;
                main.startColor = PlayerController.lightSaberColour;

                var trails = AnakinParticle.GetComponent<ParticleSystem>().trails;
                trails.colorOverLifetime = grad;

            }
            else if (PlayerController.lightSaberSelect == 2)
            {

                Maul.color = PlayerController.lightSaberColour;
                Maul.SetColor("_EmissionColor", PlayerController.lightSaberColour);
                MaulLightOne.color = PlayerController.lightSaberColour;
                MaulLightTwo.color = PlayerController.lightSaberColour;

                Gradient grad = new Gradient();
                grad.SetKeys(new GradientColorKey[] { new GradientColorKey(PlayerController.lightSaberColour, 0.0f), new GradientColorKey(Color.white
                    , 1.0f) }, new GradientAlphaKey[] { new GradientAlphaKey(0.54f, 1.0f), new GradientAlphaKey(1.0f, 1.0f) });
                var gradient = MaulParticle1.colorOverLifetime;
                gradient.color = grad;

                var main = MaulParticle1.main;
                main.startColor = PlayerController.lightSaberColour;
                var trails = MaulParticle1.GetComponent<ParticleSystem>().trails;
                trails.colorOverLifetime = grad;

                Gradient grad2 = new Gradient();
                grad2.SetKeys(new GradientColorKey[] { new GradientColorKey(PlayerController.lightSaberColour, 0.0f), new GradientColorKey(Color.white
                    , 1.0f) }, new GradientAlphaKey[] { new GradientAlphaKey(0.54f, 1.0f), new GradientAlphaKey(1.0f, 1.0f) });
                var gradient2 = MaulParticle2.colorOverLifetime;
                gradient2.color = grad2;

                var main2 = MaulParticle2.main;
                main2.startColor = PlayerController.lightSaberColour;
                var trailsPrime = MaulParticle2.GetComponent<ParticleSystem>().trails;
                trailsPrime.colorOverLifetime = grad;

            }

        }

        
    }
}
