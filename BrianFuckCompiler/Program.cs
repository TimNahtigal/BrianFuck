using System;
using System.CodeDom.Compiler;
using Microsoft.CSharp;

namespace BrianFuckCompiler
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             +  fuck[p]++:
             -  fuck[p]--;
             >  p++;
             <  p--; 
             [  while(fuck[p] != 0{
             ]  };
             .  Console.WriteLine((char)fuck[p]);
             ,  fuck[p] = Console.Read();

             k brian[b]++;
             j brian[b]--;
             h b++;
             l b--;
             : fuck[p] = brian[b];
             ; brian[b] = fuck[p];

             ? fuck[p] = r.Next(1, brian[b]);
             */



            const int FUCKlength = 30000;
            const int BRIANlength = 30000;

            Console.WriteLine("Path to code");
            string path = Console.ReadLine();
            string input = System.IO.File.ReadAllText(path);
            string output = "";


            output = "using System;\n" +
                " public class Program{\n" +
                " public static void Main(string[] Args){\n";

            output += "Random r = new Random();\n" +
                "int[] fuck = new int[" + FUCKlength + "];\n" +
                "int[] brian = new int[" + BRIANlength + "];\n" +
                "int p = 0;\n" +
                "int b = 0;\n";
            foreach (char @char in input)
            {
                
                switch (@char)
                {
                    case '+':
                        output +="fuck[p]++;\n";
                        break;
                    case '-':
                        output += "fuck[p]--;\n";
                        break;
                    case '>':
                        output += "p++;\n";
                        break;
                    case '<':
                        output += "p--;\n";
                        break;
                    case '[':
                        output += "while(fuck[p]!=0){\n";
                        break;
                    case ']':
                        output += "}\n";
                        break;
                    case '.':
                        output += "Console.WriteLine((char)fuck[p]);\n";
                        break;
                    case ',':
                        output += "fuck[p] = (int)Console.ReadLine()[0];\n";
                        break;
                        

                    case 'k':
                        output += "brian[b]++;\n";
                        break;
                    case 'j':
                        output += "brian[b]--;\n";
                        break;
                    case 'l':
                        output += "b++;\n";
                        break;
                    case 'h':
                        output += "b--;\n";
                        break;
                    case ':':
                        output += "fuck[p] = brian[b];\n";
                        break;
                    case ';':
                        output += "brian[b] = fuck[p];\n";
                        break;
                    case '?':
                        output += "fuck[p] = r.Next(1, brian[b]);\n";
                        break;
                    default:
                        break;
                }
            }
            output += "Console.ReadLine();\n}\n}";
            //Console.WriteLine(output);

            var csc = new CSharpCodeProvider();
            var parameters = new CompilerParameters(new[] { "mscorlib.dll", "System.Core.dll" }, "BrianFuck.exe", true);
            parameters.GenerateExecutable = true;
            CompilerResults result = csc.CompileAssemblyFromSource(parameters, output);

            if (result.Errors.Count == 0)
            {
                Console.WriteLine("Sucesfull");
            }
            else
            {
                Console.WriteLine("Unsucesfull");
            }


        }
    }
}



