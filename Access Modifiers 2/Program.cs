using Access_Modifiers_2.Models;
using System.Runtime.CompilerServices;

namespace Access_Modifiers_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Manager classi yaradirsiz:
                GetPromotion() GetPromoyion ancaq oz classinda ve derived classda gorsenmelidir.
                Employee qebul edir employee maashin 100 vahid artirir ve geriye Employee oturur

                Assistant classi yaradirsiz:
                GetFeedBack() bu method Employee qebul edir eger Sucessfull-dursa GetPromotion methodu
                ishe dushmelidir

                Employee classi yaradirsiz:
                Name
                IsSuccessfull
                Salary propertyleri olur 
            */


            Employee employee = new Employee("Elxan",1000,true);
            Assistant assistant = new Assistant();
            assistant.GetFeedBack(employee);
            Console.WriteLine(employee.Salary);
        }
    }
}