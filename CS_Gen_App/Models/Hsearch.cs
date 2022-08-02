using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Gen_App.Models
{
    public class Hsearch
    {
        public List<string> searchbyname(string Staffname)
        {
            List<string> lststring = new List<string>();
            foreach (var v in globalstaffstore.GlobalStaffStore)
            {

                if (v.Value.StaffName.ToLower() == Staffname)
                {
                    lststring.Add(Convert.ToString(v.Value.StaffId));
                    lststring.Add(v.Value.StaffName);
                    lststring.Add(v.Value.DeptName);
                    lststring.Add(v.Value.Location);
                    lststring.Add(v.Value.Staffcategory);
                }
            }
            return lststring;

        }
        public List<string> searchbyId(int id)
        {
            List<string> lststring1 = new List<string>();
            foreach (var v in globalstaffstore.GlobalStaffStore)
            {

                if (v.Value.StaffId == id)
                {
                    lststring1.Add(Convert.ToString(v.Value.StaffId));
                    lststring1.Add(v.Value.StaffName);
                    lststring1.Add(v.Value.DeptName);
                    lststring1.Add(v.Value.Location);
                    lststring1.Add(v.Value.Staffcategory);

                }
            }
            return lststring1;
        }

        public List<string> searchbylocation(string Location)
        {
            List<string> lststring2 = new List<string>();
            foreach (var v in globalstaffstore.GlobalStaffStore)
            {
                if (v.Value.Location.ToLower() == Location)
                {
                    lststring2.Add(Convert.ToString(v.Value.StaffId));
                    lststring2.Add(v.Value.StaffName);
                    lststring2.Add(v.Value.DeptName);
                    lststring2.Add(v.Value.Location);
                    lststring2.Add(v.Value.Staffcategory);

                }
            }
            return lststring2;
        }
    }
}

