﻿/*
 * Created by SharpDevelop.
 * User: rodrix
 * Date: 4/20/2022
 * Time: 2:12 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Tienda
{
	/// <summary>
	/// Description of Persona.
	/// </summary>
	public class Persona
	{
		private string nombre,paterno,materno;
		private int ci;
		private string fechanac;
		
		public Persona(string nom,string pat, string mat, int c, string nac)
		{
			nombre = nom; paterno = pat; materno = mat;
			ci = c; fechanac  = nac;
		}
		
		public Persona(){
			nombre = paterno = materno = "-1";
			ci = -1; fechanac = "00/00/0000";
		}
		
		//sobrecarga del metodo toString, para obtener los datos mas rapido
		public override string ToString()
		{
			return string.Format(" Nombre={0}, Paterno={1}, Materno={2}, Ci={3}, Fechanac={4}]", nombre, paterno, materno, ci, fechanac);
		}

		
		//getters y setters
		public string Nombre {
			get { return nombre; }
			set { nombre = value; }
		}

		public string Paterno {
			get { return paterno; }
			set { paterno = value; }
		}

		public string Materno {
			get { return materno; }
			set { materno = value; }
		}

		public int Ci {
			get { return ci; }
			set { ci = value; }
		}

		public string Fechanac {
			get { return fechanac; }
			set { fechanac = value; }
		}
	}
}
