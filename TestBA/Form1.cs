using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;


namespace TestBA
{
    public partial class Form1 : Form
    {
        private int _ticks;
        int score;
        
    
    
        public Form1()
        {
           
            InitializeComponent();
            movetostart(); // Bewegen zum starten
            MessageBox.Show("Anleitung: Sammle alle schwarzen Blöcke ein!. Gehe anschließend zum Ziel. Du hast 15 Sekunden Zeit. Drücke Enter um zu beginnen. "); // Spiel Einleitung verschönert das spiel
            Zeit.Start(); // Unten finden wir den Zeit Code. Hier wird angegeben, dass wenn man anfängt die Zeit startet.
            random = new Random();
        }

        private void Finish_MouseEnter(object sender, EventArgs e) // "Finish_MouseEnter" ist hier auch wichtig. Dieser Befehlt sagt aus, dass wenn man dort angekommen ist.
        {
            ///int score = 0; // Noch in bearbeitung.
            ///score = 0;
            ///scoreMax = 7;
                
            // Sich ein Fenster öffnet mit der Beschriftung ("Du hast das Ziel erreicht :)") 
            Zeit.Stop();
            MessageBox.Show("Du bist am Ziel angelangt! Super :). Deine Sekunden :  " + _ticks  ); // Hier steht, dass wenn angekommen ist dort ein Fenster erscheint. Dieses Fenster sagt dann wie viele Sekunden du gebraucht hast.
            
        }

        private void wall_MouseEnter(object sender, EventArgs e) // Das wichtige ist "wall_MouseEnter". Der sagt, dass wenn man einen Balken berührt wieder von vorne anfängt.
        {                                                        // Deshalb auch "movetostart". Wird unter dem befehl definiert (Lesen).
            movetostart();
            // Dieser befehl gibt aus, dass wenn man einen Balken berührt wieder zu den Koordinaten springt (wird zurückgesetz).
            
            
        }

        private void movetostart()
        {
            Point startingpoint = panel1.Location; // Hier wird ausgegeben wo genau der Spieler starten soll.
            startingpoint.Offset(10, 10);          // Die Koordinaten sind sehr wichtig. In dem Fall (10, 10).
            Cursor.Position = PointToScreen(startingpoint); // Der Befehl heisst, dass man einfach den Mauszeiger bewegen soll wenn man starten möchte.


        }

        
        private void OnTimedEvent(object sender, System.Timers.ElapsedEventArgs e)
        {
            throw new NotImplementedException();
        }
        private void myBouton0_MouseEnter(object sender, EventArgs e)
        {
            label18.Hide(); // Hier steht der Befehl, dass der Mauszeiger die Labels aufessen kann.
                            // Man muss ein extra MouseEnter erstellen und den Befehl dort eingeben.
            addScore = addScore + 1;
            
        }

       private void myBouton_MouseEnter(object sender, EventArgs e)
            
        {
            label25.Hide(); // Hier ist das gleiche wie bei Label18. Wenn man z.B schreibt : labelx.Hide(); steht, dass .Hide dafür dass man es aufsaugen kann.
            
        }

        private void myBouton2_MouseEnter(object sender, EventArgs e)
        {
            label23.Hide(); // Hier ist das gleiche wie bei Label18.
            
        }

        private void myBouton3_MouseEnter(object sender, EventArgs e)
        {
            label19.Hide(); // Hier ist das gleiche wie bei Label18.
            
        }

        private void myBouton4_MouseEnter(object sender, EventArgs e)
        {
            label20.Hide(); // Hier ist das gleiche wie bei Label18.
            
        }

        private void myBouton5_MouseEnter(object sender, EventArgs e)
        {
            label21.Hide(); // Hier ist das gleiche wie bei Label18.
            
        }

        private void myBouton6_MouseEnter(object sender, EventArgs e)
        {
            label24.Hide(); // Hier ist das gleiche wie bei Label18.
            
        }
        
        public int addScore = 0;
        public int startingScore = 0;
        private void Score_pctBox_Click(object sender, EventArgs e)
        {
            startingScore = 0;
            int score = 0;  // Bei dem Score muss ich noch überlegen was man dort machen kann.
            score = 0;
            scoreMax = 7;
            addScore = addScore = 1;
            
            if (score > 0) // Bei dem Befehl hab ich geschrieben, dass eine MessageBox auftauchen soll wenn der Score über 0 liegt.
            {
                MessageBox.Show("Gut gemacht. Dein Score ist: " + score); // <--- Da steht was die MessageBox ausgeben soll.
                
            }
            else if (score < 0) // Hier genau so
            {
                MessageBox.Show("Dein Score ist zu klein!");
                Close();
            }
           
        }

        private void AddScore()
        {
            
            
        }
        
        private void timer1_Tick_1(object sender, EventArgs e) // Hier habe ich eine Stoppuhr eingebaut. 
        {
            _ticks++; // Das "++" heisst, dass es sich um 1 erhöhen soll.
            this.Text = _ticks.ToString();

            if (_ticks == 15) // Hinter dem "==" kann man die Sekunden eingeben. Je nach dem wie viel Sekunden man möchte.
            {
                this.Text = "Done"; // Das "Done" taucht auf, wenn die Zeit oben Links in der Ecke abgelaufen ist.
                Zeit.Stop(); // Wenn die Zeit abgelaufen ist, will man ja auch, dass die Zeit stoppt. Genau das hab ich hier gmacht
                MessageBox.Show("Du hast leider die Zeit überschritten. Game over ! Dein Score ist : " + score); // Wenn man wirklich die Zeit überschritten hat taucht die Nachricht auf.
                Close();

            }
        }
           public int scoreMax { get; set; } // Hier wurde die Definition für scoreMax in dem Score Code ausgegeben.

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NeuStart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        private bool paused = false;
        private bool pauseKeyDown = false;
        private bool pausedForGuide = false;
        private bool UserInitiated;
        private void button5_Click(object sender, EventArgs e)
        {
            Zeit.Stop();
            paused = true;
            pausedForGuide = !UserInitiated;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Zeit.Start();
            Form1.Start();
        }

        private static void Start()
        {
            
        }
        
        public object klick { get; set; }



        public Random random { get; set; }
    }
        
        }
