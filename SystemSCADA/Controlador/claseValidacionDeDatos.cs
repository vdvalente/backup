using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemSCADA.Controlador
{
    class claseValidacionDeDatos
    {
        /*****************************************************************************************************************************************************
        Nombre del Creador:Juan Sanchez
        Fecha de Creacion: septiembre del 2018
        Descripcion: Procedimiento para validar un caracter... Si se desea agregar un rango continuo de caracteres para un caso solo se tiene que especificar con un
        O(||) adentro del rango y un Y(&&) afuera del rango. Ejemplo: ...&& (e.KeyChar < 44 || e.KeyChar > 46) &&... Ahora si se desea que solo se acepte un caracter 
        en especifico, se tiene que agregar el caracter que se desea que acepte con una condicion de distinto. Ejemplo:  ...&& e.KeyChar != 8 &&... 
        *****************************************************************************************************************************************************/
        public static void ValidacionDeCaracter( KeyPressEventArgs e, int Caso)
        {
            switch(Caso)
            {
                case 0:
                    // Caso 0: Solo se acepta letras, numeros, espacio,  retroceso, retorno de carro y .,-
                    if ((e.KeyChar < 44 || e.KeyChar > 46) && (e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar < 65 || e.KeyChar > 90) && (e.KeyChar < 97 || e.KeyChar > 122) && e.KeyChar != 8 && e.KeyChar != 32 && e.KeyChar != 13)
                    {
                        System.Media.SystemSounds.Beep.Play();
                        e.Handled = true;
                    }
                    break;
                case 1:
                    // Caso 1: Solo se acepta letras, numeros, retroceso, retorno de carro
                    if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar < 65 || e.KeyChar > 90) && (e.KeyChar < 97 || e.KeyChar > 122) && e.KeyChar != 8 && e.KeyChar != 13)
                    {
                        System.Media.SystemSounds.Beep.Play();
                        e.Handled = true;
                    }
                    break;
                case 2:
                    // Caso 2: Solo se acepta letras, numeros, retroceso, retorno de carro
                    if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar < 65 || e.KeyChar > 90) && (e.KeyChar < 97 || e.KeyChar > 122) && e.KeyChar != 8 && e.KeyChar != 13)
                    {
                        System.Media.SystemSounds.Beep.Play();
                        e.Handled = true;
                    }
                    break;
                case 3:
                    // Caso 3: Solo se acepta numeros, retroceso, retorno de carro
                    if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 13)
                    {
                        System.Media.SystemSounds.Beep.Play();
                        e.Handled = true;
                    }
                    break;
                case 4:
                    // Caso 4: Acepta todos los caracteres de control y caractres ascii imprimibles
                    if (e.KeyChar < 1 || e.KeyChar > 127)
                    {
                        System.Media.SystemSounds.Beep.Play();
                        e.Handled = true;
                    }
                    break;
                case 5:
                    // Caso 5: Solo se acepta letras, numeros, espacio,  retroceso, retorno de carro y -
                    if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar < 65 || e.KeyChar > 90) && (e.KeyChar < 97 || e.KeyChar > 122) && e.KeyChar != 8 && e.KeyChar != 32 && e.KeyChar != 13 && e.KeyChar != 45)
                    {
                        System.Media.SystemSounds.Beep.Play();
                        e.Handled = true;
                    }
                    break;
                case 6:
                    // Caso 6: Solo se acepta letras, espacio,  retroceso, retorno de carro
                    if ((e.KeyChar < 65 || e.KeyChar > 90) && (e.KeyChar < 97 || e.KeyChar > 122) && e.KeyChar != 8 && e.KeyChar != 32 && e.KeyChar != 13)
                    {
                        System.Media.SystemSounds.Beep.Play();
                        e.Handled = true;
                    }
                    break;
                case 7:
                    // Caso 7: Solo se acepta letras, numeros, retroceso, retorno de carro y !#$%&'*+-./=?@^_{|}~
                    // Caracteres validos para un correo
                    if ((e.KeyChar < 35 || e.KeyChar > 57) && (e.KeyChar < 64 || e.KeyChar > 90) && (e.KeyChar < 97 || e.KeyChar > 126) && e.KeyChar != 8 && e.KeyChar != 13 && e.KeyChar != 33 && e.KeyChar != 61 && e.KeyChar != 63 && e.KeyChar != 94 && e.KeyChar != 95)
                    {
                        System.Media.SystemSounds.Beep.Play();
                        e.Handled = true;
                    }
                    break;
                case 8:
                    // Caso 8: Solo se acepta numeros, retroceso, retorno de carro, (.,), (+-) 
                    // Caracteres validos para una IP
                    if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 13 && e.KeyChar != 46 && e.KeyChar != 43 && e.KeyChar != 44 && e.KeyChar != 45)
                    {
                        System.Media.SystemSounds.Beep.Play();
                        e.Handled = true;
                    }
                    break;
            }
        }
    }
}
