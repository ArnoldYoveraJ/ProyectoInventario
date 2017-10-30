using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CapaPresentacion
{
    public class Validar
    {
        public void Letras(KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar)) //Al pulsar una letra
            {
                e.Handled = false; //Se acepta (todo OK)
            }
            else if (Char.IsControl(e.KeyChar)) //Al pulsar teclas como Borrar y eso.
            {
                e.Handled = false; //Se acepta (todo OK)
            }
            else if(char.IsSeparator(e.KeyChar))//Para todo lo demas
            {
                e.Handled = false; //Se acepta (todo OK)

            }else{
                e.Handled = true; //No se acepta (si pulsas cualquier otra cosa pues no se envia)
                MessageBox.Show("No se aceptan números");
            }            
        }

        public void Numeros(KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar)) //Al pulsar un número
            {
                e.Handled = false; //Se acepta (todo OK)
            }
            else if (Char.IsControl(e.KeyChar)) //Al pulsar teclas como Borrar y eso.
            {
                e.Handled = false; //Se acepta (todo OK)
            }
            else if (char.IsSeparator(e.KeyChar))//Para todo lo demas
            {
                e.Handled = false; //Se acepta (todo OK)

            }
            else
            {
                e.Handled = true; //No se acepta (si pulsas cualquier otra cosa pues no se envia)
                MessageBox.Show("No se aceptan Letras");
            }
        }
    }
}
