using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio17B
{
    class Triangulo
    {
        private int ladoLibre, ladoBase, lado3, altura;

        public int LadoLibre { get => ladoLibre; set => ladoLibre = value; }
        public int LadoBase { get => ladoBase; set => ladoBase = value; }
        public int Lado3 { get => lado3; set => lado3 = value; }
        public int Altura { get => altura; set => altura = value; }

        public void crear() {
            lado3 = (int)Math.Sqrt((altura * altura) + (LadoBase / 2) * (ladoBase / 2));
            mostrar(ladoLibre, ladoBase, lado3);
        }
        public void Area() {
            int res;
            res = (altura * ladoBase) / 2;
            MessageBox.Show("El area es: " + res, "AREA");
        }
        public void EsEquilatero() {
            if (ladoLibre == ladoBase && ladoBase == lado3)
            {
                MessageBox.Show("El triangulo es equilatero.", "Enhorabuena");
            }
            else
            {
                MessageBox.Show("El triangulo no es equilatero.", "jopelines");
            }
        }
        public void LadoMayor() {
            if (ladoLibre >= ladoBase && ladoLibre >= lado3) {
                MessageBox.Show("El lado mas largo es: " + Convert.ToString(ladoLibre), "Lado mas largo");
            }
            if (ladoBase >= ladoLibre && ladoBase >= lado3)
            {
                MessageBox.Show("El lado mas largo es: " + Convert.ToString(ladoBase), "Lado mas largo");
            }
            if (lado3 >= ladoBase && lado3 >= ladoLibre)
            {
                MessageBox.Show("El lado mas largo es: " + Convert.ToString(lado3), "Lado mas largo");
            }

        }
        public void mostrar(int a, int b, int c)
        {
            MessageBox.Show("Se ha generado un triangulo cuyo: \nLado 1 es: " + a + "\n Lado 2 es: " + b + "\nLado 3: " + c, "Comprobacion");
        }

        public Triangulo() { }
    }
}
