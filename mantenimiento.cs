using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemploclases_proj_2_parcial2
{
    public class mantenimiento
    {
        //Insertar
        private String nombre;
        private int edad;
        private DateTime fechainicio;
        private double salario;
        private double salarioaumento;
        private DateTime fechaaumento;

        // Insertar
        public String Nombre { get; set; }
        public int Edad { get; set; }
        public DateTime FechaInicio { get; set; }
        public double Salario { get; set;}
        public double Salarioaumento { get;set; }
        public DateTime FechaAumento { get; set; }

                             // todo lo que vamos a enviar                                                   //donde lo vamos a enviar
        public void insertar(String nombre, int edad, DateTime fechainicio, double salario, double aumento, DataGridView data, int fila ) //metodo
        {
            data.Rows[fila].Cells[0].Value = nombre;
            data.Rows[fila].Cells[1].Value = edad;
            data.Rows[fila].Cells[2].Value = fechainicio.ToShortDateString();
            data.Rows[fila].Cells[3].Value = salario;
            data.Rows[fila].Cells[4].Value = salario + aumento;
            data.Rows[fila].Cells[5].Value = FechaAumento.ToShortDateString();

        }

         








    }
}
