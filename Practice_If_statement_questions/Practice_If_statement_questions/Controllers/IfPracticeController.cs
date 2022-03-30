using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Practice_If_statement_questions.Controllers
{
    public class IfPracticeController : ApiController
    {
        [HttpGet]
        [Route("api/IfPractice/CoinComputer/{nickels}/{dimes}/{quarters}/{loonies}/{twoonies}")]

        public bool CoinComputer(int nickels, int dimes, int quarters, int loonies, int twoonies)
        {
            double cost = 10.50;
            double nickelsValue = 0.05;
            double dimesValue = 0.10;
            double quartersValue = 0.25;
            double looniesValue = 1;
            double twooniesValue = 2;

            double total = (nickels * nickelsValue) + (dimes * dimesValue) + (quarters * quartersValue) + (loonies * looniesValue) + (twoonies * twooniesValue);
            if (total >= cost)
            {
              return true;
            }
            else
            {
              return false;
            }
            //double cost1 = nickels * nickelsValue;
            //double cost2 = dimes * dimesValue;
            //double cost3 = quarters * quartersValue;
           // double cost4 = loonies * looniesValue;
            //double cost5 = twoonies * twooniesValue;

            //return total.ToString() + " cost1 :" + cost1.ToString() + " cost 2:" + cost2.ToString() + " cost 3:" + cost3.ToString()+ " cost 4:" + cost4.ToString() + " cost 5:" + cost5.ToString();
        } 
    
        [HttpGet]
        [Route("api/IfPractice/PointQuadrant/{x}/{y}")]

        public int PointQuadrant(int x, int y)
        {
            if(x>0 && y > 0)
            {
                return 1;
            } 
            else if(x<0 && y>0){
                return 2;
            }
            else if(x<0 && y < 0)
            {
                return 3;
            }
            else if(x>0 && y < 0)
            {
                return 4;
            }else
            {
                return 0;
            }
        }
    
        
    }
}
