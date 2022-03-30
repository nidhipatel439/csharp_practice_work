using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Practice_loop_questions.Controllers
{
    public class LoopPracticeController : ApiController
    {
        [HttpGet]
        [Route("api/LoopPractice/Counter/{start}/{limit}/{step}")]

        public string Counter(int start, int limit, int step)
        {

            List<int> array = new List<int>();

            if (start >= limit && step < 0)
            {
                for (int i = start; i >= limit; i += step)
                {
                    array.Add(i);
                }
            }
            else if (start <= limit && step > 0)
            {
                for (int i = start; i <= limit; i += step)
                {
                    array.Add(i);
                }
            }
            else
            {
                array.Add(0);
            }
            //return "[" + message + "]";
            return $"[{string.Join(", ", array)}]";

        }

        [HttpGet]
        [Route("api/LoopPractice/FizzyBuzzy/{start}/{limit}/{step}/{Fizzy}/{Buzzy}")]

        public string FizzyBuzzy(int start, int limit, int step, int Fizzy, int Buzzy)
        {
            
            List<string> array = new List<string>();

            if (start >= limit && step < 0)
            {
                for (int i = start; i >= limit; i += step)
                {
                    if (i % Fizzy == 0 && i % Buzzy == 0)
                    {
                        array.Add("FizzyBuzzy");
                    }
                    else if (i % Fizzy == 0)
                    {
                        array.Add("Fuzzy");
                    }
                    else if (i % Buzzy == 0)
                    {
                        array.Add("Buzzy");
                    }
                    else
                    {
                        array.Add(i.ToString());
                    }
                }
            }
            else if (start <= limit && step > 0)
            {
                for (int i = start; i <= limit; i += step)
                {
                    if (i % Fizzy == 0 && i % Buzzy == 0)
                    {
                        array.Add("FizzyBuzzy");
                    }
                    else if (i % Fizzy == 0)
                    {
                        array.Add("Fuzzy");
                    }
                    else if (i % Buzzy == 0)
                    {
                        array.Add("Buzzy");
                    }
                    else
                    {
                        array.Add(i.ToString());
                    }
                }
            }
            else
            {
                array.Add("0");
            }
            
            return $"{string.Join("," ,array)}";
        }
        
    }
}
