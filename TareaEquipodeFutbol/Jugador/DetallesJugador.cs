using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaEquipodeFutbol.Jugador
{
    public class DetallesJugador : DatosPersonalesJugador
    
    {
        //public DetallesJugador(double Estatura, double Peso, string GrupoSanguineo,
        //   string Alergico, string EnfermedadCondicion, string Lesiones, string Lateralidad, string PosicionCampo)
        //{
        //    this.Estatura = Estatura;
        //    this.Peso = Peso;
        //    this.GrupoSanguineo = GrupoSanguineo;
        //    this.Alergico = Alergico;
        //    this.EnfermedadCondicion = EnfermedadCondicion;
        //    this.Lesiones = Lesiones;
        //    this.Lateralidad = Lateralidad;
        //    this.PosicionCampo = PosicionCampo;
        //}
        public double Estatura { get; set; }
        
        public double Peso { get; set; }

        public string GrupoSanguineo { get; set; }

        public string Alergico { get; set; }

        public string EnfermedadCondicion { get; set; }

        public string Lesiones { get; set; }

        public string Lateralidad { get; set; }

        public string PosicionCampo { get; set; }

       
    }
}
