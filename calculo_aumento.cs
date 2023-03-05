using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;// libreria para poder tener acceso a los toodos elementos del formulario

namespace ejemploclases_proj_2_parcial2
{
    //internal class
    public class calculo_aumento
    {
        double salario_aumento = 0;//variable global
        private int fecha; //variables o atributos privados dentro de esta clase 
        private double pago; //

        // las variables public son para usar en otros forms. Aparecen como una propiedad
        public int Fecha { get; set; } //atributos. // estas variables son para que se puedan usar en cualquier formulario
                                       // se tienen que escribir de manera que se diferencie una de la otra (variables Private)
                                       // 
       // refactorizacion de los atributos privados
        public double Pago { get; set; } //(get) obtiene los datos que le enviemos // (set) para poder hacer calculos 
                                         // (get)(set) para que Fecha y Pago se preste para poder obtener y evaluar





                            //(es lo que ocupa retornar)
        public double calculo(int año, double salario) //metodo
        {   
                              
            int cantidad_años = DateTime.Today.Year - año;// con esto saco el año actual - el año que le envio atraves del metodo

            if (cantidad_años <= 5)
            {
                salario_aumento = salario * 5 / 100;
            }

            if (cantidad_años > 5 && cantidad_años <=12)
            {
                salario_aumento = salario * 7 / 100;
            }

            if (cantidad_años > 12)
            {
                salario_aumento = salario * 10 / 100;
            }

            return salario_aumento; //requisito del metodo. Regresa un valor para poderlo asiganr a un text box
    
        
        }
                                    // le pedimos una varibale form osea todo un formulario
        public void habilitar_botones(Form frm) // (From frm) llama a todo el formulario . (Form) solo es para hacer la accion pero no retorna nada
        {

            Button btnAgregar = frm.Controls.OfType<Button>().FirstOrDefault(a => a.Name == "btnagregar"); // para habilitar el boton despues de calcular

            btnAgregar.Enabled = true;

            Button btnModificar = frm.Controls.OfType<Button>().FirstOrDefault(b => b.Name == "btnmodificar"); // para habilitar el boton despues de calcular

            btnModificar.Enabled = true;

        }
        














    }

}
