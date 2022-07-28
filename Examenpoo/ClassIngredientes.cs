using System;
using System.Collections.Generic;
using System.Text;

namespace Examenpoo
{
    public class ClassIngredientes: ClassHelado, Decorador
    {
        public string vainilla { get; set; }

        public int choco { get; set; }

        public int banano { get; set; }

    }
    public ClassIngredientes(string vainilla, string choco, double banano) : base (string helado, string Ingre) 
    {
        this.vainilla = vainilla;
        this.choco = choco;
        this.banano = banano;
    }
    public void Calcular()
    {
        int resultado = 0;
        Console.WriteLine("Ingrediente vainilla");
        Console.WriteLine("Ingrediente choco");
        Console.WriteLine("Ingrediente banano");
        resultado = vainilla + 1;

    }



}