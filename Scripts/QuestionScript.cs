using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class QuestionScript : MonoBehaviour
{
    public GameObject RestartButton;
    public string ScoreFinish;
   // public GameObject GoodAndBadAnswerBackground;
    public GameObject GoodAndBadAnswerBackgroundSecondLayer;
    public GameObject NumberBackground;
    // public GameObject GoodAndBadAnswer;
    public GameObject GoodAndBadAnswerSecondLayer;
    public Sprite goodAnswerImage;
    public Sprite badAnswerImage;
    public Sprite One;
    public Sprite Two;
    public Sprite Three;
    public Sprite Four;
    public Sprite Five;
    public Sprite Six;
    public Sprite Seven;
    public Sprite Eight;
    public Sprite Nein;
    public Sprite Ten;
    public Sprite Eleven;
    public Sprite Twelve;
    public Sprite Thirteen;
    public Sprite Fourteen;
    public Sprite Fifteen;
    public Sprite Sixteen;
    public Sprite Seventeen;
    public Sprite Eighteen;
    public Sprite nineteen;
    public Sprite Twenty;
    //public GameObject QuestionBank;
    public GameObject QuestionBankSecondLayout;
    public GameObject GameOver;
    public string SCORMscore = "ScormProcessSetValue('cmi.core.score.raw', '";
    public float FinalScore = 0;
    
    public Text endGameText;
    public Text wynik;
    public Text endGameWynik;
    public Text lvl;
    
    //public GameObject GoodAndBadAnswer;
    public GameObject GoodAndBadAnswerSecondLayout;
    //public Text Question;
    //public Text QuestionNumber;
    //public Text CheckAnswer;
    //public Text FirstAnswer;
    //public Text SecondAnswer;
    //public Text ThirdAnswer;
    //public Text FourthAnswer;
    //public Text FifthAnswer;
    //public Text SixthAnswer;
    public Text QuestionSecondLayer;
    public Text QuestionNumberSecondLayer;
    public Text CheckAnswerSecondLayer;
    //public Text FirstAnswerSecondLayer;
    //public Text SecondAnswerSecondLayer;
    //public Text ThirdAnswerSecondLayer;

    public Text textBox;
    /*public GameObject FirstAnswerObject;
    public Toggle FirstAnswerToggle;
    public GameObject SecondAnswerObject;
    public Toggle SecondAnswerToggle;
    public GameObject ThirdAnswerObject;
    public Toggle ThirdAnswerToggle;
    public GameObject FourthAnswerObject;
    public Toggle FourthAnswerToggle;
    public GameObject FifthAnswerObject;
    public Toggle FifthAnswerToggle;
    public GameObject SixthAnswerObject;
    public Toggle SixthAnswerToggle;*/

    public GameObject FirstAnswerObjectSecondLayer;
    public Toggle FirstAnswerToggleSecondLayer;
    public GameObject SecondAnswerObjectSecondLayer;
    public Toggle SecondAnswerToggleSecondLayer;
   // public GameObject ThirdAnswerObjectSecondLayer;
   // public Toggle ThirdAnswerToggleSecondLayer;

    public Image endGame;
    public Sprite loseGameOver;
    public Sprite winGameOver;


    // Start is called before the first frame update
    void Start()
    {
        //QuestionBank.SetActive(false);
        //GoodAndBadAnswer.gameObject.SetActive(false);
        QuestionBankSecondLayout.SetActive(false);
        GoodAndBadAnswerSecondLayer.gameObject.SetActive(false);
        GameOver.gameObject.SetActive(false);
    }
    /*
     public void MarkToggleOne()
     {
         if (NextQuestionScript.lvl == 2)
         {
             if (FirstAnswerToggle.isOn)
             {
                 SecondAnswerToggle.isOn = false;
                 ThirdAnswerToggle.isOn = false;
                 FourthAnswerToggle.isOn = false;
                 FifthAnswerToggle.isOn = false;
                 SixthAnswerToggle.isOn = false;

             }
         }
             if (SecondAnswerToggle.isOn)
             {
                 FirstAnswerToggle.isOn = false;
                 ThirdAnswerToggle.isOn = false;
                 FourthAnswerToggle.isOn = false;
                 FifthAnswerToggle.isOn = false;
                 SixthAnswerToggle.isOn = false;

             }
             if (ThirdAnswerToggle.isOn)
             {
                 ZerowanieTogli();
                 ThirdAnswerToggle.isOn = true;
             }
             if (FourthAnswerToggle.isOn)
             {
                 ZerowanieTogli();
                 FourthAnswerToggle.isOn = true;
             }
             if (FifthAnswerToggle.isOn)
             {
                 ZerowanieTogli();
                 FifthAnswerToggle.isOn = true;
             }
             if (SixthAnswerToggle.isOn)
             {
                 ZerowanieTogli();
                 SixthAnswerToggle.isOn = true;
             }
         }
}*/
    public void MarkToggleFirstSecondLayer()
    {
        
            if (FirstAnswerToggleSecondLayer.isOn)
            {
                SecondAnswerToggleSecondLayer.isOn = false;
            }
        
    }
    public void MarkToggleSecondSecondLayer()
    {
        
            if (SecondAnswerToggleSecondLayer.isOn)
            {
                FirstAnswerToggleSecondLayer.isOn = false;
            }
        
    }
   /*
    public void MarkToggleSecond()
    {
        if (NextQuestionScript.lvl == 2)
        {
            if (SecondAnswerToggle.isOn)
            {
                FirstAnswerToggle.isOn = false;
                ThirdAnswerToggle.isOn = false;
                FourthAnswerToggle.isOn = false;
                FifthAnswerToggle.isOn = false;
                SixthAnswerToggle.isOn = false;

            }
        }
    }
    public void MarkToggleThird()
    {
        if (NextQuestionScript.lvl == 2)
        {
            if (ThirdAnswerToggle.isOn)
            {
                FirstAnswerToggle.isOn = false;
                SecondAnswerToggle.isOn = false;
                FourthAnswerToggle.isOn = false;
                FifthAnswerToggle.isOn = false;
                SixthAnswerToggle.isOn = false;

            }
        }
    }
    public void MarkToggleFourth()
    {
        if (NextQuestionScript.lvl == 2)
        {
            if (FourthAnswerToggle.isOn)
            {
                FirstAnswerToggle.isOn = false;
                ThirdAnswerToggle.isOn = false;
                SecondAnswerToggle.isOn = false;
                FifthAnswerToggle.isOn = false;
                SixthAnswerToggle.isOn = false;
            }
        }
    }
    public void MarkToggleFifth()
    {
        if (NextQuestionScript.lvl == 2)
        {
            if (FifthAnswerToggle.isOn)
            {
                FirstAnswerToggle.isOn = false;
                ThirdAnswerToggle.isOn = false;
                FourthAnswerToggle.isOn = false;
                SecondAnswerToggle.isOn = false;
                SixthAnswerToggle.isOn = false;

            }
        }
    }
    public void MarkToggleSixth()
    {
        if (NextQuestionScript.lvl == 2)
        {
            if (SixthAnswerToggle.isOn)
            {
                FirstAnswerToggle.isOn = false;
                ThirdAnswerToggle.isOn = false;
                FourthAnswerToggle.isOn = false;
                FifthAnswerToggle.isOn = false;
                SecondAnswerToggle.isOn = false;

            }
        }
    }
    */

    void OnTriggerEnter2D(Collider2D obj)
    {
        if (obj.gameObject.tag == "baby2")
        {
            Time.timeScale = 0f;
            if (NextQuestionScript.lvl == 1)
            {
                QuestionBankSecondLayout.SetActive(true);
                NumberBackground.GetComponent<Image>().sprite = One;
                QuestionSecondLayer.text = "Czy przestrzeganie prawa zależy wyłącznie od dobrej woli jednostki i nie jest zagwarantowane przymusem państwowym?";
                
                //FirstAnswerSecondLayer.text = "TAK";
                //SecondAnswerSecondLayer.text = "NIE";
            }
            if (NextQuestionScript.lvl == 2)
            {
                QuestionBankSecondLayout.SetActive(true);
                QuestionSecondLayer.text = "Czy wykładnia to ustalanie właściwej treści norm prawnych zawartych w przepisach?";
                NumberBackground.GetComponent<Image>().sprite = Two;
                //FirstAnswerSecondLayer.text = "TAK";
                //SecondAnswerSecondLayer.text = "NIE";

            }
            if (NextQuestionScript.lvl == 3)
            {
                QuestionBankSecondLayout.SetActive(true);
                QuestionSecondLayer.text = "Czy umowy dochodzą do skutku przez zgodne oświadczenie woli dwóch lub więcej stron?";
                NumberBackground.GetComponent<Image>().sprite = Three;
                //FirstAnswerSecondLayer.text = "TAK";
                //SecondAnswerSecondLayer.text = "NIE";

            }
            if (NextQuestionScript.lvl == 4)
            {
                QuestionBankSecondLayout.SetActive(true);
                QuestionSecondLayer.text = "Czy B2B to obrót dwustronnie profesjonalny/dwustronnie gospodarczy?";
                NumberBackground.GetComponent<Image>().sprite = Four;
                //FirstAnswerSecondLayer.text = "TAK";
                //SecondAnswerSecondLayer.text = "NIE";

            }
            if (NextQuestionScript.lvl == 5)
            {
                QuestionBankSecondLayout.SetActive(true);
                QuestionSecondLayer.text = "Czy konsumentem może być tylko osoba fizyczna?";
                NumberBackground.GetComponent<Image>().sprite = Five;
                //FirstAnswerSecondLayer.text = "TAK";
                //SecondAnswerSecondLayer.text = "NIE";

            }
            if (NextQuestionScript.lvl == 6)
            {
                QuestionBankSecondLayout.SetActive(true);
                QuestionSecondLayer.text = "Czy spółka z o.o. jest spółką osobową?";
                NumberBackground.GetComponent<Image>().sprite = Six;
                //FirstAnswerSecondLayer.text = "TAK";
                //SecondAnswerSecondLayer.text = "NIE";
            }
            if (NextQuestionScript.lvl == 7)
            {
                QuestionBankSecondLayout.SetActive(true);
                QuestionSecondLayer.text = "Czy partner nie odpowiada za zobowiązania spółki związane z wykonywaniem wolnego zawodu przez innego partnera?";
                NumberBackground.GetComponent<Image>().sprite = Seven;
                //FirstAnswerSecondLayer.text = "TAK";
                //SecondAnswerSecondLayer.text = "NIE";
            }
            if (NextQuestionScript.lvl == 8)
            {
                QuestionBankSecondLayout.SetActive(true);
                QuestionSecondLayer.text = "Czy prawa wspólników spółek kapitałowych dzielą się na prawa o charakterze majątkowym i korporacyjnym?";
                NumberBackground.GetComponent<Image>().sprite = Eight;
                //FirstAnswerSecondLayer.text = "TAK";
                //SecondAnswerSecondLayer.text = "NIE";
            }
            if (NextQuestionScript.lvl == 9)
            {
                QuestionBankSecondLayout.SetActive(true);
                QuestionSecondLayer.text = "Czy umowa najmu należy do umów regulujących używanie rzeczy, takich jak np. leasing?";
                NumberBackground.GetComponent<Image>().sprite = Nein;
                //FirstAnswerSecondLayer.text = "TAK";
                //SecondAnswerSecondLayer.text = "NIE";
            }
            if (NextQuestionScript.lvl == 10)
            {
                QuestionBankSecondLayout.SetActive(true);
                QuestionSecondLayer.text = "Czy w ramach rękojmi kupujący może m.in. żądać wymiany rzeczy na wolną od wad?";
                NumberBackground.GetComponent<Image>().sprite = Ten;
                //FirstAnswerSecondLayer.text = "TAK";
                //SecondAnswerSecondLayer.text = "NIE";
            }
            if (NextQuestionScript.lvl == 11)
            {
                QuestionBankSecondLayout.SetActive(true);
                QuestionSecondLayer.text = "Czy umowę przewozu w komunikacji miejskiej zawiera się przez samo zajęcie miejsca w pojeździe?";
                NumberBackground.GetComponent<Image>().sprite = Eleven;
                //FirstAnswerSecondLayer.text = "TAK";
                //SecondAnswerSecondLayer.text = "NIE";
            }
            if (NextQuestionScript.lvl == 12)
            {
                QuestionBankSecondLayout.SetActive(true);
                QuestionSecondLayer.text = "Czy spełnienie świadczenia niezamówionego przez konsumenta (np. wysyłka książki do domu) nakłada na niego obowiązek zapłaty?";
                NumberBackground.GetComponent<Image>().sprite = Twelve;
                //FirstAnswerSecondLayer.text = "TAK";
                //SecondAnswerSecondLayer.text = "NIE";
            }
            if (NextQuestionScript.lvl == 13)
            {
                QuestionBankSecondLayout.SetActive(true);
                QuestionSecondLayer.text = "Czy postanowienia umowne nieuzgodnione indywidualnie z konsumentem zawsze go wiążą?";
                NumberBackground.GetComponent<Image>().sprite = Thirteen;
                //FirstAnswerSecondLayer.text = "TAK";
                //SecondAnswerSecondLayer.text = "NIE";
            }
            if (NextQuestionScript.lvl == 14)
            {
                QuestionBankSecondLayout.SetActive(true);
                QuestionSecondLayer.text = "Czy ustawa o ochronie konkurencji i konsumentów zakazuje naruszania zbiorowych interesów konsumentów?";
                NumberBackground.GetComponent<Image>().sprite = Fourteen;
                //FirstAnswerSecondLayer.text = "TAK";
                //SecondAnswerSecondLayer.text = "NIE";
            }
            if (NextQuestionScript.lvl == 15)
            {
                QuestionBankSecondLayout.SetActive(true);
                QuestionSecondLayer.text = "Czy konosament będący towarowym papierem wartościowym opiewa na wierzytelność pieniężną?";
                NumberBackground.GetComponent<Image>().sprite = Fifteen;
                //FirstAnswerSecondLayer.text = "TAK";
                //SecondAnswerSecondLayer.text = "NIE";
            }
            if (NextQuestionScript.lvl == 16)
            {
                QuestionBankSecondLayout.SetActive(true);
                QuestionSecondLayer.text = "Czy jedną z podstaw ogłoszenia upadłości jest stan nadmiernego zadłużenia?";
                NumberBackground.GetComponent<Image>().sprite = Sixteen;
                //FirstAnswerSecondLayer.text = "TAK";
                //SecondAnswerSecondLayer.text = "NIE";
            }
            if (NextQuestionScript.lvl == 17)
            {
                QuestionBankSecondLayout.SetActive(true);
                QuestionSecondLayer.text = "Czy ustawa Prawo restrukturyzacyjne reguluje jedynie dwa rodzaje postępowań: o zatwierdzenie układu oraz sanacyjne?";
                NumberBackground.GetComponent<Image>().sprite = Seventeen;
                //FirstAnswerSecondLayer.text = "TAK";
                //SecondAnswerSecondLayer.text = "NIE";
            }
            if (NextQuestionScript.lvl == 18)
            {
                QuestionBankSecondLayout.SetActive(true);
                QuestionSecondLayer.text = "Czy celem postępowania restrukturyzacyjnego jest uniknięcie upadłości przedsiębiorcy i umożliwienie mu dalszego funkcjonowania?";
                NumberBackground.GetComponent<Image>().sprite = Eighteen;
                //FirstAnswerSecondLayer.text = "TAK";
                //SecondAnswerSecondLayer.text = "NIE";
            }
            if (NextQuestionScript.lvl == 19)
            {
                QuestionBankSecondLayout.SetActive(true);
                QuestionSecondLayer.text = "Czy akcyza to podatek pośredni nakładany na niektóre wyroby konsumpcyjne?";
                NumberBackground.GetComponent<Image>().sprite = nineteen;
                //FirstAnswerSecondLayer.text = "TAK";
                //SecondAnswerSecondLayer.text = "NIE";
            }
            if (NextQuestionScript.lvl == 20)
            {
                QuestionBankSecondLayout.SetActive(true);
                QuestionSecondLayer.text = "Czy zjawiskiem przeciwnym do inflacji jest deflacja?";
                NumberBackground.GetComponent<Image>().sprite = Twenty;
                //FirstAnswerSecondLayer.text = "TAK";
                //SecondAnswerSecondLayer.text = "NIE";
            }
        }
    }
    
    public void Resume()
    {

       // QuestionBank.SetActive(false);
        QuestionBankSecondLayout.SetActive(false);
        
        StartCoroutine(TimerRoutine());

        /*Time.timeScale = 0f;
        float pauseTime = 3f;
        float step = Time.realtimeSinceStartup / Time.realtimeSinceStartup;
        //float timer = 1f / Time.realtimeSinceStartup;


       /* while (pauseTime > 0)
        {

            yield return 0;

            pauseTime -= step;
            textBox.text = step.ToString();
            Debug.Log(pauseTime);
        }
        Time.timeScale = 1f;
        /*float pauseTime = Time.realtimeSinceStartup + 3f;

        while (pauseTime > Time.realtimeSinceStartup)
        {
            //yield return 0;

            textBox.text = Time.realtimeSinceStartup.ToString("n0");
            Debug.Log(pauseTime);
        }
        Time.timeScale = 1f;*/
    }

    IEnumerator TimerRoutine()
    {
        textBox.gameObject.SetActive(true);
        Time.timeScale = 0f;
        float timestart = 3f;
        float step = 1;
        while (timestart > 0)
        {              
            textBox.text = timestart.ToString("n0");
            timestart -= step;
            yield return new WaitForSecondsRealtime(step);
            while (timestart == 0)
            {
                timestart -= step;
                textBox.text = "GO!";
                yield return new WaitForSecondsRealtime(step);
            }
        }
        textBox.gameObject.SetActive(false);
        //GoodAndBadAnswer.gameObject.SetActive(false);
        GoodAndBadAnswerSecondLayer.gameObject.SetActive(false);
        /*FirstAnswerToggle.isOn = false;
        SecondAnswerToggle.isOn = false;
        ThirdAnswerToggle.isOn = false;
        FourthAnswerToggle.isOn = false;
        FifthAnswerToggle.isOn = false;
        SixthAnswerToggle.isOn = false;*/
        FirstAnswerToggleSecondLayer.isOn = false;
        SecondAnswerToggleSecondLayer.isOn = false;
        Time.timeScale = 1f;
    }
    public void Check()
    {
        
        //ScoreTake();
        //ScoreTakemax();
        ScoreFinished();
        ScoreFinishedmax();
        if (NextQuestionScript.lvl == 1)
        {
            GoodAndBadAnswerSecondLayer.gameObject.SetActive(true);
            if (!FirstAnswerToggleSecondLayer.isOn && SecondAnswerToggleSecondLayer.isOn)
            {
                CheckAnswerSecondLayer.text = "Gratulacje! Odpowiedziałeś dobrze.";
                gamePoint.wynik += 1;
                GoodAndBadAnswerBackgroundSecondLayer.GetComponent<Image>().sprite = goodAnswerImage;
            }
            else
            {
                CheckAnswerSecondLayer.text = "Niestety! Odpowiedziałeś źle.";
                GoodAndBadAnswerBackgroundSecondLayer.GetComponent<Image>().sprite = badAnswerImage;
            }
        }
       
        if (NextQuestionScript.lvl == 2)
        {
            GoodAndBadAnswerSecondLayer.gameObject.SetActive(true);
            if (FirstAnswerToggleSecondLayer.isOn && !SecondAnswerToggleSecondLayer.isOn)
            {
                CheckAnswerSecondLayer.text = "Gratulacje! Odpowiedziałeś dobrze.";
                gamePoint.wynik += 1;
                GoodAndBadAnswerBackgroundSecondLayer.GetComponent<Image>().sprite = goodAnswerImage;
            }
            else
            {
                CheckAnswerSecondLayer.text = "Niestety! Odpowiedziałeś źle.";
                GoodAndBadAnswerBackgroundSecondLayer.GetComponent<Image>().sprite = badAnswerImage;
            }
        }
        if (NextQuestionScript.lvl == 3)
        {
            GoodAndBadAnswerSecondLayer.gameObject.SetActive(true);
            if (FirstAnswerToggleSecondLayer.isOn && !SecondAnswerToggleSecondLayer.isOn)
            {
                CheckAnswerSecondLayer.text = "Gratulacje! Odpowiedziałeś dobrze.";
                gamePoint.wynik += 1;
                GoodAndBadAnswerBackgroundSecondLayer.GetComponent<Image>().sprite = goodAnswerImage;
            }
            else
            {
                CheckAnswerSecondLayer.text = "Niestety! Odpowiedziałeś źle.";
                GoodAndBadAnswerBackgroundSecondLayer.GetComponent<Image>().sprite = badAnswerImage;
            }
        }
        if (NextQuestionScript.lvl == 4)
        {
            GoodAndBadAnswerSecondLayer.gameObject.SetActive(true);
            if (FirstAnswerToggleSecondLayer.isOn && !SecondAnswerToggleSecondLayer.isOn)
            {
                CheckAnswerSecondLayer.text = "Gratulacje! Odpowiedziałeś dobrze.";
                gamePoint.wynik += 1;
                GoodAndBadAnswerBackgroundSecondLayer.GetComponent<Image>().sprite = goodAnswerImage;
            }
            else
            {
                CheckAnswerSecondLayer.text = "Niestety! Odpowiedziałeś źle.";
                GoodAndBadAnswerBackgroundSecondLayer.GetComponent<Image>().sprite = badAnswerImage;
            }
        }
        if (NextQuestionScript.lvl == 5)
        {
            GoodAndBadAnswerSecondLayer.gameObject.SetActive(true);
            if (FirstAnswerToggleSecondLayer.isOn && !SecondAnswerToggleSecondLayer.isOn)
            {
                CheckAnswerSecondLayer.text = "Gratulacje! Odpowiedziałeś dobrze.";
                gamePoint.wynik += 1;
                GoodAndBadAnswerBackgroundSecondLayer.GetComponent<Image>().sprite = goodAnswerImage;
            }
            else
            {
                CheckAnswerSecondLayer.text = "Niestety! Odpowiedziałeś źle.";
                GoodAndBadAnswerBackgroundSecondLayer.GetComponent<Image>().sprite = badAnswerImage;
            }
        }
        if (NextQuestionScript.lvl == 6)
        {
            GoodAndBadAnswerSecondLayer.gameObject.SetActive(true);
            if (!FirstAnswerToggleSecondLayer.isOn && SecondAnswerToggleSecondLayer.isOn)
            {
                CheckAnswerSecondLayer.text = "Gratulacje! Odpowiedziałeś dobrze.";
                gamePoint.wynik += 1;
                GoodAndBadAnswerBackgroundSecondLayer.GetComponent<Image>().sprite = goodAnswerImage;
            }
            else
            {
                CheckAnswerSecondLayer.text = "Niestety! Odpowiedziałeś źle.";
                GoodAndBadAnswerBackgroundSecondLayer.GetComponent<Image>().sprite = badAnswerImage;
            }
        }
        if (NextQuestionScript.lvl == 7)
        {
            GoodAndBadAnswerSecondLayer.gameObject.SetActive(true);
            if (FirstAnswerToggleSecondLayer.isOn && !SecondAnswerToggleSecondLayer.isOn)
            {
                CheckAnswerSecondLayer.text = "Gratulacje! Odpowiedziałeś dobrze.";
                gamePoint.wynik += 1;
                GoodAndBadAnswerBackgroundSecondLayer.GetComponent<Image>().sprite = goodAnswerImage;
            }
            else
            {
                CheckAnswerSecondLayer.text = "Niestety! Odpowiedziałeś źle.";
                GoodAndBadAnswerBackgroundSecondLayer.GetComponent<Image>().sprite = badAnswerImage;
            }
        }
        if (NextQuestionScript.lvl == 8)
        {
            GoodAndBadAnswerSecondLayer.gameObject.SetActive(true);
            if (FirstAnswerToggleSecondLayer.isOn && !SecondAnswerToggleSecondLayer.isOn)
            {
                CheckAnswerSecondLayer.text = "Gratulacje! Odpowiedziałeś dobrze.";
                gamePoint.wynik += 1;
                GoodAndBadAnswerBackgroundSecondLayer.GetComponent<Image>().sprite = goodAnswerImage;
            }
            else
            {
                CheckAnswerSecondLayer.text = "Niestety! Odpowiedziałeś źle.";
                GoodAndBadAnswerBackgroundSecondLayer.GetComponent<Image>().sprite = badAnswerImage;
            }
        }
        if (NextQuestionScript.lvl == 9)
        {
            GoodAndBadAnswerSecondLayer.gameObject.SetActive(true);
            if (FirstAnswerToggleSecondLayer.isOn && !SecondAnswerToggleSecondLayer.isOn)
            {
                CheckAnswerSecondLayer.text = "Gratulacje! Odpowiedziałeś dobrze.";
                gamePoint.wynik += 1;
                GoodAndBadAnswerBackgroundSecondLayer.GetComponent<Image>().sprite = goodAnswerImage;
            }
            else
            {
                CheckAnswerSecondLayer.text = "Niestety! Odpowiedziałeś źle.";
                GoodAndBadAnswerBackgroundSecondLayer.GetComponent<Image>().sprite = badAnswerImage;
            }
        }
        if (NextQuestionScript.lvl == 10)
        {
            GoodAndBadAnswerSecondLayer.gameObject.SetActive(true);
            if (FirstAnswerToggleSecondLayer.isOn && !SecondAnswerToggleSecondLayer.isOn)
            {
                CheckAnswerSecondLayer.text = "Gratulacje! Odpowiedziałeś dobrze.";
                gamePoint.wynik += 1;
                GoodAndBadAnswerBackgroundSecondLayer.GetComponent<Image>().sprite = goodAnswerImage;
            }
            else
            {
                CheckAnswerSecondLayer.text = "Niestety! Odpowiedziałeś źle.";
                GoodAndBadAnswerBackgroundSecondLayer.GetComponent<Image>().sprite = badAnswerImage;
            }
        }
        if (NextQuestionScript.lvl == 11)
        {
            GoodAndBadAnswerSecondLayer.gameObject.SetActive(true);
            if (!FirstAnswerToggleSecondLayer.isOn && SecondAnswerToggleSecondLayer.isOn)
            {
                CheckAnswerSecondLayer.text = "Gratulacje! Odpowiedziałeś dobrze.";
                gamePoint.wynik += 1;
                GoodAndBadAnswerBackgroundSecondLayer.GetComponent<Image>().sprite = goodAnswerImage;
            }
            else
            {
                CheckAnswerSecondLayer.text = "Niestety! Odpowiedziałeś źle.";
                GoodAndBadAnswerBackgroundSecondLayer.GetComponent<Image>().sprite = badAnswerImage;
            }
        }
        if (NextQuestionScript.lvl == 12)
        {
            GoodAndBadAnswerSecondLayer.gameObject.SetActive(true);
            if (!FirstAnswerToggleSecondLayer.isOn && SecondAnswerToggleSecondLayer.isOn)
            {
                CheckAnswerSecondLayer.text = "Gratulacje! Odpowiedziałeś dobrze.";
                gamePoint.wynik += 1;
                GoodAndBadAnswerBackgroundSecondLayer.GetComponent<Image>().sprite = goodAnswerImage;
            }
            else
            {
                CheckAnswerSecondLayer.text = "Niestety! Odpowiedziałeś źle.";
                GoodAndBadAnswerBackgroundSecondLayer.GetComponent<Image>().sprite = badAnswerImage;
            }
        }
        if (NextQuestionScript.lvl == 13)
        {
            GoodAndBadAnswerSecondLayer.gameObject.SetActive(true);
            if (!FirstAnswerToggleSecondLayer.isOn && SecondAnswerToggleSecondLayer.isOn)
            {
                CheckAnswerSecondLayer.text = "Gratulacje! Odpowiedziałeś dobrze.";
                gamePoint.wynik += 1;
                GoodAndBadAnswerBackgroundSecondLayer.GetComponent<Image>().sprite = goodAnswerImage;
            }
            else
            {
                CheckAnswerSecondLayer.text = "Niestety! Odpowiedziałeś źle.";
                GoodAndBadAnswerBackgroundSecondLayer.GetComponent<Image>().sprite = badAnswerImage;
            }
        }
        if (NextQuestionScript.lvl == 14)
        {
            GoodAndBadAnswerSecondLayer.gameObject.SetActive(true);
            if (FirstAnswerToggleSecondLayer.isOn && !SecondAnswerToggleSecondLayer.isOn)
            {
                CheckAnswerSecondLayer.text = "Gratulacje! Odpowiedziałeś dobrze.";
                gamePoint.wynik += 1;
                GoodAndBadAnswerBackgroundSecondLayer.GetComponent<Image>().sprite = goodAnswerImage;
            }
            else
            {
                CheckAnswerSecondLayer.text = "Niestety! Odpowiedziałeś źle.";
                GoodAndBadAnswerBackgroundSecondLayer.GetComponent<Image>().sprite = badAnswerImage;
            }
        }
        if (NextQuestionScript.lvl == 15)
        {
            GoodAndBadAnswerSecondLayer.gameObject.SetActive(true);
            if (!FirstAnswerToggleSecondLayer.isOn && SecondAnswerToggleSecondLayer.isOn)
            {
                CheckAnswerSecondLayer.text = "Gratulacje! Odpowiedziałeś dobrze.";
                gamePoint.wynik += 1;
                GoodAndBadAnswerBackgroundSecondLayer.GetComponent<Image>().sprite = goodAnswerImage;
            }
            else
            {
                CheckAnswerSecondLayer.text = "Niestety! Odpowiedziałeś źle.";
                GoodAndBadAnswerBackgroundSecondLayer.GetComponent<Image>().sprite = badAnswerImage;
            }
        }
        if (NextQuestionScript.lvl == 16)
        {
            GoodAndBadAnswerSecondLayer.gameObject.SetActive(true);
            if (FirstAnswerToggleSecondLayer.isOn && !SecondAnswerToggleSecondLayer.isOn)
            {
                CheckAnswerSecondLayer.text = "Gratulacje! Odpowiedziałeś dobrze.";
                gamePoint.wynik += 1;
                GoodAndBadAnswerBackgroundSecondLayer.GetComponent<Image>().sprite = goodAnswerImage;
            }
            else
            {
                CheckAnswerSecondLayer.text = "Niestety! Odpowiedziałeś źle.";
                GoodAndBadAnswerBackgroundSecondLayer.GetComponent<Image>().sprite = badAnswerImage;
            }
        }
        if (NextQuestionScript.lvl == 17)
        {
            GoodAndBadAnswerSecondLayer.gameObject.SetActive(true);
            if (FirstAnswerToggleSecondLayer.isOn && !SecondAnswerToggleSecondLayer.isOn)
            {
                CheckAnswerSecondLayer.text = "Gratulacje! Odpowiedziałeś dobrze.";
                gamePoint.wynik += 1;
                GoodAndBadAnswerBackgroundSecondLayer.GetComponent<Image>().sprite = goodAnswerImage;
            }
            else
            {
                CheckAnswerSecondLayer.text = "Niestety! Odpowiedziałeś źle.";
                GoodAndBadAnswerBackgroundSecondLayer.GetComponent<Image>().sprite = badAnswerImage;
            }
        }
        if (NextQuestionScript.lvl == 18)
        {
            GoodAndBadAnswerSecondLayer.gameObject.SetActive(true);
            if (FirstAnswerToggleSecondLayer.isOn && !SecondAnswerToggleSecondLayer.isOn)
            {
                CheckAnswerSecondLayer.text = "Gratulacje! Odpowiedziałeś dobrze.";
                gamePoint.wynik += 1;
                GoodAndBadAnswerBackgroundSecondLayer.GetComponent<Image>().sprite = goodAnswerImage;
            }
            else
            {
                CheckAnswerSecondLayer.text = "Niestety! Odpowiedziałeś źle.";
                GoodAndBadAnswerBackgroundSecondLayer.GetComponent<Image>().sprite = badAnswerImage;
            }
        }
        if (NextQuestionScript.lvl == 19)
        {
            GoodAndBadAnswerSecondLayer.gameObject.SetActive(true);
            if (FirstAnswerToggleSecondLayer.isOn && !SecondAnswerToggleSecondLayer.isOn)
            {
                CheckAnswerSecondLayer.text = "Gratulacje! Odpowiedziałeś dobrze.";
                gamePoint.wynik += 1;
                GoodAndBadAnswerBackgroundSecondLayer.GetComponent<Image>().sprite = goodAnswerImage;
            }
            else
            {
                CheckAnswerSecondLayer.text = "Niestety! Odpowiedziałeś źle.";
                GoodAndBadAnswerBackgroundSecondLayer.GetComponent<Image>().sprite = badAnswerImage;
            }
        }
        if (NextQuestionScript.lvl == 20)
        {
            GoodAndBadAnswerSecondLayer.gameObject.SetActive(true);
            if (FirstAnswerToggleSecondLayer.isOn && !SecondAnswerToggleSecondLayer.isOn)
            {
                CheckAnswerSecondLayer.text = "Gratulacje! Odpowiedziałeś dobrze.";
                gamePoint.wynik += 1;
                GoodAndBadAnswerBackgroundSecondLayer.GetComponent<Image>().sprite = goodAnswerImage;
            }
            else
            {
                CheckAnswerSecondLayer.text = "Niestety! Odpowiedziałeś źle.";
                GoodAndBadAnswerBackgroundSecondLayer.GetComponent<Image>().sprite = badAnswerImage;
            }
        }
        FinalScore = gamePoint.wynik / 20 * 100;
        if (NextQuestionScript.lvl == 20)
            {
            
                RestartButton.gameObject.SetActive(false);
            
            //ScoreTakeraw();
            SCORMscore += FinalScore.ToString() + "')";
                GameOver.gameObject.SetActive(true);
                if (gamePoint.wynik >= 14)
                {
                    endGameText.text = "Gratulacje! Uzyskałeś wystarczającą liczbę punktów:";
                    endGame.sprite = winGameOver;
                    endGameWynik.text = FinalScore.ToString() + "%";
                    FinishedPassed();
                }
                else
                {
                    endGameText.text = "Niestety, nie odpowiedziano na wystarczającą liczbę pytań.";
                    endGame.sprite = loseGameOver;
                    endGameWynik.text = FinalScore.ToString() + "%";
                }
            ScoreFinishedraw();
            Time.timeScale = 0;
            }
        
        
    }
    public void ScoreFinished() {
        Application.ExternalCall("ScormProcessSetValue('cmi.core.score.min', '0')");
    }
    public void ScoreFinishedmax()
    {
        Application.ExternalCall("ScormProcessSetValue('cmi.core.score.max', '100')");
    }
    public void ScoreFinishedraw()
    {
        Application.ExternalCall(SCORMscore);
        Application.ExternalCall("ScormProcessSetValue('cmi.core.lesson_status', 'completed')");
        Application.ExternalCall("ScormProcessFinish(true)");
    }
    public void FinishedPassed()
    {
        Application.ExternalCall("ScormProcessSetValue('cmi.core.lesson_status', 'passed')");
    }
}