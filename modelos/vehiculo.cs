using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba12Nov.Models
{
  public class vehiculo
  {
    public double Capacidad {get; set;}

    public double LatitudOrigenCondicionInicial {get; set;}

    public double LongitudOrigenCondicionInicial {get; set;}

    public List<Demanda> ListaDemanda {get; set} = new List<Demanda>();
    
    public DateTime FechaDisponible {get; set;}
    }
  }
