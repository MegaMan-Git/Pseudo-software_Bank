using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public static class Dataclass
    {
        public static int NEED = 0;
        public static int TimeNEED = 0;
        public static int WithDepNEED = 0;
        public static List<Client> Clients = new List<Client>();
        public static List<Employee> Employees = new List<Employee>();
        public static Manager manager = new Manager();
    }

    public class Client
    {
       public bool Cl_ban = false;
       public string Username="";
       public string Password="";
       public int Money=10000;
       public string[] Timesave = new string[3];
       public string[] WithDepMoney = new string[3]; 

       public void Deposite(int money)
        {
            Money += money;
        }
       public void Withraw(int money)
        {
            if (Money > money)
            {
                Money -= money;
               MessageBox.Show("برداشت با موفقیت انجام شد");
            }
            
        }
        
    }
   public class Employee : Client
    {
       
       public string Em_username = "";
       public string Em_password = "";
       public bool ban()
       {
           return true;
       }
    }
  public class Manager : Employee
    {
       public string MAIN_User = "Amir rafiey";
       public string MAIN_Pass = "12345678";
       public List<string> History = new List<string>();
        
        public void remove(string name,string password,double money)
        {
            name = "";
            password = "";
            money = 0;
        }
    }
}