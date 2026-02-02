using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WinFormsApp1
{
    public static class Admin
    {
        public static void SaveBook(string zapis)
        {
            StreamWriter sw = new StreamWriter("knjige.txt", true);
            sw.WriteLine(zapis);
            sw.Close();

        }
        public static List<string> SearchByTitleOrAuthor(string kriterij)
        {
            List<string> knjige = new List<string>();
            if (File.Exists("knjige.txt"))
            {
                StreamReader sr = new StreamReader("knjige.txt");
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] dijelovi = line.Split(',');
                    if (string.Equals(dijelovi[0], kriterij) == true || string.Equals(dijelovi[1], kriterij) == true)
                    {
                        knjige.Add(line);
                    }
                }
                sr.Close();
            }
            return knjige;
        }
        public static List<string> GetAllAsStrings()
        {
            List<string> knjige = new List<string>();
            if (File.Exists("knjige.txt"))
            {
                StreamReader sr = new StreamReader("knjige.txt");
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    knjige.Add(line);
                }
                sr.Close();
            }
            return knjige;
        }
        public static List<string> GetCountByGenre()
        {
            List<string> zanrovi = new List<string>();
            int zf = 0, ljub = 0, akc = 0, pust = 0;
            if (File.Exists("knjige.txt"))
            {

                StreamReader sr = new StreamReader("knjige.txt");
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] dijelovi = line.Split(',');
                    string zanr = dijelovi[5].Trim();
                    if (zanr == "Znanstvena fantastika")
                    {
                        zf++;
                    }
                    else if (zanr == "Ljubavni")
                    {
                        ljub++;
                    }
                    else if (zanr == "Akcijski")
                    {
                        akc++;
                    }
                    else if (zanr == "Pustolovni")
                    {
                        pust++;
                    }
                }

            }
            ljub.ToString();
            akc.ToString();
            pust.ToString();
            zf.ToString();

            zanrovi.Add("Znanstvena fantastika: " + zf);
            zanrovi.Add("Ljubavni: " + ljub);
            zanrovi.Add("Akcijski: " + akc);
            zanrovi.Add("Pustolovni: " + pust);


            return zanrovi;
        }
    }

}

