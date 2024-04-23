namespace Uwagi
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCzyscClicked(object sender, EventArgs e)
        {
            inputTekst.Text= string.Empty;
            lblPozytywne.Text = "X";
            lblNegatywne.Text = "X";
        }
        private void OnSzukajClicked(object sender, EventArgs e)
        {
            string tekst = inputTekst.Text;
            string neg = "Uwaga negatywna";
            string poz = "Uwaga pozytywna";
            int pozL = 0; int negL = 0;
            while (tekst.Contains(neg)||tekst.Contains(poz))
            {
                if (true)
                {
                    if (tekst.Contains(neg) && tekst.Contains(poz))
                    {
                        if (tekst.IndexOf(neg) < tekst.IndexOf(poz))
                        {
                            negL++;
                            tekst = tekst.Remove(0, tekst.IndexOf(neg) + neg.Length - 1);
                        }
                        else
                        {
                            pozL++;
                            tekst = tekst.Remove(0, tekst.IndexOf(poz) + poz.Length - 1);
                        }
                    }
                    else if (tekst.Contains(neg))
                    {
                        negL++;
                        tekst = tekst.Remove(0, tekst.IndexOf(neg)+neg.Length-1);
                    }
                    else if (tekst.Contains(poz))
                    {
                        pozL++;
                        tekst = tekst.Remove(0, tekst.IndexOf(poz)+poz.Length-1);
                    }
                    
                }
            }
            lblPozytywne.Text=pozL.ToString();
            lblNegatywne.Text=negL.ToString();
        }

    }
}
