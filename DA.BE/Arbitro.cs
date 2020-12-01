﻿using System;
using System.Collections.Generic;

namespace DA.BE
{
    [Tabla("Arbitro")]
    public class Arbitro : EntidadBase, IComparable<Arbitro>
    {

        public string Nombre
        {
            [Columna("Nombre", "Nombre", typeof(string), false, false)]
            get;
            set;
        }

        public string Apellido
        {
            [Columna("Apellido", "Apellido", typeof(string), false, false)]
            get;
            set;
        }

        public DateTime FechaNacimiento
        {
            [Columna("FechaNacimiento", "FechaNacimiento", typeof(string), false, false)]
            get;
            set;
        }

        public string Genero
        {
            [Columna("Genero", "Genero", typeof(string), false, false)]
            get;
            set;
        }

        public string DNI
        {
            [Columna("Dni", "DNI", typeof(string), false, false)]
            get;
            set;
        }

        public int Ranking
        {
            [Columna("Ranking", "Ranking", typeof(int), false, false)]
            get;
            set;
        }

        public int AniosExperiencia
        {
            [Columna("AniosExperiencia", "AniosExperiencia", typeof(int), false, false)]
            get;
            set;
        }

        public int NotaAFA
        {
            [Columna("NotaAFA", "NotaAFA", typeof(int), false, false)]
            get;
            set;
        }

        public Nivel Nivel
        {
            [Columna("IdNivel", "Nivel", typeof(int), false, false)]
            get;
            set;
        }

        public Deporte Deporte
        {
            [Columna("IdDeporte", "Deporte", typeof(int), false, false)]
            get;
            set;
        }

        public bool? Estado
        {
            [Columna("Estado", "Estado", typeof(bool?), false, false)]
            get;
            set;
        }

        public bool? TituloValidoArgentina
        {
            [Columna("TituloValidoArgentina", "TituloValidoArgentina", typeof(bool?), false, false)]
            get;
            set;
        }

        public bool? LicenciaInternacional
        {
            [Columna("LicenciaInternacional", "LicenciaInternacional", typeof(bool?), false, false)]
            get;
            set;
        }

        public bool? ExamenFisico
        {
            [Columna("ExamenFisico", "ExamenFisico", typeof(bool?), false, false)]
            get;
            set;
        }
        public bool? ExamenTeorico
        {
            [Columna("ExamenTeorico", "ExamenTeorico", typeof(bool?), false, false)]
            get;
            set;
        }

        public string NombreCompleto => Nombre + " " + Apellido;

        public string NombreCompletoTipoArbitro { get; set; }
        
        public Queue<Equipo> UltimosEquiposDirigidos { get; set; }

        public Queue<Partido> UltimosPartidosDirigidos { get; set; }


        public Arbitro() {
            this.UltimosPartidosDirigidos = new Queue<Partido>();
            this.UltimosEquiposDirigidos = new Queue<Equipo>();
        }

          /// <summary>
        /// Compare two Referees by priority. There are not exist two iquals referees.
        /// </summary>
        /// <param name="otroArbitro">The other referee.</param>
        /// <returns></returns>
        public int CompareTo(BE.Arbitro otroArbitro)
        {
            if (this.Ranking > otroArbitro.Ranking)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }


        //{
        //    BE.Arbitro arbitro;
        //    if (obj != null)
        //    {
        //        arbitro = (BE.Arbitro) obj;
        //    }
        //    else
        //    {
        //        arbitro = null;
        //    }

        //    return arbitro != null && this.Id == arbitro.Id;
        //}

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. 
        /// </returns>
        public override int GetHashCode()
        {

            return Id;
        }

        /// <summary>
        /// Implements the operator ==.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>
        /// The result of the operator.
        /// </returns>
        public static bool operator ==(BE.Arbitro left, BE.Arbitro right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implements the operator !=.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>
        /// The result of the operator.
        /// </returns>
        public static bool operator !=(BE.Arbitro left, BE.Arbitro right)
        {
            return !Equals(left, right);
        }

    }
}