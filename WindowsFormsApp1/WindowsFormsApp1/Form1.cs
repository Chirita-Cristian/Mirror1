using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using Newtonsoft.Json;
using WolframAlphaNET;
using System.Threading.Tasks;
using Microsoft.CognitiveServices.Speech;
using WAWrapper;
using System.Speech.Recognition;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        
    System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();

        public Form1()
        {
            
            BackColor = System.Drawing.Color.Black;
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            t.Interval = 1000;
            t.Tick += new EventHandler(this.t_Tick);
            t.Start();
            cast();
            vreme();
            calendars();
            RecognizeSpeechAsync();
            Rectangle screen = Screen.PrimaryScreen.WorkingArea;
            int w = Width >= screen.Width ? screen.Width : (screen.Width + Width) / 2;
            int h = Height >= screen.Height ? screen.Height : (screen.Height + Height) / 2;
            this.Location = new Point((screen.Width - w) / 2, (screen.Height - h) / 2);
            this.Size = new Size(w, h);
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            this.Bounds = Screen.PrimaryScreen.Bounds;



        }

        public async Task RecognizeSpeechAsync()
        {

            var config = SpeechConfig.FromSubscription("541650d764734a37a947aa914ba310cc", "westeurope");
           
            using (Microsoft.CognitiveServices.Speech.SpeechRecognizer recognizer = new Microsoft.CognitiveServices.Speech.SpeechRecognizer(config))
            {

                var result = await recognizer.RecognizeOnceAsync();


                // Checks result.
                bool speech1on = false;
                string result2 = result.Text;

                if (result.Reason == ResultReason.RecognizedSpeech)
                {
                    if (result.Text.Contains("Mirror"))
                    {
                        int i = result.Text.IndexOf(" ") + 1;

                        speech1on = true;
                        result2 = result.Text.Substring(i);
                    }
                    else speech1on = false;
                    if (speech1on)
                    {

                        var wa = new WAEngine { APIKey = "3YYV6P-R5W8R7TY35" };
                        WALogger.LogLevel = WALogLevel.None;
                        WALogger.ConsoleLogLevel = WALogLevel.Verbose;
                        var question = result2;
                        var query = new WAQuery() { Input = question, Format = WAQueryFormat.PlainText };
                        var queryresult = new WAQueryResult();
                        speech.Visible = true;
                        speech.Text = question;
                        query.PodStates.Add("test");
                        query.AppID = wa.APIKey;
                        string url = query.FormatQuery();
                        var result1 = wa.RunQuery(query);
                        foreach (var pod in result1.Pods)
                        {


                            foreach (var subpod in pod.SubPods)
                            {

                                string titlu = pod.Title;

                                if (titlu.Contains("Result"))
                                {
                                    System.Speech.Synthesis.SpeechSynthesizer synth = new System.Speech.Synthesis.SpeechSynthesizer();

                                    // Configure the audio output.   
                                    synth.SetOutputToDefaultAudioDevice();

                                    // Speak a string.  
                                    synth.Speak(subpod.PlainText);
                                    raspuns.Visible = true;
                                    raspuns.Text = subpod.PlainText;
                                }
                                else if (titlu.Contains("Basic information"))
                                {

                                    System.Speech.Synthesis.SpeechSynthesizer synth = new System.Speech.Synthesis.SpeechSynthesizer();

                                    // Configure the audio output.   
                                    synth.SetOutputToDefaultAudioDevice();

                                    synth.Speak(subpod.PlainText);
                                    raspuns.Visible = true;
                                    raspuns.Text = subpod.PlainText;
                                }
                                

                                else if (titlu.Contains("Estimates for"))
                                {

                                    System.Speech.Synthesis.SpeechSynthesizer synth = new System.Speech.Synthesis.SpeechSynthesizer();

                                    // Configure the audio output.   
                                    synth.SetOutputToDefaultAudioDevice();

                                    synth.Speak(subpod.PlainText);
                                    raspuns.Visible = true;
                                    raspuns.Text = subpod.PlainText;
                                }

                                else if (titlu.Contains("Biological"))
                                {

                                    System.Speech.Synthesis.SpeechSynthesizer synth = new System.Speech.Synthesis.SpeechSynthesizer();

                                    // Configure the audio output.   
                                    synth.SetOutputToDefaultAudioDevice();

                                    synth.Speak(subpod.PlainText);
                                    raspuns.Visible = true;
                                    raspuns.Text = subpod.PlainText;
                                }

                                else if (titlu.Contains("Definitions"))
                                {

                                    System.Speech.Synthesis.SpeechSynthesizer synth = new System.Speech.Synthesis.SpeechSynthesizer();

                                    // Configure the audio output.   
                                    synth.SetOutputToDefaultAudioDevice();

                                    synth.Speak(subpod.PlainText);
                                    raspuns.Visible = true;
                                    raspuns.Text = subpod.PlainText;
                                }

                            }
                        }


                    }
                   
                }
            }
           RecognizeSpeechAsync();
        }
        private void t_Tick(object sender, EventArgs e)
        {
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;
            string time = "";

            if (hh < 10)
            {
                time += "0" + hh;
            }
            else
            {
                time += hh;
            }
            time += ":";
            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }
            time += ":";
            if (ss < 10)
            {
                time += "0" + ss;
            }
            else
            {
                time += ss;

            }
            Ceas.Text = time;
        }



        const string APPID = "b6907d289e10d714a6e88b30761fae22";
        string id = "665087";

        void vreme()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://openweathermap.org/data/2.5/weather?id={0}&appid={1}&units=metric&cnt=6", id, APPID);
                var json = web.DownloadString(url);
                var result = JsonConvert.DeserializeObject<infoVreme.root>(json);
                infoVreme.root outPut = result;
                Loc.Text = string.Format("{0}", outPut.name);
                Grade.Text = string.Format("{0} \u00B0", outPut.main.temp);
            }

        }

        void cast()
        {

            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://openweathermap.org/data/2.5/forecast/daily?id=665087&appid=b6907d289e10d714a6e88b30761fae22&units=metric&cnt=1", id, APPID);

                var json = web.DownloadString(url);
                var Object = JsonConvert.DeserializeObject<Forecast>(json);

                Forecast ceva = Object;

                Prognoza.Text = string.Format("{0}", ceva.list[1].weather[0].main);
                Viteza.Text = string.Format("{0} km/h ", ceva.list[1].speed);
                Procente.Text = string.Format("{0} %", ceva.list[1].humidity);
                minima.Text = string.Format("{0} \u00b0", ceva.list[1].temp.min);
                maxima.Text = string.Format("{0} \u00B0", ceva.list[1].temp.max);
                Graden.Text = string.Format("{0} \u00B0", ceva.list[1].temp.night);
                Soare.Image = setIcon(ceva.list[1].weather[0].icon);

                DateTime dateTime = DateTime.UtcNow.Date;
                string zi = DateTime.Now.ToString("dd");
                string luna = DateTime.Now.ToString("MM");
                int exact = System.Convert.ToInt32(luna);
                string luna1 = " ";
                if (exact == 1)
                {
                    luna1 = "Ianuarie";
                }
                CultureInfo.CurrentCulture = new CultureInfo("ro-RO");
                luna1 = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(exact);
                string luna2 = " ";
                luna2 = luna1.ToUpper();
                string an = DateTime.Now.ToString("yyyy");
                Data.Text = zi + " " + luna2 + " " + an;

            }
        }

        Image setIcon(string iconID)
        {
            string url = string.Format("http://openweathermap.org/img/w/{0}.png", iconID); // weather icon resource 
            var request = WebRequest.Create(url);
            using (var response = request.GetResponse())
            using (var weatherIcon = response.GetResponseStream())
            {
                Image Soare = Bitmap.FromStream(weatherIcon);
                return Soare;
            }
        }
        public static string NormalizeStringForUrl(string name)
        {
            String normalizedString = name.Normalize(NormalizationForm.FormD);
            StringBuilder stringBuilder = new StringBuilder();

            foreach (char c in normalizedString)
            {
                switch (CharUnicodeInfo.GetUnicodeCategory(c))
                {
                    case UnicodeCategory.LowercaseLetter:
                    case UnicodeCategory.UppercaseLetter:
                    case UnicodeCategory.DecimalDigitNumber:
                        stringBuilder.Append(c);
                        break;
                    case UnicodeCategory.SpaceSeparator:
                    case UnicodeCategory.ConnectorPunctuation:
                    case UnicodeCategory.DashPunctuation:
                        stringBuilder.Append(' ');
                        break;
                }
            }
            string result = stringBuilder.ToString();
            return String.Join("_", result.Split(new char[] { '_' }
                , StringSplitOptions.RemoveEmptyEntries)); // remove duplicate underscores
        }
        void calendars()
        {

            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://www.googleapis.com/calendar/v3/calendars/i9m2gphpc0lkr8nvpc0igdlvso%40group.calendar.google.com/events/?key=AIzaSyAPnlSq4prI7DunyVY4WEGshzqhySeumdc");
                var json = web.DownloadString(url);
                var Object = JsonConvert.DeserializeObject<calendar>(json);
                int B = 10;

                calendar eveniment = Object;
                int n = eveniment.items.Count;
                for (int i = 0; i < n; i++)
                {
                    Label new1 = new Label();
                    new1.ForeColor = System.Drawing.Color.AntiqueWhite;
                    new1.BackColor = System.Drawing.Color.Transparent;
                    B = B + 60;
                    new1.Top = 40 + B;
                    new1.Left = 1150;
                    new1.Text = string.Format("{0}", eveniment.items[i].summary);
                    new1.Font = new Font("Century Gothic", 17, FontStyle.Regular);
                    new1.AutoSize = true;
                    new1.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
                    Label new2 = new Label();
                    new2.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
                    new2.BackColor = System.Drawing.Color.Transparent;
                    new2.ForeColor = System.Drawing.Color.AntiqueWhite;
                    B = B + 60;
                    new2.Top = 20 + B;
                    new2.Left = 1150;
                    string[] locatie = eveniment.items[i].location.Split(',');
                    new2.Text = string.Format("{0}", NormalizeStringForUrl(locatie[0]));
                    new2.Font = new Font("Century Gothic", 12, FontStyle.Regular);
                    new2.MaximumSize = new Size(240, 0);
                    new2.AutoSize = true;
                    new2.Width = 120;
                    Label new3 = new Label();
                    new3.BackColor = System.Drawing.Color.Transparent;
                    new3.ForeColor = System.Drawing.Color.AntiqueWhite;
                    new3.Top = new2.Bottom + 20;
                    new3.Left = 1150;
                    new3.Text = string.Format("{0}", eveniment.items[i].start.dateTime.Split('T'));
                    new3.Font = new Font("Century Gothic", 14, FontStyle.Regular);
                    new3.AutoSize = true;
                    new3.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
                    Label new4 = new Label();
                    new4.ForeColor = System.Drawing.Color.AntiqueWhite;
                    new4.BackColor = System.Drawing.Color.Transparent;

                    new4.Top = new3.Bottom + 20;
                    new4.Left = 1150;
                    string[] timp = eveniment.items[i].start.dateTime.Split('T');
                    new4.Text = string.Format("{0}", timp[1].Split('+'));
                    new4.Font = new Font("Century Gothic", 14, FontStyle.Regular);
                    new4.AutoSize = true;
                    new4.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
                    this.Controls.Add(new1);
                    this.Controls.Add(new2);
                    this.Controls.Add(new3);
                    this.Controls.Add(new4);

                }

            }
        }

    }
}

