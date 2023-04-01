using System;

namespace lab3
{   

    class Personaje
    {
        public string name;    
        public int nivel, salud, puntaje, dmg;
        

        public Personaje() { }
        public Personaje(string name,int nivel,int salud,int puntaje,int dmg)
        {
            name = this.name;
            nivel = this.nivel;
            salud = this.salud;
            puntaje = this.puntaje;
            dmg = this.dmg;
        }


        public override string ToString()
        {
            return name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int contplayers = 0;
            string auxstr;
            int auxniv, auxsal, auxpoint, auxdmg;
            int turnos = 0;
            int selector1, selector2, selector3;
            int contSalud1 = 0;
            int contSalud2 = 0;
            int contPntje1 = 0;
            int contPntje2 = 0;
          

            Console.WriteLine("ingrese la cantidad de jugadores");

            contplayers = Convert.ToInt32(Console.ReadLine());

            Personaje[] personajes1 = new Personaje[contplayers];
            Personaje[] personajes2 = new Personaje[contplayers];

            Console.WriteLine("Ingrese personajes del primer equipo");
            for (int i = 0; i < contplayers; i++)
            {
                personajes1[i] = new Personaje();
                Console.WriteLine("ingrese el nombre del jugador " + i);
                personajes1[i].name = Console.ReadLine();
                Console.WriteLine("\n ingrese el nivel del jugador " + i);
                personajes1[i].nivel = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n ingrese la salud del jugador " + i);
                personajes1[i].salud = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n ingrese el puntaje del jugador " + i);
                personajes1[i].puntaje= Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n ingrese el daño del jugador " + i);
                personajes1[i].dmg = Convert.ToInt32(Console.ReadLine());

               
                Console.WriteLine(personajes1[i].name+ personajes1[i].nivel+ personajes1[i].salud+ personajes1[i].puntaje+ personajes1[i].dmg);
            }



            Console.WriteLine("Ingrese personajes del segundo equipo");
            for (int i = 0; i < contplayers; i++)
            {
                personajes2[i] = new Personaje();
                Console.WriteLine("ingrese el nombre del jugador " + i);
                personajes2[i].name = Console.ReadLine();
                Console.WriteLine("\n ingrese el nivel del jugador " + i);
                personajes2[i].nivel = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n ingrese la salud del jugador " + i);
                personajes2[i].salud = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n ingrese el puntaje del jugador " + i);
                personajes2[i].puntaje = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n ingrese el daño del jugador " + i);
                personajes2[i].dmg = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine(personajes2[i].name + personajes2[i].nivel + personajes2[i].salud + personajes2[i].puntaje + personajes2[i].dmg);
            }

            Random random = new Random();
            int num2 = random.Next(1, 3);
            int num1 = random.Next(1, 7);

            Console.WriteLine("Ahora iniciaremos el combate");
            do {
                Console.WriteLine("turno " + turnos);
                Console.WriteLine("Seleccionar personaje del equipo 1 para pelear(escribir numero del personaje)");
                for (int i = 0; i < contplayers; i++)
                {
                    if (personajes1[i].salud > 0)
                    {
                        Console.WriteLine("============================");
                        Console.WriteLine("personaje numero " + i);
                        Console.WriteLine("nombre " + personajes1[i].name);
                        Console.WriteLine("nivel" + personajes1[i].nivel);
                        Console.WriteLine("salud" + personajes1[i].salud);
                        Console.WriteLine("puntaje " + personajes1[i].puntaje);
                        Console.WriteLine("daño " + personajes1[i].dmg);
                    }
                }
                selector1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Seleccionar personaje del equipo 2 para pelear (escribir numero del personaje)");
                for (int i = 0; i < contplayers; i++)
                {
                    if (personajes2[i].salud > 0)
                    {
                        Console.WriteLine("============================");
                        Console.WriteLine("personaje numero " + i);
                        Console.WriteLine("nombre " + personajes2[i].name);
                        Console.WriteLine("nivel" + personajes2[i].nivel);
                        Console.WriteLine("salud" + personajes2[i].salud);
                        Console.WriteLine("puntaje " + personajes2[i].puntaje);
                        Console.WriteLine("daño " + personajes2[i].dmg);
                    }
                }
                selector2 = Convert.ToInt32(Console.ReadLine());
                num2 = random.Next(1, 3);
                if(num2 == 1)
                {
                    Console.WriteLine("");
                    Console.WriteLine("============================");
                    Console.WriteLine(personajes1[selector1].name + " pelea primero contra " + personajes2[selector2].name);
                    Console.WriteLine(personajes1[selector1].name + " lanza un dado de iniciativa y con un 3 o mas golpea a " + personajes2[selector2].name);
                    num1 = random.Next(1, 7);
                    if (num1 >= 3)
                    {
                        Console.WriteLine(personajes1[selector1].name + " golpea a  " + personajes2[selector2].name + " y hace " + personajes1[selector1].dmg + " de daño ");
                        personajes2[selector2].salud -= personajes1[selector1].dmg;
                        if (personajes2[selector2].salud < 1)
                        {
                            Console.WriteLine(personajes2[selector2].name + " murio ");
                            Console.WriteLine(personajes1[selector1].name + " gano 5 de puntaje ");
                            personajes2[selector2].salud = 0;
                            personajes1[selector1].puntaje += 5;
                        }
                    }
                    else
                    {
                        Console.WriteLine(personajes1[selector1].name + " fallo el ataque");
                    }

                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("============================");
                    Console.WriteLine(personajes2[selector2].name + " pelea primero contra " + personajes1[selector1].name);
                    Console.WriteLine(personajes2[selector2].name + " lanza un dado de iniciativa y con un 3 o mas golpea a " + personajes1[selector1].name);
                    num1 = random.Next(1, 7);
                    if (num1 >= 3)
                    {
                        Console.WriteLine(personajes2[selector2].name + " golpea a  " + personajes1[selector1].name + " y hace " + personajes2[selector2].dmg + " de daño ");
                        personajes1[selector1].salud -= personajes2[selector2].dmg;
                        if (personajes1[selector1].salud < 1)
                        {

                            Console.WriteLine(personajes1[selector1].name + " murio ");
                            Console.WriteLine(personajes2[selector2].name + " gano 5 de puntaje ");
                            personajes1[selector1].salud = 0;
                            personajes2[selector2].puntaje += 5;
                        }
                    }
                    else
                    {

                        Console.WriteLine(personajes2[selector2].name + " fallo el ataque");
                    }
                    



                }
               


                for(int i = 0; i < contplayers; i++)
                {
                    contSalud1 += personajes1[i].salud;
                    contSalud2 += personajes2[i].salud;

                }



                if (contSalud1 < 1)
                {
                    Console.WriteLine("el equipo uno completo murio, fin del juego");
                    turnos = 5;
                }

                if (contSalud2<1)
                {
                    Console.WriteLine("el equipo dos completo murio, fin del juego");
                    turnos = 5;
                }







                contSalud1 = 0;
                contSalud2 = 0;

























                turnos++;
            } while (turnos < 5);


            for (int i = 0; i < contplayers; i++)
            {
                contPntje1 += personajes1[i].puntaje;
                contPntje2 += personajes2[i].puntaje;

            }

            if (contPntje1 > contPntje2)
            {

                Console.WriteLine("el equipo uno gana con " + contPntje1 + " puntos, encontra de los " + contPntje2 + " puntos del equipo dos ");
            }


            if (contPntje2 > contPntje1)
            {

                Console.WriteLine("el equipo dos gana con " + contPntje2 + " puntos, encontra de los " + contPntje1 + " puntos del equipo uno ");
            }


            if (contPntje2 == contPntje1)
            {

                Console.WriteLine("tenemos un empate " + contPntje1 +" vs "+ contPntje2);
            }


        }
    }
}
