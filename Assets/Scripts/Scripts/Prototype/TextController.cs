using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class TextController : MonoBehaviour
{
    public GameObject cancerTitle,
        cancerDef,
        typesTitle,
        breastcancer,
        ovarianCancer,
        lungCancer,
        liverCancer,
        prostateCancer,
        causesTitle,
        inhalation,
        genetics,
        virus,
        smoking,
        preventionTitle,
        checkups,
        avoidPoisonous,
        avoidsmoking,
        takeVaccines;

    public double cancerTitleTime,
        cancerDefTime,
        typesTitleTime,
        breastcancerTime,
        ovarianCancerTime,
        lungCancerTime,
        liverCancerTime,
        prostateCancerTime,
        causesTitleTime,
        inhalationTime,
        geneticsTime,
        virusTime,
        smokingTime,
        preventionTitleTime,
        checkupsTime,
        avoidPoisonousTime,
        avoidsmokingTime,
        takeVaccinesTime;

    public GameObject whatIsCancer, typesOfCancer, causesOfCancer, preventionOfCancer;

    public VideoPlayer _videoPlayer;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_videoPlayer.time >= cancerTitleTime)
        {
            cancerTitle.SetActive(true);
        }
        if (_videoPlayer.time >= cancerDefTime)
        {
            cancerDef.SetActive(true);
        }
        if (_videoPlayer.time > 12)
        {
            whatIsCancer.SetActive(false);
        }
        
        
        if (_videoPlayer.time >= typesTitleTime)
        {
            typesTitle.SetActive(true);
        }
        if (_videoPlayer.time >= breastcancerTime)
        {
            breastcancer.SetActive(true);
        }

        if (_videoPlayer.time >= ovarianCancerTime)
        {
            ovarianCancer.SetActive(true);
        }

        if (_videoPlayer.time >= lungCancerTime)
        {
            lungCancer.SetActive(true);
        }

        if (_videoPlayer.time >= liverCancerTime)
        {
            liverCancer.SetActive(true);
        }

        if (_videoPlayer.time >= prostateCancerTime)
        {
            prostateCancer.SetActive(true);
        }

        if (_videoPlayer.time >= 27)
        {
            typesOfCancer.SetActive(false);
        }
        
        

        if (_videoPlayer.time >= causesTitleTime)
        {
            causesTitle.SetActive(true);
        }

        if (_videoPlayer.time >= inhalationTime)
        {
            inhalation.SetActive(true);
        }

        if (_videoPlayer.time >= geneticsTime)
        {
            genetics.SetActive(true);
        }

        if (_videoPlayer.time >= virusTime)
        {
            virus.SetActive(true);
        }

        if (_videoPlayer.time >= smokingTime)
        {
            smoking.SetActive(true);
        }

        if (_videoPlayer.time >= 68)
        {
            causesOfCancer.SetActive(false);
        }
        
        

        if (_videoPlayer.time>= preventionTitleTime)
        {
            preventionTitle.SetActive(true);
        }

        if (_videoPlayer.time >= checkupsTime)
        {
            checkups.SetActive(true);
        }

        if (_videoPlayer.time >= avoidPoisonousTime)
        {
            avoidPoisonous.SetActive(true);
        }

        if (_videoPlayer.time >= avoidsmokingTime)
        {
            avoidsmoking.SetActive(true);
        }

        if (_videoPlayer.time >= takeVaccinesTime)
        {
            takeVaccines.SetActive(true);
        }

        if (_videoPlayer.time >= 110)
        {
            preventionOfCancer.SetActive(false);
        }


        /*if (_videoPlayer.time >= 117)
        {
            _videoPlayer.Pause();
            whatIsCancer.SetActive(true);
            typesOfCancer.SetActive(true);
            causesOfCancer.SetActive(true);
            preventionOfCancer.SetActive(true);
        }*/
    }
}
