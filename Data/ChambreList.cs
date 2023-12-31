using GestionHotel.Models;
using Microsoft.AspNetCore.Mvc;
namespace GestionHotel.Data
{
    public class ChambreList
    {
        private static List<Chambre> Chambres = new List<Chambre>
        {
            new Chambre{Numero=1,Type="Simple", NumeroEtage=1,DateDebut=new DateTime(2023,12,12) },
            new Chambre{Numero=2,Type="Simple", NumeroEtage=2,DateDebut=new DateTime(2023,12,12) },
            new Chambre{Numero=3,Type="Simple", NumeroEtage=1,DateDebut=new DateTime(2023,12,12) },
            new Chambre{Numero=4,Type="Simple", NumeroEtage=2,DateDebut=new DateTime(2023,12,12) },

            new Chambre{Numero=1,Type="Simple", NumeroEtage=2,DateDebut=new DateTime(2023,12,12) },
            new Chambre{Numero=2,Type="Simple", NumeroEtage=2,DateDebut=new DateTime(2023,12,12) },
            new Chambre{Numero=3,Type="Simple", NumeroEtage=1,DateDebut=new DateTime(2023,12,12) },
            new Chambre{Numero=4,Type="Simple", NumeroEtage=2,DateDebut=new DateTime(2023,12,12) }

        };


        public static List<Chambre> GetChambres() 
        { 
            return Chambres; 
        }
    }
}
