using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            long sizeFild = long.Parse(Console.ReadLine());
            long[] ladyBugs = new long[sizeFild];

            
            long[] possitons = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            for (long i = 0; i < possitons.Length; i++)
            {
                long indexOfLadyBugs = possitons[i];
                //if (ladyBugs.Length>=indexOfLadyBugs)
                if(indexOfLadyBugs>=0&&indexOfLadyBugs<ladyBugs.Length)
                {
                    ladyBugs[indexOfLadyBugs] = 1;
                }
                
            }
            string[] commands= Console.ReadLine().Split(' ').ToArray();
            while (commands[0]!="end")
            {
                long ladybugIndex = Convert.ToInt64(commands[0]);
                string direction = commands[1];
                long flyLenght= Convert.ToInt64(commands[2]);
                if (flyLenght<0)
                {
                    if (direction=="right")
                    {
                        direction = "left";
                    }
                    else
                    {
                        direction = "right";
                    }
                    flyLenght = flyLenght * -1;
                }
                if (direction=="right"&&ladyBugs.Length>ladybugIndex&&ladyBugs[ladybugIndex]==1)
                {
                    ladyBugs[ladybugIndex] = 0;//make index from 1 to 0
                    if (ladyBugs.Length > ladybugIndex + flyLenght)
                    {
                        if (ladyBugs[ladybugIndex+flyLenght]!=1)
                        {
                            ladyBugs[ladybugIndex + flyLenght] = 1;
                        }
                        else//index is 1
                        {
                            for (long i = ladybugIndex+flyLenght; i < ladyBugs.Length; i += flyLenght)
                            {
                                if (ladyBugs[i]!=1)
                                {
                                    ladyBugs[i] = 1;
                                    break;
                                    
                                   // i = ladyBugs.Length - 1;//try to escape from loop
                                }
                               
                                //else
                                //{
                                //    ladyBugs[i] = 0;
                                //}
                            }
                            
                        }
                    }
                }
                else if (direction == "left" && ladyBugs.Length > ladybugIndex && ladyBugs[ladybugIndex] == 1)////left direction
                {
                    ladyBugs[ladybugIndex] = 0;//make index from 1 to 0
                    if (0<= ladybugIndex - flyLenght)
                    {
                        if (ladyBugs[ladybugIndex-flyLenght]!=1)
                        {
                            ladyBugs[ladybugIndex - flyLenght] = 1;
                        }
                        else
                        {
                            for (long i = ladybugIndex-flyLenght; i >=0; i -= flyLenght)
                            {
                                if (ladyBugs[i] != 1)
                                {
                                    ladyBugs[i] = 1;
                                    break;
                                }
                                
                            }
                        }
                    }
                }
                
                commands = Console.ReadLine().Split(' ').ToArray();//read the new command
            }
            for (long i = 0; i < ladyBugs.Length; i++)
            {
                 Console.Write(ladyBugs[i]+" ");
                
            }
        }
    }
}
