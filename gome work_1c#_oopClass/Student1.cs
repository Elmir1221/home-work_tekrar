
using System.Security.Cryptography.X509Certificates;

namespace gome_work_1c__oopClass
{
    internal class Student
    {

        public string name;
        public string surname;
        public int age;
        public string adress;
        public string phone;

        public void ShowText()  
        {
            string text = "shffhajk";
            Console.WriteLine(text);
        
        }

        public string GoFullName() 
        {
        
         return name + " "+ surname;
          
        }
        public string GetFullDatas() 
        {
            string fullData = $"name {name} surname {surname }age{age} adress {adress} phone {phone}";
        }
    }


}

