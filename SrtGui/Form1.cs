namespace SrtGui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            char[] alphabetSentence;
            double[] alphabetcounter;
            try
            {
                alphabetSentence = Logic.MakeAlphabetSentence(this.txtSentence.Text);
                alphabetcounter = Logic.MakeAlphabetCounter(this.txtSentence.Text, alphabetSentence);
            }
            catch(FormatException)
            {
                MessageBox.Show("Введи сначала че то а потом уже нажимай");
                return;
            }
            string fullText = "";
            for (int i = 0; i < alphabetSentence.Length; i++)
            {
                fullText = fullText + (alphabetSentence[i] + " " + alphabetcounter[i] + "%" ) + '\n';
            }
            MessageBox.Show(fullText);
        }
        public class Logic
        {
            public static char[] MakeAlphabetSentence(string sentence)
            {
                sentence = sentence.Replace(" ", "");
                char[] alphabetSentence = new char[sentence.Length];
                for (int i = 0; i < sentence.Length; i++)
                {
                    alphabetSentence[i] = sentence[i];
                }
                alphabetSentence = alphabetSentence.Distinct().ToArray();
                return alphabetSentence;
            }
            public static double[] MakeAlphabetCounter(string sentence, char[] alphabetSentence)
            {
                double[] alphabetcounter = new double[alphabetSentence.Length];
                for (int i = 0; i < alphabetSentence.Length; i++)
                {
                    alphabetcounter[i] = sentence.Count(c => c == alphabetSentence[i]) * 100.0 / sentence.Replace(" ", "").Length;
                }
                return alphabetcounter;
            }
        }
    }
}
