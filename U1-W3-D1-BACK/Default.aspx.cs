using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace U1_W3_D1_BACK
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Prenotazione_Click(object sender, EventArgs e)
        {
            int sala = Convert.ToInt32(DropDownList1.SelectedValue);
            if (sala == 1)
            {
                ArchiviaPrenotazione("SALA NORD");
            }
            else if (sala == 2)
            {
                ArchiviaPrenotazione("SALA EST");
            }
            else if (sala == 3)
            {
                ArchiviaPrenotazione("SALA SUD");
            }
            
        }

        public void ArchiviaPrenotazione(string Sala)
        {
            Prenotazione PrenotazioneEffettuata = new Prenotazione();
            PrenotazioneEffettuata.Nome = Nome.Text;
            PrenotazioneEffettuata.Cognome = Cognome.Text;
            PrenotazioneEffettuata.Riduzione = CheckBox1.Checked;
            PrenotazioneEffettuata.SalaCinema = Sala;
            if (PrenotazioneEffettuata.Riduzione == true)
            {
                PrenotazioneEffettuata.Incasso = 5;
            }
            else
            {
                PrenotazioneEffettuata.Incasso = 10;
            }

            Prenotazione.ListaPrenotazioni.Add(PrenotazioneEffettuata);

            ContaBiglietti();
        }
        public void ContaBiglietti()
        {
            int BigliettiNord = 0;
            int BigliettiEst = 0;
            int BigliettiSud = 0;
            int RidottiNord = 0;
            int RidottiEst = 0;
            int RidottiSud = 0;

            foreach(Prenotazione item in Prenotazione.ListaPrenotazioni)
            {
                if(item.SalaCinema == "SALA NORD")
                {
                    BigliettiNord += 1;
                    if(item.Riduzione == true)
                    {
                        RidottiNord += 1;
                    }
                }
                else if (item.SalaCinema == "SALA EST")
                {
                    BigliettiEst += 1;
                    if(item.Riduzione == true)
                    {
                        RidottiEst += 1;
                    }
                }
                else if (item.SalaCinema == "SALA SUD")
                {
                    BigliettiSud += 1;
                    if (item.Riduzione == true)
                    {
                        RidottiSud += 1;
                    }
                }
            }

            LabelNord.Text = Convert.ToString(BigliettiNord);
            RidottiNordLabel.Text = Convert.ToString(RidottiNord);
            LabelEst.Text = Convert.ToString(BigliettiEst);
            RidottiEstLabel.Text = Convert.ToString(RidottiEst);
            LabelSud.Text = Convert.ToString(BigliettiSud);
            RidottiSudLabel.Text = Convert.ToString(RidottiSud);
        }
    }
    public class Prenotazione
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public bool Riduzione { get; set; }
        public decimal Incasso { get; set; }
        public string SalaCinema { get; set; }
        public static List<Prenotazione> ListaPrenotazioni { get; set; } = new List<Prenotazione>();


    }

}  