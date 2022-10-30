using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examen_2_Pilas.GUI
{
    public class Main
    {
        public void program()
        {
            ConsoleColor prevColor = Console.ForegroundColor;

            Stack<char> operacion = new Stack<char>();

            string msg;
            bool balanceado = true;

            Console.Write("Dame la ecuasion: ");
            msg = Console.ReadLine();


            Console.ForegroundColor = ConsoleColor.Red;

            for (int i = 0; i < msg.Length; i++)
            {
                if (msg[i] == '(' || msg[i] == '[')
                {
                    operacion.Push(msg[i]);
                }


                if (msg[i] == ')')
                {
                    try
                    {
                        if (operacion.Pop() == '(')
                        {
                            continue;
                        }
                        else
                        {
                            balanceado = false;
                            break;
                        }
                    }
                    catch (System.Exception)
                    {
                        balanceado = false;
                        break;
                    }
                }
                else if (msg[i] == ']')
                {
                    try
                    {
                        if (operacion.Pop() == '[')
                        {
                            continue;
                        }
                        else
                        {

                            balanceado = false;
                            break;

                        }
                    }
                    catch (System.Exception)
                    {
                        balanceado = false;
                        break;
                    }
                }
            }

            if (!balanceado || operacion.Count != 0)
            {
                Console.WriteLine("No esta Balanceado");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Esta balanceado");
            }

            Console.ForegroundColor = prevColor;
        }
    }
}