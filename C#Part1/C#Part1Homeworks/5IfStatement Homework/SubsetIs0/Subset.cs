using System;

class SubSet
{    
	static void Main()    
	{        		
	   int[] intArray = new int[5]; 
       for (int i = 0; i < intArray.Length; i++) 
       {
           Console.WriteLine("Enter Number: ");
           intArray[i] = int.Parse(Console.ReadLine());  
	   }   
		int sum = 0;  
		int subsetCount = 0;
        for (int i = 0; i < intArray.Length; i++)   
        {
            for (int j = i + 1; j < intArray.Length; j++)    
			{        
				sum = intArray[i] + intArray[j];     
				if (sum == 0)         
				{         
				subsetCount++;
                Console.WriteLine("{0} + {1} = {2}", intArray[i], intArray[j], sum);
				}       					
                for (int k = j + 1; k < intArray.Length; k++)  
				{         
					sum = sum + intArray[k];  
					if (sum == 0)    
					{           
					subsetCount++;
                    Console.WriteLine("{0} + {1} + {2} = {3}", intArray[i], intArray[j], intArray[k], sum);
					}        					   
                    for (int l = k + 1; l < intArray.Length; l++)   
                    {            
					    sum = sum + intArray[l];  
					    if (sum == 0)       
					    {                 
					    subsetCount++;
                        Console.WriteLine("{0} + {1} + {2} + {3} = {4}", intArray[i], intArray[j], intArray[k], intArray[l], sum);
					    }               						   
                        for (int m = l + 1; m < intArray.Length; m++)     
						{          
						    sum = sum + intArray[m];     
							if (sum == 0)     
							{           
							subsetCount++;
                            Console.WriteLine("{0} + {1} + {2} + {3} + {4} = {5}", intArray[i], intArray[j], intArray[k], intArray[l], intArray[m], sum);   
							}                   							   
                        }   
                    }    
                }   
            }   
        }   
        Console.WriteLine("There are {0} sums of subsets that are equal to Zero!",subsetCount); 
   }
}