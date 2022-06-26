using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Quarantine
{
    class PlanList
    {
        List<Plan> p_list = new List<Plan>();

       
        public List<Plan> GetPlans()
        {
            return p_list;
        }

        public void Load(List<Plan> plans)
        {
            this.p_list = plans;
        }

        public void Add(Plan p)
        {
            this.p_list.Add(p);
        }

        public void RemovePlan(Plan p)
        {
            this.p_list.Remove(p);
        }
        
        public int Count()
        {
            return this.p_list.Count();
        }

        public void Sort()
        {
            this.p_list.OrderBy(x => x.Time.TimeOfDay);
        }

        public int IndexOfPlan(Plan p)
        {
            return this.p_list.IndexOf(p);
        }

        public Plan GetPlanByIndex(int i)
        {
            return this.p_list[i];
        }

        public String GetPlansToString()
        {
            String t="";

            foreach (Plan p in this.p_list)
            {
                t = t + "\n Plan: " + p_list.IndexOf(p).ToString();
                t = t + "\n" + p.PlanText();
            }
            return t;
        }

    }
}
