using System;

namespace Clase_Asociacion
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int j = 0;

            cPerson[] vecPerC1 = new cPerson[1];
            cPerson[] vecPerC2 = new cPerson[3];
            cPerson[] vecPerC3 = new cPerson[2];
            cPerson[] vecPerC4 = new cPerson[2];
            cPerson[] vecPerC5 = new cPerson[2];

            cPerson p1 = new cPerson("Jhon", "Cook", "222111333");
            cPerson p2 = new cPerson("Jim", "Morrison", "333111444");
            cPerson p3 = new cPerson("Arnold", "Swchatzzeneger", "444111555");
            cPerson p4 = new cPerson("Luca", "Prodan", "555111666");

            vecPerC1[0] = p1;

            vecPerC2[0] = p1;
            vecPerC2[1] = p2;
            vecPerC2[2] = p3;

            vecPerC3[0] = p1;
            vecPerC3[1] = p2;

            vecPerC4[0] = p3;
            vecPerC4[1] = p4;

            vecPerC5[0] = p3;
            vecPerC5[1] = p4;


            cCar[] vecCarP1 = new cCar[3];
            cCar[] vecCarP2 = new cCar[3];
            cCar[] vecCarP3 = new cCar[2];
            cCar[] vecCarP4 = new cCar[2];

            cCar a1 = new cCar("Porsche","One","1987");
            cCar a2 = new cCar("Porsche","Two","1990");
            cCar a3 = new cCar("Porsche","Tree","1997");
            cCar a4 = new cCar("Porsche","Four","2001");
            cCar a5 = new cCar("Porsche","Five","2018");

            vecCarP1[0] = a1;
            vecCarP1[1] = a2;
            vecCarP1[2] = a3;

            vecCarP2[0] = a1;
            vecCarP2[1] = a2;
            vecCarP2[2] = a3;

            vecCarP3[0] = a2;
            vecCarP3[1] = a5;

            vecCarP4[0] = a2;
            vecCarP4[1] = a5;


            MiddleClass[] PersonCar = new MiddleClass[4];

            MiddleClass[] CarPerson = new MiddleClass[4];


            PersonCar[0] = new MiddleClass(p1, vecCarP1);
            PersonCar[1] = new MiddleClass(p2, vecCarP2);
            PersonCar[2] = new MiddleClass(p3, vecCarP3);
            PersonCar[3] = new MiddleClass(p4, vecCarP4);

            CarPerson[0] = new MiddleClass(a1, vecPerC1);
            CarPerson[1] = new MiddleClass(a2, vecPerC2);
            CarPerson[2] = new MiddleClass(a3, vecPerC3);
            CarPerson[3] = new MiddleClass(a4, vecPerC4);


            /*Relation which cars are assigned to each person*/

            for (i = 0; i < PersonCar.Length; i++)
            {
                Console.WriteLine($"{PersonCar[i].Person.Name} {PersonCar[i].Person.LastName} has the following car(s) assigned");


                    cCar[] aCarsPC = PersonCar[i].Cars;

                    for (j = 0; j < aCarsPC.Length; j++)
                    {
                        Console.WriteLine($"{aCarsPC[j].Marca}" + "\t"+$"{aCarsPC[j].Model}"+"\t"+$"{aCarsPC[j].Year}");
                    }   
  
            }


            /*Relation the other way around,to know which persons are assigned to each car*/

            for (i = 0; i < CarPerson.Length; i++)
            {
                Console.WriteLine($"{CarPerson[i].Car.Model} is assigned to the following people" + "\n");


                    cPerson[] aPersonCP = CarPerson[i].Persons;

                    for (j = 0; j < aPersonCP.Length; j++)
                    {
                    Console.WriteLine("");
                    }
                

            
            
            
            
            }


        }
    }
}
