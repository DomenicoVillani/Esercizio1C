using System.Xml.Linq;

namespace EsercizioC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Atleta atleta1 = new Atleta();
            atleta1.GetInfo();
            atleta1.Maggiorenne();
            atleta1.NumMedaglieMagg5();
            Dipendente dipendente1 = new Dipendente();
            dipendente1.GetInfo();
            dipendente1.Maggiorenne();
            dipendente1.PuoiAndareInPensione();
            Animale animale1 = new Animale();
            animale1.GetInfo();
            animale1.Cucciolo();
            animale1.DiColoreBlu();
            Veicolo veicolo1 = new Veicolo();
            veicolo1.GetInfo();
            veicolo1.DiColoreGiallo();
            veicolo1.Incidentata(); 
        }
    }

    public class Atleta{
        public string Name = "Abel";
        public string Sport = "Corsa delle sedie da ufficio";
        public int Age = 30;
        public string ColorChair = "Nero";
        public int MedaglieVinte = 6;

        public void GetInfo()
        {
            Console.WriteLine("Nome: " + Name + "; Eta': " + Age + "; Sport: " + Sport + "; Colore sedia: " + ColorChair);
        }
        
        public string Maggiorenne(){
            if(Age > 17)
            {
                return "si";
            }
            else
            {
                return "no";
            }
        }

        public string NumMedaglieMagg5(){
            if(MedaglieVinte > 5)
            {
                return "si";
            }
            else
            {
                return "no";
            }
        }
    }

    public class Dipendente{
        public string Name = "Pietro";
        public int Age = 69;
        public string NameAzienda = "Poesie e liberta' ";
        public string RuoloAzienda = "CEO";
        public int AnniEsperienza = 51;

        public void GetInfo(){
            Console.WriteLine("Nome: " + Name + "; Eta': " + Age + "; None Azienda: " + NameAzienda + "; Ruolo Azienda: " + RuoloAzienda);
        }
        public string Maggiorenne()
        {
            if (Age > 17)
            {
                return "si";
            }
            else
            {
                return "no";
            }
        }
        public void PuoiAndareInPensione()
        {
            if(AnniEsperienza > 60)
            {
                Console.WriteLine("Goditi la pensione! Hai " +AnniEsperienza+ " anni di sperienza");
            }
            else
            {
                Console.WriteLine("Torna a lavorare che sei giovane! Hai " + AnniEsperienza + " anni di sperienza");
            }
        }
    }

    public class Animale{
        public string Name = "Rex";
        public int Age = 1;
        public string Razza = "cane pastore tedesco";
        public string Color = "marrone-nero";

        public void GetInfo()
        {
            Console.WriteLine("Nome: " + Name + "; Eta': " + Age + "; Razza: " + Razza + "; Colore: " + Color);
        }

        public void Cucciolo()
        {
            if (Age < 2)
            {
                Console.WriteLine(Name+ " e' un cucciolo ha " +Age+ " anni");
            }
            else
            {
                Console.WriteLine(Name + " e' vecchio ha " +Age+ " anni");
            }
        }

        public void DiColoreBlu()
        {
            if (Color == "blu")
            {
                Console.WriteLine(Name + " e' di colore blu!");
            }
            else
            {
                Console.WriteLine(Name + " non e' di colore blu ma di colore: " + Color);
            }
        }
    }
    public class Veicolo{
        public string Modello = "Ferrari 458 italia";
        public int Age = 2;
        public string Color = "giallo";
        public int Km = 30000;
        public int NumIncidenti = 2;
        public string NomProp = "Marco";

        public void GetInfo()
        {
            Console.WriteLine("Nome proprietario: " + NomProp + "; Eta' macchina: " + Age + "; Modello: " + Modello + "; Colore: " + Color + "e ha " +Km+ " km");
        }
        public void DiColoreGiallo()
        {
            if (Color == "giallo")
            {
                Console.WriteLine("La tua macchina e' di colore Giallo!");
            }
            else
            {
                Console.WriteLine("La tua macchina non e' di colore giallo ma di colore: " + Color);
            }
        }

        public void Incidentata()
        {
            if (NumIncidenti == 0)
            {
                Console.WriteLine("La tua macchina non ha fatto alcun incidente!");
            }
            else if (NumIncidenti == 1)
            {
                Console.WriteLine("La tua macchina non ha fatto un solo incidente! staia ttento la prossima volta");
            }
            else
            {
                Console.WriteLine("La tua macchina ha fatto piu' di un incidente! ne ha fatti " +NumIncidenti+ " chi ti ha dato la patente?");
            }
        }
    }
}
