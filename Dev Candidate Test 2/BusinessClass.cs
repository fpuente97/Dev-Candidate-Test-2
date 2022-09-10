using System.Text.Json;
using System.Text.RegularExpressions;

namespace Dev_Candidate_Test_2
{
    public class ManageEmployeesClass
    {
        public List<Employee> EmployeesList { get; private set; }
        private string filepath = AppDomain.CurrentDomain.BaseDirectory + @"\EmployeeData.json";
        public ManageEmployeesClass()
        {
            EmployeesList = new List<Employee>();
            CreateJSONIfNoExist();
        }
        public void LoadEmployees() //From JSONFile
        {
            EmployeesList = new List<Employee>();

            using (StreamReader sr = new StreamReader(filepath))
            {
                string json = sr.ReadToEnd();
                EmployeesList = JsonSerializer.Deserialize<List<Employee>>(json);
            }
        }
        public void AddEmployee(Employee emp)
        {
            //Add Employee to EmployeesList
            var rfcunique = EmployeesList.Count(x => x.RFC == emp.RFC);
            if (rfcunique > 0)
                throw new Exception();

            RFCValidate(emp.RFC);
            emp.ID = NewID();
            EmployeesList.Add(emp);
        }
        public void SaveEmployeesChanges()
        {
            //Method to save data in the JSON file
            string json = JsonSerializer.Serialize(EmployeesList, new JsonSerializerOptions() {WriteIndented = true});
            using (StreamWriter sw = new StreamWriter(filepath))
            {
                sw.WriteLine(json);
            }
        }
        public Employee GetEditEmployee(int ID)
        {
            //Get Employee to edit in the EmployeeList
            Employee emp = EmployeesList.First(x => x.ID == ID);
            return emp;
        }
        public void UpdateEditEmployee(Employee emp)
        {
            //Update employee data in EmployeesList
            foreach (var empItem in EmployeesList.Where(x => x.ID == emp.ID))
            {
                var rfcunique = EmployeesList.Where(r=> r.ID != emp.ID).Count(x => x.RFC == emp.RFC); //Search if the edited RFC equals another employee's
                if (rfcunique > 0)
                    throw new Exception();
                RFCValidate(emp.RFC);
                empItem.Name = emp.Name;
                empItem.LastName = emp.LastName;
                empItem.RFC = emp.RFC;
                empItem.BornDate = emp.BornDate;
                empItem.Status = emp.Status;
            }
        }
        public List<Employee> FilteredList(string Name)
        {
            //Return a second list filtered by Name
            return EmployeesList.Where(x => x.Name == Name).ToList();
        }
        public void SortListByBornDate(bool IsAscending)
        {
            if(IsAscending)
                EmployeesList = EmployeesList.OrderBy(x => x.BornDate).ToList();
            else
                EmployeesList = EmployeesList.OrderByDescending(x => x.BornDate).ToList();
        }
        private void RFCValidate(string RFC)
        {
            bool result = true;
            Regex rx = new Regex("^[A-Z]{4}[0-9]{6}[A-Z0-9]{3}$"); //Validate mexican RFC Format XXXX######$$$ where XXXX
                                                                   //represents the full name, ###### the date of birth and $$$ the homoclave
            result = rx.IsMatch(RFC);

            if(!result)
                throw new Exception();
        }
        private int NewID()
        {
            return EmployeesList.Count + 1; //Create new ID number
        }
        private void CreateJSONIfNoExist()
        {
            if (!File.Exists(filepath))
            {
                using (var myfile = File.Create(filepath))
                    myfile.Close();
                using (StreamWriter sw = new StreamWriter(filepath))
                    sw.WriteLine("[]");
            }
        }
    }
}
