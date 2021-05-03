using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio19
{
    class MenuComida
    {
        private readonly double precioBurger = 35.00, precioPapas = 15.00, precioSoda = 12.00, precioPizza = 70.00, precioNugget = 25.00, precioSalad = 30.00, precioYogur = 15.00, precioAgua = 12.00;
        private int cantBurger = 0, cantPapas = 0, cantSoda = 0, cantPizza = 0, cantNugget = 0, cantSalad = 0, cantYogur = 0, cantAgua = 0, contMenuBurguer = 0, contMenuPizza = 0, contMenuSalad = 0;
        public int CantBurger { get => cantBurger; set => cantBurger = value; }
        public int CantPapas { get => cantPapas; set => cantPapas = value; }
        public int CantSoda { get => cantSoda; set => cantSoda = value; }
        public int CantPizza { get => cantPizza; set => cantPizza = value; }
        public int CantNugget { get => cantNugget; set => cantNugget = value; }
        public int CantSalad { get => cantSalad; set => cantSalad = value; }
        public int CantYogur { get => cantYogur; set => cantYogur = value; }
        public int CantAgua { get => cantAgua; set => cantAgua = value; }
        public int ContMenuBurguer { get => contMenuBurguer; set => contMenuBurguer = value; }
        public int ContMenuPizza { get => contMenuPizza; set => contMenuPizza = value; }
        public int ContMenuSalad { get => contMenuSalad; set => contMenuSalad = value; }
        public double PrecioBurger { get => precioBurger; }
        public double PrecioPapas { get => precioPapas; }
        public double PrecioSoda { get => precioSoda; }
        public double PrecioPizza { get => precioPizza; }
        public double PrecioNugget { get => precioNugget; }
        public double PrecioSalad { get => precioSalad; }
        public double PrecioYogur { get => precioYogur; }
        public double PrecioAgua { get => precioAgua; }
    }
}
