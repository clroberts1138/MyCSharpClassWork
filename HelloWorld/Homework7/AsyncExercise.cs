using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Linq;

namespace Homework7
{
    public class AsyncExercise
    {
        public async Task MyMethodAsync()
        {
            Task<int> longRunningTask = LongRunningOperationAsync();
            Task<int> longRunningTask2 = LongRunningOperationAsync2();
            Task<int> longRunningTask3 = LongRunningOperationAsync3();
            Task<int> longRunningTask4 = LongRunningOperationAsync4();
            Task<int> longRunningTask5 = LongRunningOperationAsync5();

            // independent work which doesn't need the result of LongRunningOperationAsync can be done here

            Console.WriteLine("This is in the Mymethod Async exercise process it is before the await command");
            Console.WriteLine("This simulates doing processing while other processes are running in the background");
            
            //and now we call await on the task 
            int result = await longRunningTask;
            //use the result 
            Console.WriteLine();
            Console.WriteLine(result);

            int result2 = await longRunningTask2;
            //use the result 
            Console.WriteLine();
            Console.WriteLine(result2);

            int result3 = await longRunningTask3;
            //use the result 
            Console.WriteLine();
            Console.WriteLine(result3);

            int result4 = await longRunningTask4;
            //use the result 
            Console.WriteLine();
            Console.WriteLine(result4);

            int result5 = await longRunningTask5;
            //use the result 
            Console.WriteLine();
            Console.WriteLine(result5);


        }

        public async Task<int> LongRunningOperationAsync() // assume we return an int from this long running operation 
        {
            await Task.Delay(1000); // 1 second delay
            Console.WriteLine("This is in Task1");
            return 1;
        }

        public async Task<int> LongRunningOperationAsync2() // assume we return an int from this long running operation 
        {
            await Task.Delay(1000); // 1 second delay
            Console.WriteLine("This is in Task2");
            return 2;
        }

        public async Task<int> LongRunningOperationAsync3() // assume we return an int from this long running operation 
        {
            await Task.Delay(1000); // 1 second delay
            Console.WriteLine("This is in Task3");
            return 3;
        }

        public async Task<int> LongRunningOperationAsync4() // assume we return an int from this long running operation 
        {
            await Task.Delay(1000); // 1 second delay
            Console.WriteLine("This is in Task4");
            return 4;
        }

        public async Task<int> LongRunningOperationAsync5() // assume we return an int from this long running operation 
        {
            await Task.Delay(1000); // 1 second delay
            Console.WriteLine("This is in Task5");
            return 5;
        }
    }
}
