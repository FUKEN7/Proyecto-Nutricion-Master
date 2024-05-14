using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public class ValidacionesPresentacion
    {
        public bool ValidacionEmail(string comprobarEmail)
        {
            string emailForm;
            emailForm = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";

            if (Regex.IsMatch(comprobarEmail, emailForm))
            {
                if (Regex.Replace(comprobarEmail, emailForm, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                return false;
            }
        }

        //validacion de rango
        public bool RangoCampos(TextBox textBox,string text,Label label,int num)
        {
            
            if (textBox.Text != text && textBox.Text != "")
            {
                if (textBox.Text.Length < num)
                {
                    label.Visible = true;
                    label.ForeColor = Color.Red;
                    label.Text = text+ " Rango mino "+num;
                    return false;
                }
                else
                {
                   label.Visible = false;
                   return true;
                }
            }
            label.Visible = false;
            return false;
        }


        //Validaciones por keyPress
        public string validacion(KeyPressEventArgs e, int tipo,Label label)
        {
            label.ForeColor= Color.Red;
            if (tipo == 1)
            {
                //solo permite numeros
                if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
                {
                    label.Text = "Solo numeros";
                    label.Visible = true;
                    e.Handled = true;
                    return "Solo numeros";
                }
            }
            if (tipo == 2)
            {
                //tipo 2 solo permite letras
                if ((e.KeyChar > 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
                {
                    label.Text = "Solo Letras";
                    label.Visible = true;
                    e.Handled = true;
                    return "Solo Letras";
                }
            }
            if (tipo == 3)
            {
                //decimales para tomar las comas 
                if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 58 && e.KeyChar <= 255) || (e.KeyChar <= 47 && e.KeyChar >= 45))
                {
                    label.Text = "Solo numeros y moda";
                    label.Visible = true;
                    e.Handled = true;
                    return "Solo numeros y moda";
                }
            }
            label.Visible = false;
            return "No hay validacion";
        }
    }
}
