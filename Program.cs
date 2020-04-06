using System;
using System.IO;
using System.Text;


class nullVariable
{
    public static void Main()
    {

        try
        {

            string[] filePaths = Directory.GetFiles(@"C:\Users\soham.a.ghosh\Desktop\ROQL - Copy (4)\", "*.cs", SearchOption.AllDirectories);
            // Loop through the directory to get all the .cs files
            foreach (string f in filePaths)
            {
                //Console.WriteLine(f);
                //the path of the file
                // FileStream inFile = new FileStream(@"C:\Users\arindam.x.chatterjee\Desktop\Arindam\CI\CRT in C#\dotnet_code_null.cs", FileMode.Open, FileAccess.Read);
                //   StreamReader reader = new StreamReader(inFile);
                string[] words;
                char[] charsToTrim = { '\t' };
                int i = 0;
                int j = 0;
                int len = 0;
                int k = 0;
                string line;
                string Oldfile = null;

                string[] inp = new string[100];
                string fileName = f;
                string result;

                using (StreamReader reader = new StreamReader(fileName))
                    while ((line = reader.ReadLine()) != null)//Loop through the file line by line to check end of file
                    {
                        //  line.Remove('\t');
                        line = line.Trim();
                        if (line.Contains("String") || line.Contains("string"))//Check for keyword String in the line
                        {


                            if (line.Contains("null"))// Check if the line having keyword String also containing keyword null
                            {
                                words = line.Split(' ');//split the line and srore in words array


                                len = words.Length;

                                while (j < len)// Loop through all the words in the line
                                {
                                    // words[j].Replace(" ", string.Empty);
                                    // ignore for null indexed value and 
                                    //   Console.WriteLine("WORD: " + words[j]);
                                    // if(words[j].Equals("String") || words[j].Equals("string" ))
                                    if ((words[j] == "String") || (words[j] == "string"))// if the words array index is having value as string
                                    {
                                        if (words[j + 2] == "=") //Checking for = in 2nd index after the index storing "String"
                                        {
                                            //input = new string[] 
                                            //{
                                            result = Path.GetFileName(fileName);
                                            if (result != Oldfile)
                                            { Console.WriteLine("FILENAME: " + result); }
                                            Oldfile = result;

                                            inp[k] = words[j + 1];//Storing the null initialied variables into inp array


                                            Console.WriteLine("INPUT: " + inp[k]);

                                            k++;
                                            //}
                                        }
                                    }
                                    //input[i] = words[j];
                                    i++; ;
                                    j++;


                                }
                                j = 0;


                            }
                        }


                    }

            }


        }
        catch (Exception exp)
        {
            // after the record is done being read, the progam closes
            // filename.Close();
            //  inFile.Close();
            Console.WriteLine(exp.Message);
        }
    }

}
