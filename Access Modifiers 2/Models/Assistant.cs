using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifiers_2.Models
{
    internal class Assistant : Manager
    {
        public void GetFeedBack(Employee employee)
        {
            if (employee.IsSuccessfull == true)
            {
                GetPromotion(employee);
            }
            else
            {
                Console.WriteLine("Daxil etdiyiniz isci sertleri odemir");
            }
        }
    }
}
